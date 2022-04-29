using SingleAgent.Monitor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Windows.Forms;

namespace SingleAgent
{
    public partial class MainForm : Form
    {
        private readonly Image NotFoundImage = Properties.Resources.gray;
        private readonly Image ErrorImage = Properties.Resources.red;
        private readonly Image WarnImage = Properties.Resources.yellow;
        private readonly Image OkImage = Properties.Resources.green;

        private readonly ExtendedServiceController Dbytes = new ExtendedServiceController("DBytesService");
        private readonly ExtendedServiceController wazuh = new ExtendedServiceController("WazuhSvc");
        private readonly ExtendedServiceController Sysmon = new ExtendedServiceController("Sysmon64");
        private readonly ExtendedServiceController Dejavu = new ExtendedServiceController("Spooler");

        private readonly Dictionary<string, bool> _healthStatus = new Dictionary<string, bool>
        {
            {"Deceptive Bytes", true },
            {"Windows Defender", true },
            {"Wazuh", true },
            {"Microsoft Sysmon", true },
            {"Lateral Movement Protection", true }
        };

        public MainForm()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            wazuh.StatusChanged += (object sender, ServiceStatusEventArgs e) => UpdateStatus("Wazuh", pbWazuh, e.Status);
            Dbytes.StatusChanged += (object sender, ServiceStatusEventArgs e) => UpdateStatus("Deceptive Bytes", pbDbytes, e.Status);
            Sysmon.StatusChanged += (object sender, ServiceStatusEventArgs e) => UpdateStatus("Microsoft Sysmon", pbSysmon, e.Status);
            Dejavu.StatusChanged += (object sender, ServiceStatusEventArgs e) => UpdateStatus("Lateral Movement Protection", pbDejavu, e.Status);

            UpdateStatus("Wazuh", pbWazuh, wazuh.Status, false);
            UpdateStatus("Deceptive Bytes", pbDbytes, Dbytes.Status, false);
            UpdateStatus("Microsoft Sysmon", pbSysmon, Sysmon.Status, false);
            UpdateStatus("Dejavu", pbDejavu, Dejavu.Status, false);

            AvCheckTick(tmAvCheck, new EventArgs());

            MouseDownFilter mouseFilter = new MouseDownFilter(this);
            mouseFilter.FormClicked += FormClicked;
            Application.AddMessageFilter(mouseFilter);
        }

        private void UpdateStatus(string name, PictureBox pictureBox, ServiceControllerStatus? status, bool showNotification = true)
        {
            var message = $"Status Changed:" + status.ToString();
            var icon = ToolTipIcon.Warning;

            if (status == null)
            {
                message = "Not found";
                icon = ToolTipIcon.Warning;
                pictureBox.Image = NotFoundImage;
            }
            else if (status == ServiceControllerStatus.Running)
            {
                message = "Back to normal";
                icon = ToolTipIcon.Info;
                pictureBox.Image = OkImage;
            }
            else if (status == ServiceControllerStatus.Stopped)
            {
                message = "Service stopped. System might be compromised.";
                icon = ToolTipIcon.Error;
                pictureBox.Image = ErrorImage;
            }
            else
            {
                pictureBox.Image = WarnImage;
            }

            if (showNotification)
            {
                notifyIcon.ShowBalloonTip(5000, name, message, icon);
            }

            UpdateNotificationIcon(name, icon == ToolTipIcon.Info);
        }

        private void UpdateNotificationIcon(string name, bool status)
        {
            _healthStatus[name] = status;

            if(_healthStatus.Any(x=> !x.Value))
            {
                notifyIcon.Icon = Properties.Resources.red_logo_22_22;
                notifyIcon.Text = "Invinsense 3.0 - Not all services are healthy";
            }
            else
            {
                notifyIcon.Icon = Properties.Resources.green_logo_22_22;
                notifyIcon.Text = "Invinsense 3.0 - Healthy"; 
            }
        }

        private string avLastStatus = "";

        private void AvCheckTick(object sender, EventArgs e)
        {
            var status = ServiceHelper.AVStatus("Windows Defender");

            if (avLastStatus == status)
            {
                return;
            }

            avLastStatus = status;

            var message = "Not found";
            var icon = ToolTipIcon.Error;

            switch (status)
            {
                case "Enabled":
                    pbDefender.Image = OkImage;
                    message = "Healthy";
                    icon = ToolTipIcon.Info;
                    break;
                case "Need Update":
                    pbDefender.Image = WarnImage;
                    message = "Out of date";
                    icon = ToolTipIcon.Warning;
                    break;
                case "Disabled":
                    pbDefender.Image = ErrorImage;
                    message = "Disabled";
                    icon = ToolTipIcon.Error;
                    break;
                default:
                    pbDefender.Image = NotFoundImage;
                    break;
            }

            notifyIcon.ShowBalloonTip(5000, "Windows Defender", message, icon);
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FormClicked(object sender, EventArgs e)
        {
            Hide();
        }

        private void ShowClick(object sender, EventArgs e)
        {
            BringToTop();
        }

        private void BringToTop()
        {
            //Checks if the method is called from UI thread or not
            if (InvokeRequired)
            {
                Invoke(new Action(BringToTop));
            }
            else
            {
                Visible = true;

                WindowState = FormWindowState.Normal;

                //Keeps the current topmost status of form
                bool top = TopMost;

                //Brings the form to top
                TopMost = true;

                //Set form's topmost status back to whatever it was
                TopMost = top;
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
        );

     }
}