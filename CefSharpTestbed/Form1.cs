using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CefSharpTestbed
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;

        public Form1()
        {
            InitializeComponent();

            InitializeChromium();
        }

        public void InitializeChromium()
        {
            var settings = new CefSettings();

            // This line is needed (along with settings in app.config and .csproj) to get this to work with AnyCPU
            settings.BrowserSubprocessPath = @"x86\CefSharp.BrowserSubprocess.exe";

            // Initialize cef with the provided settings
            Cef.Initialize(settings);

            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("http://www.google.com");

            // Add it to the form and fill it to the form window.
            pnlCefSharp.Controls.Add(chromeBrowser);

            // Just giving it a big enough size to show everything
            ClientSize = new System.Drawing.Size(1024, 768);

            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void btnChromeDevTools_Click(object sender, System.EventArgs e)
        {
            chromeBrowser.ShowDevTools();
        }
    }
}
