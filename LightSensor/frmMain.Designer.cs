namespace LightSensor
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.niTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.msMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.intervaloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.segundosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segundosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.otroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // niTray
            // 
            this.niTray.ContextMenuStrip = this.msMenu;
            this.niTray.Icon = ((System.Drawing.Icon)(resources.GetObject("niTray.Icon")));
            this.niTray.Text = "LightSensor";
            this.niTray.Visible = true;
            this.niTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.niTray_MouseClick);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intervaloToolStripMenuItem,
            this.iniciarToolStripMenuItem,
            this.detenerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.configuraciónToolStripMenuItem,
            this.webCamToolStripMenuItem,
            this.startupStripMenuItem,
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem});
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(158, 192);
            this.msMenu.Opening += new System.ComponentModel.CancelEventHandler(this.msMenu_Opening);
            // 
            // intervaloToolStripMenuItem
            // 
            this.intervaloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segundoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.segundosToolStripMenuItem,
            this.segundosToolStripMenuItem1,
            this.minutoToolStripMenuItem,
            this.minutosToolStripMenuItem,
            this.horaToolStripMenuItem,
            this.horaToolStripMenuItem1,
            this.otroToolStripMenuItem});
            this.intervaloToolStripMenuItem.Name = "intervaloToolStripMenuItem";
            this.intervaloToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.intervaloToolStripMenuItem.Text = "Sense Interval";
            this.intervaloToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // segundoToolStripMenuItem
            // 
            this.segundoToolStripMenuItem.Checked = true;
            this.segundoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.segundoToolStripMenuItem.Name = "segundoToolStripMenuItem";
            this.segundoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.segundoToolStripMenuItem.Tag = "1000";
            this.segundoToolStripMenuItem.Text = "1 Second";
            this.segundoToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Tag = "2000";
            this.toolStripMenuItem3.Text = "2 Seconds";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Tag = "5000";
            this.toolStripMenuItem4.Text = "5 Seconds";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // segundosToolStripMenuItem
            // 
            this.segundosToolStripMenuItem.Name = "segundosToolStripMenuItem";
            this.segundosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.segundosToolStripMenuItem.Tag = "10000";
            this.segundosToolStripMenuItem.Text = "10 Seconds";
            this.segundosToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // segundosToolStripMenuItem1
            // 
            this.segundosToolStripMenuItem1.Name = "segundosToolStripMenuItem1";
            this.segundosToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.segundosToolStripMenuItem1.Tag = "30000";
            this.segundosToolStripMenuItem1.Text = "30 Seconds";
            this.segundosToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // minutoToolStripMenuItem
            // 
            this.minutoToolStripMenuItem.Name = "minutoToolStripMenuItem";
            this.minutoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minutoToolStripMenuItem.Tag = "60000";
            this.minutoToolStripMenuItem.Text = "1 Minute";
            this.minutoToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // minutosToolStripMenuItem
            // 
            this.minutosToolStripMenuItem.Name = "minutosToolStripMenuItem";
            this.minutosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minutosToolStripMenuItem.Tag = "300000";
            this.minutosToolStripMenuItem.Text = "5 Minutes";
            this.minutosToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // horaToolStripMenuItem
            // 
            this.horaToolStripMenuItem.Name = "horaToolStripMenuItem";
            this.horaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.horaToolStripMenuItem.Tag = "1800000";
            this.horaToolStripMenuItem.Text = "30 Minutes";
            this.horaToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // horaToolStripMenuItem1
            // 
            this.horaToolStripMenuItem1.Name = "horaToolStripMenuItem1";
            this.horaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.horaToolStripMenuItem1.Tag = "3600000";
            this.horaToolStripMenuItem1.Text = "1 Hour";
            this.horaToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // otroToolStripMenuItem
            // 
            this.otroToolStripMenuItem.Name = "otroToolStripMenuItem";
            this.otroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otroToolStripMenuItem.Text = "Other";
            this.otroToolStripMenuItem.Visible = false;
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.iniciarToolStripMenuItem.Text = "Run";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.detenerToolStripMenuItem.Text = "Stop";
            this.detenerToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuration";
            this.configuraciónToolStripMenuItem.Visible = false;
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // webCamToolStripMenuItem
            // 
            this.webCamToolStripMenuItem.Name = "webCamToolStripMenuItem";
            this.webCamToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.webCamToolStripMenuItem.Text = "Select WebCam";
            // 
            // startupStripMenuItem
            // 
            this.startupStripMenuItem.Name = "startupStripMenuItem";
            this.startupStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.startupStripMenuItem.Text = "Automatic Start";
            this.startupStripMenuItem.Click += new System.EventHandler(this.startupStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.salirToolStripMenuItem.Text = "Exit";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 52);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "LightSensor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Resize += new System.EventHandler(this.ToolStripMenuItem_Click);
            this.msMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon niTray;
        private System.Windows.Forms.ContextMenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem intervaloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segundosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segundosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startupStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

