using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Permissions;

namespace LightSensor
{
    public partial class frmMain : Form
    {

        Sensor sensor;
        List<ToolStripMenuItem> intervalos;
        RegistryKey registry;

        private bool auto_start = false;

        public frmMain(Sensor sensor)
        {
            InitializeComponent();
            
            this.sensor = sensor;

            CheckRegistry();

            sensor.Start();
            intervalos = new List<ToolStripMenuItem>();
            intervalos.Add(segundoToolStripMenuItem);
            intervalos.Add(segundosToolStripMenuItem1);
            intervalos.Add(segundosToolStripMenuItem);
            intervalos.Add(minutoToolStripMenuItem);
            intervalos.Add(minutosToolStripMenuItem);
            intervalos.Add(horaToolStripMenuItem);
            intervalos.Add(horaToolStripMenuItem1);
            intervalos.Add(toolStripMenuItem3);
            intervalos.Add(toolStripMenuItem4);
            WebCamListing();

        }

        private void WebCamListing()
        {
            
            ToolStripMenuItem itm = new ToolStripMenuItem("(none)");
            itm.Tag = "-1";
            webCamToolStripMenuItem.DropDownItems.Add(itm);
            itm.Click += new EventHandler(CameraSelection_Click);
            foreach (WebCamLib.CameraInfo info in sensor.WebCamListing)
            {
                itm = new ToolStripMenuItem(info.name);
                itm.Tag = info.index.ToString();
                itm.Click += new EventHandler(CameraSelection_Click);
                webCamToolStripMenuItem.DropDownItems.Add(itm);
            }
        }

        private void CheckRegistry()
        {
            registry = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            Object startup = registry.GetValue("LightSensor");
            auto_start = startup!=null;

            registry = Registry.CurrentUser.OpenSubKey("SOFTWARE\\LightSensor");
            if (registry != null)
            {
                Object value = registry.GetValue("Interval",10000);
                sensor.CheckInterval = (int)value;
                value = registry.GetValue("CurrentWebCam", -1);
                sensor.CurrentWebCam = (int)value;
            }
        }

        private void SaveRegistry()
        {
            registry = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", RegistryKeyPermissionCheck.ReadWriteSubTree);
            if (auto_start)
                registry.SetValue("LightSensor", Application.ExecutablePath, RegistryValueKind.String);
            else if (registry.GetValue("LightSensor") != null)
                registry.DeleteValue("LightSensor");

            registry = Registry.CurrentUser.OpenSubKey("SOFTWARE\\LightSensor", RegistryKeyPermissionCheck.ReadWriteSubTree);
            if (registry == null)
            {
                registry = Registry.CurrentUser.CreateSubKey("SOFTWARE\\LightSensor", RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
            registry.SetValue("Interval", sensor.CheckInterval,RegistryValueKind.DWord);
            registry.SetValue("CurrentWebCam", sensor.CurrentWebCam, RegistryValueKind.DWord);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender == salirToolStripMenuItem)
                {
                    this.Close();
                }
                else if (sender == configuraciónToolStripMenuItem)
                {
                    this.Show();
                    this.ShowInTaskbar = true;
                    this.WindowState = FormWindowState.Normal;
                }
                else if (sender == detenerToolStripMenuItem)
                    sensor.Stop();
                else if (sender == iniciarToolStripMenuItem)
                    sensor.Start();
                else if (sender == otroToolStripMenuItem)
                    ;//Show();
                else if (sender == intervaloToolStripMenuItem)
                    ;//nah
                else
                {
                    int value;
                    if (Int32.TryParse((sender as ToolStripMenuItem).Tag.ToString(), out value))
                    {
                        sensor.CheckInterval = value;
                    }
                }
            }
            catch
            { }
        }

        private void msMenu_Opening(object sender, CancelEventArgs e)
        {
            iniciarToolStripMenuItem.Checked = sensor.IsRunning;
            detenerToolStripMenuItem.Checked = !sensor.IsRunning;
            MarkIntervalMenu(sensor.CheckInterval);
            MarkWebCamMenu(sensor.CurrentWebCam);
            startupStripMenuItem.Checked = auto_start;
        }

        private void MarkIntervalMenu(int value)
        {
            bool chk=false;
            foreach (ToolStripMenuItem mi in intervalos)
            {
                if(mi.Tag!=null)
                    chk |= mi.Checked = mi.Tag.ToString() == value.ToString();
            }
            otroToolStripMenuItem.Checked = !chk;
        }

        private void MarkWebCamMenu(int value)
        {
            foreach (ToolStripMenuItem mi in webCamToolStripMenuItem.DropDownItems)
            {
                if (mi.Tag != null)
                    mi.Checked = mi.Tag.ToString() == value.ToString();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = true;
            //    this.Hide();
            //    this.ShowInTaskbar = false;
            //}

            SaveRegistry();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
            }
        }


        private void niTray_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    this.ShowInTaskbar = true;
            //    this.WindowState = FormWindowState.Normal;
            //    this.Show();
            //}
        }

        private void startupStripMenuItem_Click(object sender, EventArgs e)
        {
            auto_start = startupStripMenuItem.Checked = !startupStripMenuItem.Checked;
        }

        private void CameraSelection_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itm = (ToolStripMenuItem)sender;
            int value=0;
            if (Int32.TryParse(itm.Tag.ToString(), out value))
            {
                sensor.CurrentWebCam = value;
            }
        }
    }
}
