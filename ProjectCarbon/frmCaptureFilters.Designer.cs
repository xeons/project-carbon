namespace ProjectCarbon
{
    partial class frmCaptureFilters
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
            this.tcCaptureFilters = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpFilterType = new System.Windows.Forms.GroupBox();
            this.rbExclusiveProtocolFilter = new System.Windows.Forms.RadioButton();
            this.rbInclusiveProtocolFilter = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.clbProtocolFilters = new System.Windows.Forms.CheckedListBox();
            this.tpPortFilters = new System.Windows.Forms.TabPage();
            this.grpAddCustomPort = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnAddCustomPort = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbExclusivePortFilter = new System.Windows.Forms.RadioButton();
            this.rbInclusivePortFilter = new System.Windows.Forms.RadioButton();
            this.btnRemovePort = new System.Windows.Forms.Button();
            this.btnAddPort = new System.Windows.Forms.Button();
            this.lblCommonPorts = new System.Windows.Forms.Label();
            this.lstCommonPorts = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFilteredPorts = new System.Windows.Forms.Label();
            this.lstFilteredPorts = new System.Windows.Forms.ListBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdApply = new System.Windows.Forms.Button();
            this.tcCaptureFilters.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpFilterType.SuspendLayout();
            this.tpPortFilters.SuspendLayout();
            this.grpAddCustomPort.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCaptureFilters
            // 
            this.tcCaptureFilters.Controls.Add(this.tabPage1);
            this.tcCaptureFilters.Controls.Add(this.tpPortFilters);
            this.tcCaptureFilters.Location = new System.Drawing.Point(8, 8);
            this.tcCaptureFilters.Name = "tcCaptureFilters";
            this.tcCaptureFilters.SelectedIndex = 0;
            this.tcCaptureFilters.Size = new System.Drawing.Size(400, 296);
            this.tcCaptureFilters.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpFilterType);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.clbProtocolFilters);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Protocol";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpFilterType
            // 
            this.grpFilterType.Controls.Add(this.rbExclusiveProtocolFilter);
            this.grpFilterType.Controls.Add(this.rbInclusiveProtocolFilter);
            this.grpFilterType.Location = new System.Drawing.Point(120, 8);
            this.grpFilterType.Name = "grpFilterType";
            this.grpFilterType.Size = new System.Drawing.Size(264, 64);
            this.grpFilterType.TabIndex = 4;
            this.grpFilterType.TabStop = false;
            this.grpFilterType.Text = "Filter Type";
            // 
            // rbExclusiveProtocolFilter
            // 
            this.rbExclusiveProtocolFilter.AutoSize = true;
            this.rbExclusiveProtocolFilter.Location = new System.Drawing.Point(8, 40);
            this.rbExclusiveProtocolFilter.Name = "rbExclusiveProtocolFilter";
            this.rbExclusiveProtocolFilter.Size = new System.Drawing.Size(69, 17);
            this.rbExclusiveProtocolFilter.TabIndex = 4;
            this.rbExclusiveProtocolFilter.Text = "Exclusive";
            this.rbExclusiveProtocolFilter.UseVisualStyleBackColor = true;
            // 
            // rbInclusiveProtocolFilter
            // 
            this.rbInclusiveProtocolFilter.AutoSize = true;
            this.rbInclusiveProtocolFilter.Checked = true;
            this.rbInclusiveProtocolFilter.Location = new System.Drawing.Point(8, 16);
            this.rbInclusiveProtocolFilter.Name = "rbInclusiveProtocolFilter";
            this.rbInclusiveProtocolFilter.Size = new System.Drawing.Size(67, 17);
            this.rbInclusiveProtocolFilter.TabIndex = 3;
            this.rbInclusiveProtocolFilter.TabStop = true;
            this.rbInclusiveProtocolFilter.Text = "Inclusive";
            this.rbInclusiveProtocolFilter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Each IP header contains a protocol id, this will let you filter out or in packets" +
                " using this identifier.";
            // 
            // clbProtocolFilters
            // 
            this.clbProtocolFilters.FormattingEnabled = true;
            this.clbProtocolFilters.IntegralHeight = false;
            this.clbProtocolFilters.Items.AddRange(new object[] {
            "ICMP",
            "IGMP",
            "GGP",
            "IP",
            "ST",
            "TCP",
            "CBT",
            "EGP",
            "IGP",
            "PUP",
            "UDP",
            "IDP",
            "ND"});
            this.clbProtocolFilters.Location = new System.Drawing.Point(8, 8);
            this.clbProtocolFilters.Name = "clbProtocolFilters";
            this.clbProtocolFilters.Size = new System.Drawing.Size(104, 208);
            this.clbProtocolFilters.TabIndex = 0;
            // 
            // tpPortFilters
            // 
            this.tpPortFilters.Controls.Add(this.grpAddCustomPort);
            this.tpPortFilters.Controls.Add(this.btnRemoveAll);
            this.tpPortFilters.Controls.Add(this.groupBox1);
            this.tpPortFilters.Controls.Add(this.btnRemovePort);
            this.tpPortFilters.Controls.Add(this.btnAddPort);
            this.tpPortFilters.Controls.Add(this.lblCommonPorts);
            this.tpPortFilters.Controls.Add(this.lstCommonPorts);
            this.tpPortFilters.Controls.Add(this.label3);
            this.tpPortFilters.Controls.Add(this.lblFilteredPorts);
            this.tpPortFilters.Controls.Add(this.lstFilteredPorts);
            this.tpPortFilters.Location = new System.Drawing.Point(4, 22);
            this.tpPortFilters.Name = "tpPortFilters";
            this.tpPortFilters.Size = new System.Drawing.Size(392, 270);
            this.tpPortFilters.TabIndex = 2;
            this.tpPortFilters.Text = "Ports";
            this.tpPortFilters.UseVisualStyleBackColor = true;
            // 
            // grpAddCustomPort
            // 
            this.grpAddCustomPort.Controls.Add(this.txtPort);
            this.grpAddCustomPort.Controls.Add(this.lblPort);
            this.grpAddCustomPort.Controls.Add(this.btnAddCustomPort);
            this.grpAddCustomPort.Location = new System.Drawing.Point(128, 120);
            this.grpAddCustomPort.Name = "grpAddCustomPort";
            this.grpAddCustomPort.Size = new System.Drawing.Size(112, 96);
            this.grpAddCustomPort.TabIndex = 14;
            this.grpAddCustomPort.TabStop = false;
            this.grpAddCustomPort.Text = "Custom Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(8, 64);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(96, 21);
            this.txtPort.TabIndex = 17;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(8, 48);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(31, 13);
            this.lblPort.TabIndex = 16;
            this.lblPort.Text = "Port:";
            // 
            // btnAddCustomPort
            // 
            this.btnAddCustomPort.Location = new System.Drawing.Point(8, 16);
            this.btnAddCustomPort.Name = "btnAddCustomPort";
            this.btnAddCustomPort.Size = new System.Drawing.Size(96, 23);
            this.btnAddCustomPort.TabIndex = 15;
            this.btnAddCustomPort.Text = "<< Add Custom";
            this.btnAddCustomPort.UseVisualStyleBackColor = true;
            this.btnAddCustomPort.Click += new System.EventHandler(this.btnAddCustomPort_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(128, 88);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(112, 24);
            this.btnRemoveAll.TabIndex = 13;
            this.btnRemoveAll.Text = "Remove All >>";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbExclusivePortFilter);
            this.groupBox1.Controls.Add(this.rbInclusivePortFilter);
            this.groupBox1.Location = new System.Drawing.Point(8, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 40);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Type";
            // 
            // rbExclusivePortFilter
            // 
            this.rbExclusivePortFilter.AutoSize = true;
            this.rbExclusivePortFilter.Location = new System.Drawing.Point(80, 16);
            this.rbExclusivePortFilter.Name = "rbExclusivePortFilter";
            this.rbExclusivePortFilter.Size = new System.Drawing.Size(69, 17);
            this.rbExclusivePortFilter.TabIndex = 4;
            this.rbExclusivePortFilter.Text = "Exclusive";
            this.rbExclusivePortFilter.UseVisualStyleBackColor = true;
            // 
            // rbInclusivePortFilter
            // 
            this.rbInclusivePortFilter.AutoSize = true;
            this.rbInclusivePortFilter.Checked = true;
            this.rbInclusivePortFilter.Location = new System.Drawing.Point(8, 16);
            this.rbInclusivePortFilter.Name = "rbInclusivePortFilter";
            this.rbInclusivePortFilter.Size = new System.Drawing.Size(67, 17);
            this.rbInclusivePortFilter.TabIndex = 3;
            this.rbInclusivePortFilter.TabStop = true;
            this.rbInclusivePortFilter.Text = "Inclusive";
            this.rbInclusivePortFilter.UseVisualStyleBackColor = true;
            // 
            // btnRemovePort
            // 
            this.btnRemovePort.Location = new System.Drawing.Point(128, 56);
            this.btnRemovePort.Name = "btnRemovePort";
            this.btnRemovePort.Size = new System.Drawing.Size(112, 23);
            this.btnRemovePort.TabIndex = 8;
            this.btnRemovePort.Text = "Remove >>";
            this.btnRemovePort.UseVisualStyleBackColor = true;
            this.btnRemovePort.Click += new System.EventHandler(this.btnRemovePort_Click);
            // 
            // btnAddPort
            // 
            this.btnAddPort.Location = new System.Drawing.Point(128, 24);
            this.btnAddPort.Name = "btnAddPort";
            this.btnAddPort.Size = new System.Drawing.Size(112, 23);
            this.btnAddPort.TabIndex = 7;
            this.btnAddPort.Text = "<< Add";
            this.btnAddPort.UseVisualStyleBackColor = true;
            this.btnAddPort.Click += new System.EventHandler(this.btnAddPort_Click);
            // 
            // lblCommonPorts
            // 
            this.lblCommonPorts.AutoSize = true;
            this.lblCommonPorts.Location = new System.Drawing.Point(248, 8);
            this.lblCommonPorts.Name = "lblCommonPorts";
            this.lblCommonPorts.Size = new System.Drawing.Size(80, 13);
            this.lblCommonPorts.TabIndex = 6;
            this.lblCommonPorts.Text = "Common Ports:";
            // 
            // lstCommonPorts
            // 
            this.lstCommonPorts.FormattingEnabled = true;
            this.lstCommonPorts.IntegralHeight = false;
            this.lstCommonPorts.Items.AddRange(new object[] {
            "80",
            "21",
            "23",
            "25",
            "53",
            "109",
            "110",
            "113",
            "143",
            "194",
            "443",
            "540",
            "758",
            "774",
            "2004",
            "4000",
            "5050",
            "5180",
            "5190",
            "6000",
            "6667"});
            this.lstCommonPorts.Location = new System.Drawing.Point(248, 24);
            this.lstCommonPorts.Name = "lstCommonPorts";
            this.lstCommonPorts.Size = new System.Drawing.Size(136, 192);
            this.lstCommonPorts.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(176, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Note: Filtered ports apply to packet source port OR destination port.";
            // 
            // lblFilteredPorts
            // 
            this.lblFilteredPorts.AutoSize = true;
            this.lblFilteredPorts.Location = new System.Drawing.Point(8, 8);
            this.lblFilteredPorts.Name = "lblFilteredPorts";
            this.lblFilteredPorts.Size = new System.Drawing.Size(75, 13);
            this.lblFilteredPorts.TabIndex = 1;
            this.lblFilteredPorts.Text = "Filtered Ports:";
            // 
            // lstFilteredPorts
            // 
            this.lstFilteredPorts.FormattingEnabled = true;
            this.lstFilteredPorts.IntegralHeight = false;
            this.lstFilteredPorts.Location = new System.Drawing.Point(8, 24);
            this.lstFilteredPorts.Name = "lstFilteredPorts";
            this.lstFilteredPorts.Size = new System.Drawing.Size(112, 192);
            this.lstFilteredPorts.TabIndex = 0;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(240, 312);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(80, 23);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdApply
            // 
            this.cmdApply.Location = new System.Drawing.Point(328, 312);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(80, 23);
            this.cmdApply.TabIndex = 3;
            this.cmdApply.Text = "Apply";
            this.cmdApply.UseVisualStyleBackColor = true;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // frmCaptureFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 344);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdApply);
            this.Controls.Add(this.tcCaptureFilters);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaptureFilters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Filters";
            this.Load += new System.EventHandler(this.CaptureFilters_Load);
            this.tcCaptureFilters.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpFilterType.ResumeLayout(false);
            this.grpFilterType.PerformLayout();
            this.tpPortFilters.ResumeLayout(false);
            this.tpPortFilters.PerformLayout();
            this.grpAddCustomPort.ResumeLayout(false);
            this.grpAddCustomPort.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCaptureFilters;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpPortFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbProtocolFilters;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdApply;
        private System.Windows.Forms.Label lblCommonPorts;
        private System.Windows.Forms.ListBox lstCommonPorts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFilteredPorts;
        private System.Windows.Forms.ListBox lstFilteredPorts;
        private System.Windows.Forms.Button btnRemovePort;
        private System.Windows.Forms.Button btnAddPort;
        private System.Windows.Forms.GroupBox grpFilterType;
        private System.Windows.Forms.RadioButton rbExclusiveProtocolFilter;
        private System.Windows.Forms.RadioButton rbInclusiveProtocolFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbExclusivePortFilter;
        private System.Windows.Forms.RadioButton rbInclusivePortFilter;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.GroupBox grpAddCustomPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnAddCustomPort;
    }
}