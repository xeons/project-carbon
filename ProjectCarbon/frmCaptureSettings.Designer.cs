namespace ProjectCarbon
{
    partial class frmCaptureSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCaptureSettings = new System.Windows.Forms.TabPage();
            this.grpStartupOptions = new System.Windows.Forms.GroupBox();
            this.chkStartCaptureAtStartup = new System.Windows.Forms.CheckBox();
            this.chkStartMinimized = new System.Windows.Forms.CheckBox();
            this.chkStartWithWindows = new System.Windows.Forms.CheckBox();
            this.tabUISettings = new System.Windows.Forms.TabPage();
            this.grpOther = new System.Windows.Forms.GroupBox();
            this.chkAutoScrollPacketList = new System.Windows.Forms.CheckBox();
            this.grpVisibleInterfaceElements = new System.Windows.Forms.GroupBox();
            this.chkHeaderInfoVisible = new System.Windows.Forms.CheckBox();
            this.chkPacketListVisible = new System.Windows.Forms.CheckBox();
            this.chkPacketDisplayVisible = new System.Windows.Forms.CheckBox();
            this.chkStatusBarVisible = new System.Windows.Forms.CheckBox();
            this.chkToolbarVisible = new System.Windows.Forms.CheckBox();
            this.grpInterfaceAppearance = new System.Windows.Forms.GroupBox();
            this.btnPacketListFont = new System.Windows.Forms.Button();
            this.picPacketDisplayBackground = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picPacketDisplayFontColor = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picPacketListTextColor = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picPacketListBackgroundColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCaptureSettings.SuspendLayout();
            this.grpStartupOptions.SuspendLayout();
            this.tabUISettings.SuspendLayout();
            this.grpOther.SuspendLayout();
            this.grpVisibleInterfaceElements.SuspendLayout();
            this.grpInterfaceAppearance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPacketDisplayBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacketDisplayFontColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacketListTextColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacketListBackgroundColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(336, 280);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(80, 24);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCaptureSettings);
            this.tabControl1.Controls.Add(this.tabUISettings);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(408, 264);
            this.tabControl1.TabIndex = 5;
            // 
            // tabCaptureSettings
            // 
            this.tabCaptureSettings.Controls.Add(this.grpStartupOptions);
            this.tabCaptureSettings.Location = new System.Drawing.Point(4, 22);
            this.tabCaptureSettings.Name = "tabCaptureSettings";
            this.tabCaptureSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaptureSettings.Size = new System.Drawing.Size(400, 238);
            this.tabCaptureSettings.TabIndex = 0;
            this.tabCaptureSettings.Text = "Capture Settings";
            this.tabCaptureSettings.UseVisualStyleBackColor = true;
            // 
            // grpStartupOptions
            // 
            this.grpStartupOptions.Controls.Add(this.chkStartCaptureAtStartup);
            this.grpStartupOptions.Controls.Add(this.chkStartMinimized);
            this.grpStartupOptions.Controls.Add(this.chkStartWithWindows);
            this.grpStartupOptions.Location = new System.Drawing.Point(8, 8);
            this.grpStartupOptions.Name = "grpStartupOptions";
            this.grpStartupOptions.Size = new System.Drawing.Size(384, 72);
            this.grpStartupOptions.TabIndex = 5;
            this.grpStartupOptions.TabStop = false;
            this.grpStartupOptions.Text = "Startup Options";
            // 
            // chkStartCaptureAtStartup
            // 
            this.chkStartCaptureAtStartup.AutoSize = true;
            this.chkStartCaptureAtStartup.Location = new System.Drawing.Point(8, 48);
            this.chkStartCaptureAtStartup.Name = "chkStartCaptureAtStartup";
            this.chkStartCaptureAtStartup.Size = new System.Drawing.Size(196, 17);
            this.chkStartCaptureAtStartup.TabIndex = 2;
            this.chkStartCaptureAtStartup.Text = "Start capturing packets at start up.";
            this.chkStartCaptureAtStartup.UseVisualStyleBackColor = true;
            // 
            // chkStartMinimized
            // 
            this.chkStartMinimized.AutoSize = true;
            this.chkStartMinimized.Location = new System.Drawing.Point(8, 32);
            this.chkStartMinimized.Name = "chkStartMinimized";
            this.chkStartMinimized.Size = new System.Drawing.Size(168, 17);
            this.chkStartMinimized.TabIndex = 1;
            this.chkStartMinimized.Text = "Start up minimized to the tray";
            this.chkStartMinimized.UseVisualStyleBackColor = true;
            // 
            // chkStartWithWindows
            // 
            this.chkStartWithWindows.AutoSize = true;
            this.chkStartWithWindows.Location = new System.Drawing.Point(8, 16);
            this.chkStartWithWindows.Name = "chkStartWithWindows";
            this.chkStartWithWindows.Size = new System.Drawing.Size(121, 17);
            this.chkStartWithWindows.TabIndex = 0;
            this.chkStartWithWindows.Text = "Start With Windows";
            this.chkStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // tabUISettings
            // 
            this.tabUISettings.Controls.Add(this.grpOther);
            this.tabUISettings.Controls.Add(this.grpVisibleInterfaceElements);
            this.tabUISettings.Controls.Add(this.grpInterfaceAppearance);
            this.tabUISettings.Location = new System.Drawing.Point(4, 22);
            this.tabUISettings.Name = "tabUISettings";
            this.tabUISettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabUISettings.Size = new System.Drawing.Size(400, 238);
            this.tabUISettings.TabIndex = 1;
            this.tabUISettings.Text = "UI Settings";
            this.tabUISettings.UseVisualStyleBackColor = true;
            // 
            // grpOther
            // 
            this.grpOther.Controls.Add(this.chkAutoScrollPacketList);
            this.grpOther.Location = new System.Drawing.Point(8, 184);
            this.grpOther.Name = "grpOther";
            this.grpOther.Size = new System.Drawing.Size(384, 40);
            this.grpOther.TabIndex = 16;
            this.grpOther.TabStop = false;
            this.grpOther.Text = "Other";
            // 
            // chkAutoScrollPacketList
            // 
            this.chkAutoScrollPacketList.AutoSize = true;
            this.chkAutoScrollPacketList.Location = new System.Drawing.Point(8, 17);
            this.chkAutoScrollPacketList.Name = "chkAutoScrollPacketList";
            this.chkAutoScrollPacketList.Size = new System.Drawing.Size(131, 17);
            this.chkAutoScrollPacketList.TabIndex = 0;
            this.chkAutoScrollPacketList.Text = "Auto-scroll Packet List";
            this.chkAutoScrollPacketList.UseVisualStyleBackColor = true;
            // 
            // grpVisibleInterfaceElements
            // 
            this.grpVisibleInterfaceElements.Controls.Add(this.chkHeaderInfoVisible);
            this.grpVisibleInterfaceElements.Controls.Add(this.chkPacketListVisible);
            this.grpVisibleInterfaceElements.Controls.Add(this.chkPacketDisplayVisible);
            this.grpVisibleInterfaceElements.Controls.Add(this.chkStatusBarVisible);
            this.grpVisibleInterfaceElements.Controls.Add(this.chkToolbarVisible);
            this.grpVisibleInterfaceElements.Location = new System.Drawing.Point(8, 8);
            this.grpVisibleInterfaceElements.Name = "grpVisibleInterfaceElements";
            this.grpVisibleInterfaceElements.Size = new System.Drawing.Size(120, 168);
            this.grpVisibleInterfaceElements.TabIndex = 15;
            this.grpVisibleInterfaceElements.TabStop = false;
            this.grpVisibleInterfaceElements.Text = "Visible Elements";
            // 
            // chkHeaderInfoVisible
            // 
            this.chkHeaderInfoVisible.AutoSize = true;
            this.chkHeaderInfoVisible.Location = new System.Drawing.Point(16, 120);
            this.chkHeaderInfoVisible.Name = "chkHeaderInfoVisible";
            this.chkHeaderInfoVisible.Size = new System.Drawing.Size(84, 17);
            this.chkHeaderInfoVisible.TabIndex = 9;
            this.chkHeaderInfoVisible.Text = "Header Info";
            this.chkHeaderInfoVisible.UseVisualStyleBackColor = true;
            // 
            // chkPacketListVisible
            // 
            this.chkPacketListVisible.AutoSize = true;
            this.chkPacketListVisible.Location = new System.Drawing.Point(16, 72);
            this.chkPacketListVisible.Name = "chkPacketListVisible";
            this.chkPacketListVisible.Size = new System.Drawing.Size(77, 17);
            this.chkPacketListVisible.TabIndex = 8;
            this.chkPacketListVisible.Text = "Packet List";
            this.chkPacketListVisible.UseVisualStyleBackColor = true;
            // 
            // chkPacketDisplayVisible
            // 
            this.chkPacketDisplayVisible.AutoSize = true;
            this.chkPacketDisplayVisible.Location = new System.Drawing.Point(16, 96);
            this.chkPacketDisplayVisible.Name = "chkPacketDisplayVisible";
            this.chkPacketDisplayVisible.Size = new System.Drawing.Size(95, 17);
            this.chkPacketDisplayVisible.TabIndex = 7;
            this.chkPacketDisplayVisible.Text = "Packet Display";
            this.chkPacketDisplayVisible.UseVisualStyleBackColor = true;
            // 
            // chkStatusBarVisible
            // 
            this.chkStatusBarVisible.AutoSize = true;
            this.chkStatusBarVisible.Location = new System.Drawing.Point(16, 48);
            this.chkStatusBarVisible.Name = "chkStatusBarVisible";
            this.chkStatusBarVisible.Size = new System.Drawing.Size(76, 17);
            this.chkStatusBarVisible.TabIndex = 6;
            this.chkStatusBarVisible.Text = "Status Bar";
            this.chkStatusBarVisible.UseVisualStyleBackColor = true;
            // 
            // chkToolbarVisible
            // 
            this.chkToolbarVisible.AutoSize = true;
            this.chkToolbarVisible.Location = new System.Drawing.Point(16, 24);
            this.chkToolbarVisible.Name = "chkToolbarVisible";
            this.chkToolbarVisible.Size = new System.Drawing.Size(62, 17);
            this.chkToolbarVisible.TabIndex = 5;
            this.chkToolbarVisible.Text = "Toolbar";
            this.chkToolbarVisible.UseVisualStyleBackColor = true;
            // 
            // grpInterfaceAppearance
            // 
            this.grpInterfaceAppearance.Controls.Add(this.btnPacketListFont);
            this.grpInterfaceAppearance.Controls.Add(this.picPacketDisplayBackground);
            this.grpInterfaceAppearance.Controls.Add(this.label4);
            this.grpInterfaceAppearance.Controls.Add(this.picPacketDisplayFontColor);
            this.grpInterfaceAppearance.Controls.Add(this.label3);
            this.grpInterfaceAppearance.Controls.Add(this.picPacketListTextColor);
            this.grpInterfaceAppearance.Controls.Add(this.label2);
            this.grpInterfaceAppearance.Controls.Add(this.picPacketListBackgroundColor);
            this.grpInterfaceAppearance.Controls.Add(this.label1);
            this.grpInterfaceAppearance.Location = new System.Drawing.Point(136, 8);
            this.grpInterfaceAppearance.Name = "grpInterfaceAppearance";
            this.grpInterfaceAppearance.Size = new System.Drawing.Size(256, 168);
            this.grpInterfaceAppearance.TabIndex = 14;
            this.grpInterfaceAppearance.TabStop = false;
            this.grpInterfaceAppearance.Text = "Interface Appearance";
            // 
            // btnPacketListFont
            // 
            this.btnPacketListFont.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacketListFont.Location = new System.Drawing.Point(16, 96);
            this.btnPacketListFont.Name = "btnPacketListFont";
            this.btnPacketListFont.Size = new System.Drawing.Size(224, 32);
            this.btnPacketListFont.TabIndex = 22;
            this.btnPacketListFont.Text = "Packet Display Font";
            this.btnPacketListFont.UseVisualStyleBackColor = true;
            this.btnPacketListFont.Click += new System.EventHandler(this.btnPacketListFont_Click);
            // 
            // picPacketDisplayBackground
            // 
            this.picPacketDisplayBackground.BackColor = System.Drawing.Color.Red;
            this.picPacketDisplayBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPacketDisplayBackground.Location = new System.Drawing.Point(16, 136);
            this.picPacketDisplayBackground.Name = "picPacketDisplayBackground";
            this.picPacketDisplayBackground.Size = new System.Drawing.Size(24, 16);
            this.picPacketDisplayBackground.TabIndex = 21;
            this.picPacketDisplayBackground.TabStop = false;
            this.picPacketDisplayBackground.Click += new System.EventHandler(this.picPacketDisplayBackground_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Packet Display Background";
            // 
            // picPacketDisplayFontColor
            // 
            this.picPacketDisplayFontColor.BackColor = System.Drawing.Color.Red;
            this.picPacketDisplayFontColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPacketDisplayFontColor.Location = new System.Drawing.Point(16, 72);
            this.picPacketDisplayFontColor.Name = "picPacketDisplayFontColor";
            this.picPacketDisplayFontColor.Size = new System.Drawing.Size(24, 16);
            this.picPacketDisplayFontColor.TabIndex = 19;
            this.picPacketDisplayFontColor.TabStop = false;
            this.picPacketDisplayFontColor.Click += new System.EventHandler(this.picPacketDisplayFontColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Packet Display Font Color";
            // 
            // picPacketListTextColor
            // 
            this.picPacketListTextColor.BackColor = System.Drawing.Color.Red;
            this.picPacketListTextColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPacketListTextColor.Location = new System.Drawing.Point(16, 48);
            this.picPacketListTextColor.Name = "picPacketListTextColor";
            this.picPacketListTextColor.Size = new System.Drawing.Size(24, 16);
            this.picPacketListTextColor.TabIndex = 17;
            this.picPacketListTextColor.TabStop = false;
            this.picPacketListTextColor.Click += new System.EventHandler(this.picPacketListTextColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Packet List Text Color";
            // 
            // picPacketListBackgroundColor
            // 
            this.picPacketListBackgroundColor.BackColor = System.Drawing.Color.Red;
            this.picPacketListBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPacketListBackgroundColor.Location = new System.Drawing.Point(16, 24);
            this.picPacketListBackgroundColor.Name = "picPacketListBackgroundColor";
            this.picPacketListBackgroundColor.Size = new System.Drawing.Size(24, 16);
            this.picPacketListBackgroundColor.TabIndex = 15;
            this.picPacketListBackgroundColor.TabStop = false;
            this.picPacketListBackgroundColor.Click += new System.EventHandler(this.picPacketListBackgroundColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Packet List Background Color";
            // 
            // frmCaptureSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 311);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaptureSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Settings";
            this.Load += new System.EventHandler(this.CaptureSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCaptureSettings.ResumeLayout(false);
            this.grpStartupOptions.ResumeLayout(false);
            this.grpStartupOptions.PerformLayout();
            this.tabUISettings.ResumeLayout(false);
            this.grpOther.ResumeLayout(false);
            this.grpOther.PerformLayout();
            this.grpVisibleInterfaceElements.ResumeLayout(false);
            this.grpVisibleInterfaceElements.PerformLayout();
            this.grpInterfaceAppearance.ResumeLayout(false);
            this.grpInterfaceAppearance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPacketDisplayBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacketDisplayFontColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacketListTextColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacketListBackgroundColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCaptureSettings;
        private System.Windows.Forms.GroupBox grpStartupOptions;
        private System.Windows.Forms.CheckBox chkStartCaptureAtStartup;
        private System.Windows.Forms.CheckBox chkStartMinimized;
        private System.Windows.Forms.CheckBox chkStartWithWindows;
        private System.Windows.Forms.TabPage tabUISettings;
        private System.Windows.Forms.GroupBox grpOther;
        private System.Windows.Forms.CheckBox chkAutoScrollPacketList;
        private System.Windows.Forms.GroupBox grpVisibleInterfaceElements;
        private System.Windows.Forms.CheckBox chkPacketListVisible;
        private System.Windows.Forms.CheckBox chkPacketDisplayVisible;
        private System.Windows.Forms.CheckBox chkStatusBarVisible;
        private System.Windows.Forms.CheckBox chkToolbarVisible;
        private System.Windows.Forms.GroupBox grpInterfaceAppearance;
        private System.Windows.Forms.Button btnPacketListFont;
        private System.Windows.Forms.PictureBox picPacketDisplayBackground;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picPacketDisplayFontColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picPacketListTextColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPacketListBackgroundColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkHeaderInfoVisible;
    }
}