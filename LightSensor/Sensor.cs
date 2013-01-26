using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Management;
using WebCamLib;
using System.Threading;

namespace LightSensor
{
    public class Sensor
    {
        CameraMethods camera;
        SensorState state = SensorState.Idle;
        Timer tmrTick;
        Timer tmrCloseCamera;
        
        int img_width = 0;
        int img_height = 0;


        private int check_interval=10000;
        private bool running = false;
        private int current_camera = -1;
        private List<CameraInfo> cameras;

        private int frames = 0;
        private uint brightness = 0;

        enum SensorState
        {
            Idle,
            Capturing,
            DoneCapturing
        }

        public Sensor()
        {
            camera = new CameraMethods();
            camera.OnImageCapture += new CameraMethods.CaptureCallbackDelegate(camera_OnImageCapture);
            if (camera.Count == 0)
            {
                //no hay camara, iniciar una excepcion
                throw new Exception("No webcam found!");
            }
            tmrTick = new Timer(new TimerCallback(tmrTick_Tick));
            tmrCloseCamera = new Timer(new TimerCallback(tmrCloseCamera_Tick));
            tmrTick.Change(Timeout.Infinite, Timeout.Infinite);
            tmrCloseCamera.Change(Timeout.Infinite, Timeout.Infinite);

            cameras = new List<CameraInfo>();
            for (int x = 0; x < camera.Count; x++)
            {
                cameras.Add(camera.GetCameraInfo(x));
            }
        }

        public void Start()
        {
            if (running)
                return;
            tmrTick.Change(10000, check_interval);
            running = true;
            state = SensorState.Idle;
        }

        public void Stop()
        {

            tmrTick.Change(Timeout.Infinite, Timeout.Infinite);
            tmrCloseCamera.Change(Timeout.Infinite, Timeout.Infinite);

            try
            {
                if (camera != null)
                    camera.StopCamera();
            }
            catch { }
            //camera = null;
            //tmrCloseCamera = null;
            //tmrTick=null;

            //System.GC.Collect();
            //System.GC.WaitForFullGCComplete();
            running = false;
            state = SensorState.Idle;
        }

        void camera_OnImageCapture(int dwSize, byte[] abData)
        {
            if (state != SensorState.Capturing)
                return;

            brightness += WhiteLevel(abData);

            //ManagementObjectSearcher searcher = new ManagementObjectSearcher(new ManagementScope("\\root\\wmi"), new ObjectQuery("Select * from WmiMonitorBrightness"));
            //foreach (ManagementObject o in searcher.Get())
            //{
            //    bright = short.Parse(o["CurrentBrightness"].ToString());
            //}
            if (frames == 5)
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(new ManagementScope("\\root\\wmi"), new ObjectQuery("Select * from WmiMonitorBrightnessMethods"));
                foreach (ManagementObject o in searcher.Get())
                {
                    o.InvokeMethod("WmiSetBrightness", new Object[] { 0, (uint)(brightness / (uint)frames) });
                }
                state = SensorState.DoneCapturing;
            }
            frames++;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {

        }

        private uint WhiteLevel(byte[] data)
        {
            //From:http://social.msdn.microsoft.com/Forums/en/roboticssimulation/thread/4e53a3c8-97c4-4560-9aae-bcc8609951d2
            //brightness = 0.299 * R + 0.587 * G + 0.114 * B
            float brightness=0.0f;
            uint white = 0;
            //uint max = 0;
            for (int x = 0; x < data.Length; x+=6)
            {
                brightness += 0.299f * (float)data[x];
                brightness += 0.587f * (float)data[x + 1];
                brightness += 0.114f * (float)data[x + 2];
                //white += data[x];
                //if (data[x] > max)
                //    max = data[x];
            }
            //white = (uint)((100 * white / data.Length) / 64);
            white = (uint)(brightness / (data.Length/3));
            return white >= 0 ? white : 0;
        }

        private void tmrTick_Tick(Object status)
        {
            
            if (state!=SensorState.Idle || current_camera < 0 || !running)
                return;

            try
            {
                camera.StartCamera(current_camera, ref img_width, ref img_height);
                state = SensorState.Capturing;
                frames = 0;
                brightness = 0;

                tmrTick.Change(Timeout.Infinite, Timeout.Infinite);
                tmrCloseCamera.Change(750, 750);
            }
            catch 
            {
                //La camara stá en uso por lo que simplemente no se hace nada de sensar la luz
                //O tal vez no hay camara =)
            }
        }

        private void tmrCloseCamera_Tick(Object status)
        {
            if (state==SensorState.DoneCapturing)
            {
                camera.StopCamera();
                tmrTick.Change(check_interval, check_interval);
                tmrCloseCamera.Change(Timeout.Infinite, Timeout.Infinite);
                state = SensorState.Idle;
            }
        }

        public int CheckInterval
        {
            get
            {
                return check_interval;
            }
            set
            {
                check_interval = value;
                if (state==SensorState.Idle && running)
                {
                    tmrTick.Change(0, check_interval);
                }
            }
        }

        public bool IsRunning
        {
            get
            {
                return running;
            }
        }

        public int CurrentWebCam
        {
            get
            {
                return current_camera;
            }
            set
            {
                current_camera = value;
            }
        }

        public List<CameraInfo> WebCamListing
        {
            get
            {
                return cameras;
            }
        }
    }
}
