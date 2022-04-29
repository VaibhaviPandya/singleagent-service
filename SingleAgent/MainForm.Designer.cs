using System.Windows.Forms;

namespace SingleAgent
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pbDbytes = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbSysmon = new System.Windows.Forms.PictureBox();
            this.pbDefender = new System.Windows.Forms.PictureBox();
            this.pbDejavu = new System.Windows.Forms.PictureBox();
            this.pbWazuh = new System.Windows.Forms.PictureBox();
            this.lblDeceptiveBytes = new System.Windows.Forms.Label();
            this.lblWindowsDefender = new System.Windows.Forms.Label();
            this.lblWazuh = new System.Windows.Forms.Label();
            this.lblMicrosoftSysmon = new System.Windows.Forms.Label();
            this.lblDejavu = new System.Windows.Forms.Label();
            this.pbDeceptiveLogo = new System.Windows.Forms.PictureBox();
            this.pbWindowsLogo = new System.Windows.Forms.PictureBox();
            this.pbWazuhLogo = new System.Windows.Forms.PictureBox();
            this.pbSysmonLogo = new System.Windows.Forms.PictureBox();
            this.pbDejavuLogo = new System.Windows.Forms.PictureBox();
            this.tmAvCheck = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbDbytes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSysmon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDejavu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWazuh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeceptiveLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindowsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWazuhLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSysmonLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDejavuLogo)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Invinsense 3.0";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.ShowClick);
            // 
            // pbDbytes
            // 
            this.pbDbytes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDbytes.Image = global::SingleAgent.Properties.Resources.gray;
            this.pbDbytes.InitialImage = null;
            this.pbDbytes.Location = new System.Drawing.Point(288, 16);
            this.pbDbytes.Name = "pbDbytes";
            this.pbDbytes.Size = new System.Drawing.Size(20, 20);
            this.pbDbytes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDbytes.TabIndex = 0;
            this.pbDbytes.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SingleAgent.Properties.Resources.invinsence_logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pbSysmon
            // 
            this.pbSysmon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSysmon.Image = global::SingleAgent.Properties.Resources.gray;
            this.pbSysmon.InitialImage = null;
            this.pbSysmon.Location = new System.Drawing.Point(288, 172);
            this.pbSysmon.Name = "pbSysmon";
            this.pbSysmon.Size = new System.Drawing.Size(20, 20);
            this.pbSysmon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSysmon.TabIndex = 3;
            this.pbSysmon.TabStop = false;
            // 
            // pbDefender
            // 
            this.pbDefender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDefender.Image = global::SingleAgent.Properties.Resources.gray;
            this.pbDefender.InitialImage = null;
            this.pbDefender.Location = new System.Drawing.Point(288, 68);
            this.pbDefender.Name = "pbDefender";
            this.pbDefender.Size = new System.Drawing.Size(20, 20);
            this.pbDefender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDefender.TabIndex = 4;
            this.pbDefender.TabStop = false;
            // 
            // pbDejavu
            // 
            this.pbDejavu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDejavu.Image = global::SingleAgent.Properties.Resources.gray;
            this.pbDejavu.InitialImage = null;
            this.pbDejavu.Location = new System.Drawing.Point(288, 224);
            this.pbDejavu.Name = "pbDejavu";
            this.pbDejavu.Size = new System.Drawing.Size(20, 20);
            this.pbDejavu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDejavu.TabIndex = 5;
            this.pbDejavu.TabStop = false;
            // 
            // pbWazuh
            // 
            this.pbWazuh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbWazuh.Image = global::SingleAgent.Properties.Resources.gray;
            this.pbWazuh.InitialImage = null;
            this.pbWazuh.Location = new System.Drawing.Point(288, 120);
            this.pbWazuh.Name = "pbWazuh";
            this.pbWazuh.Size = new System.Drawing.Size(20, 20);
            this.pbWazuh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWazuh.TabIndex = 6;
            this.pbWazuh.TabStop = false;
            // 
            // lblDeceptiveBytes
            // 
            this.lblDeceptiveBytes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDeceptiveBytes.AutoSize = true;
            this.lblDeceptiveBytes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDeceptiveBytes.Location = new System.Drawing.Point(58, 15);
            this.lblDeceptiveBytes.Name = "lblDeceptiveBytes";
            this.lblDeceptiveBytes.Size = new System.Drawing.Size(132, 21);
            this.lblDeceptiveBytes.TabIndex = 7;
            this.lblDeceptiveBytes.Text = "Deceptive Bytes";
            // 
            // lblWindowsDefender
            // 
            this.lblWindowsDefender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWindowsDefender.AutoSize = true;
            this.lblWindowsDefender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWindowsDefender.Location = new System.Drawing.Point(58, 67);
            this.lblWindowsDefender.Name = "lblWindowsDefender";
            this.lblWindowsDefender.Size = new System.Drawing.Size(156, 21);
            this.lblWindowsDefender.TabIndex = 8;
            this.lblWindowsDefender.Text = "Windows Defender";
            // 
            // lblWazuh
            // 
            this.lblWazuh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWazuh.AutoSize = true;
            this.lblWazuh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWazuh.Location = new System.Drawing.Point(58, 119);
            this.lblWazuh.Name = "lblWazuh";
            this.lblWazuh.Size = new System.Drawing.Size(62, 21);
            this.lblWazuh.TabIndex = 9;
            this.lblWazuh.Text = "Wazuh";
            // 
            // lblMicrosoftSysmon
            // 
            this.lblMicrosoftSysmon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMicrosoftSysmon.AutoSize = true;
            this.lblMicrosoftSysmon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMicrosoftSysmon.Location = new System.Drawing.Point(58, 171);
            this.lblMicrosoftSysmon.Name = "lblMicrosoftSysmon";
            this.lblMicrosoftSysmon.Size = new System.Drawing.Size(147, 21);
            this.lblMicrosoftSysmon.TabIndex = 10;
            this.lblMicrosoftSysmon.Text = "Microsoft Sysmon";
            // 
            // lblDejavu
            // 
            this.lblDejavu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDejavu.AutoSize = true;
            this.lblDejavu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDejavu.Location = new System.Drawing.Point(58, 213);
            this.lblDejavu.Name = "lblDejavu";
            this.lblDejavu.Size = new System.Drawing.Size(153, 42);
            this.lblDejavu.TabIndex = 11;
            this.lblDejavu.Text = "Lateral Movement Protection";
           // this.lblDejavu.Click += new System.EventHandler(this.lblDejavu_Click);
            // 
            // pbDeceptiveLogo
            // 
            this.pbDeceptiveLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDeceptiveLogo.Image = global::SingleAgent.Properties.Resources.deceptive;
            this.pbDeceptiveLogo.InitialImage = null;
            this.pbDeceptiveLogo.Location = new System.Drawing.Point(8, 6);
            this.pbDeceptiveLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDeceptiveLogo.Name = "pbDeceptiveLogo";
            this.pbDeceptiveLogo.Size = new System.Drawing.Size(38, 40);
            this.pbDeceptiveLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeceptiveLogo.TabIndex = 12;
            this.pbDeceptiveLogo.TabStop = false;
            // 
            // pbWindowsLogo
            // 
            this.pbWindowsLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbWindowsLogo.Image = global::SingleAgent.Properties.Resources.defender;
            this.pbWindowsLogo.Location = new System.Drawing.Point(10, 60);
            this.pbWindowsLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbWindowsLogo.Name = "pbWindowsLogo";
            this.pbWindowsLogo.Size = new System.Drawing.Size(34, 35);
            this.pbWindowsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWindowsLogo.TabIndex = 13;
            this.pbWindowsLogo.TabStop = false;
            // 
            // pbWazuhLogo
            // 
            this.pbWazuhLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbWazuhLogo.Image = global::SingleAgent.Properties.Resources.wazuh;
            this.pbWazuhLogo.Location = new System.Drawing.Point(10, 112);
            this.pbWazuhLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbWazuhLogo.Name = "pbWazuhLogo";
            this.pbWazuhLogo.Size = new System.Drawing.Size(34, 35);
            this.pbWazuhLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWazuhLogo.TabIndex = 14;
            this.pbWazuhLogo.TabStop = false;
            // 
            // pbSysmonLogo
            // 
            this.pbSysmonLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSysmonLogo.Image = global::SingleAgent.Properties.Resources.microsoft;
            this.pbSysmonLogo.Location = new System.Drawing.Point(10, 164);
            this.pbSysmonLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSysmonLogo.Name = "pbSysmonLogo";
            this.pbSysmonLogo.Size = new System.Drawing.Size(34, 35);
            this.pbSysmonLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSysmonLogo.TabIndex = 15;
            this.pbSysmonLogo.TabStop = false;
            // 
            // pbDejavuLogo
            // 
            this.pbDejavuLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDejavuLogo.Image = global::SingleAgent.Properties.Resources.letral_threat_protection;
            this.pbDejavuLogo.Location = new System.Drawing.Point(10, 216);
            this.pbDejavuLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDejavuLogo.Name = "pbDejavuLogo";
            this.pbDejavuLogo.Size = new System.Drawing.Size(34, 35);
            this.pbDejavuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDejavuLogo.TabIndex = 16;
            this.pbDejavuLogo.TabStop = false;
            // 
            // tmAvCheck
            // 
            this.tmAvCheck.Enabled = true;
            this.tmAvCheck.Interval = 5000;
            this.tmAvCheck.Tick += new System.EventHandler(this.AvCheckTick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(256, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 62);
            this.label1.TabIndex = 17;
            this.label1.Text = "3.0";
          //  this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpMain.Controls.Add(this.pbDejavuLogo, 0, 4);
            this.tlpMain.Controls.Add(this.pbSysmonLogo, 0, 3);
            this.tlpMain.Controls.Add(this.lblDejavu, 1, 4);
            this.tlpMain.Controls.Add(this.pbDeceptiveLogo, 0, 0);
            this.tlpMain.Controls.Add(this.lblMicrosoftSysmon, 1, 3);
            this.tlpMain.Controls.Add(this.pbWindowsLogo, 0, 1);
            this.tlpMain.Controls.Add(this.lblWazuh, 1, 2);
            this.tlpMain.Controls.Add(this.pbWazuhLogo, 0, 2);
            this.tlpMain.Controls.Add(this.lblWindowsDefender, 1, 1);
            this.tlpMain.Controls.Add(this.pbDbytes, 2, 0);
            this.tlpMain.Controls.Add(this.lblDeceptiveBytes, 1, 0);
            this.tlpMain.Controls.Add(this.pbDefender, 2, 1);
            this.tlpMain.Controls.Add(this.pbDejavu, 2, 4);
            this.tlpMain.Controls.Add(this.pbWazuh, 2, 2);
            this.tlpMain.Controls.Add(this.pbSysmon, 2, 3);
            this.tlpMain.Location = new System.Drawing.Point(23, 70);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.Size = new System.Drawing.Size(320, 260);
            this.tlpMain.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 350);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invinsense 3.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
          //  this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDbytes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSysmon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDejavu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWazuh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeceptiveLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindowsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWazuhLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSysmonLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDejavuLogo)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotifyIcon notifyIcon;
        private PictureBox pbDbytes;
        private PictureBox pictureBox1;
        private PictureBox pbSysmon;
        private PictureBox pbDefender;
        private PictureBox pbDejavu;
        private PictureBox pbWazuh;
        private Label lblDeceptiveBytes;
        private Label lblWindowsDefender;
        private Label lblWazuh;
        private Label lblMicrosoftSysmon;
        private Label lblDejavu;
        private PictureBox pbDeceptiveLogo;
        private PictureBox pbWindowsLogo;
        private PictureBox pbWazuhLogo;
        private PictureBox pbSysmonLogo;
        private PictureBox pbDejavuLogo;
        private System.Windows.Forms.Timer tmAvCheck;
        private Label label1;
        private TableLayoutPanel tlpMain;
    }
}