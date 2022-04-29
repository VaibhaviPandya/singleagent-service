using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace SingleAgent
{
    [RunInstaller(true)]
    public partial class InstallerAction : Installer
    {
        public InstallerAction()
        {
            InitializeComponent();

            // Attach the 'Committed' event.
            Committed += new InstallEventHandler(CommittedEventHandler);
        }

        // Event handler for 'Committed' event.
        private void CommittedEventHandler(object sender, InstallEventArgs e)
        {
            try
            {
                Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                Process.Start(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\SingleAgent.exe");
            }
            catch
            {
                // Do nothing... 
            }
        }
    }
}
