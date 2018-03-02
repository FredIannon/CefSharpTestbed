using System;
using System.IO;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CefSharpTestbed
{
    public partial class Form1 : Form
    {
        private ChromiumWebBrowser _chromeBrowser;
        private readonly string _rootPath;

        public Form1()
        {
            InitializeComponent();

            _rootPath = Application.StartupPath;

            InitializeChromium();
        }

        public void InitializeChromium()
        {
            CefSharpSettings.LegacyJavascriptBindingEnabled = true;

            var cefSettings = new CefSettings
            {
                WindowlessRenderingEnabled = true,
                MultiThreadedMessageLoop = true,
                BrowserSubprocessPath = @"x86\CefSharp.BrowserSubprocess.exe",  ////This will always run as x86 https://github.com/cefsharp/CefSharp/issues/1714 
                LogSeverity = LogSeverity.Error,
            };
#if DEBUG
            cefSettings.RemoteDebuggingPort = 8088;
#endif
            Cef.Initialize(cefSettings);

            // Create a browser component
            _chromeBrowser = new ChromiumWebBrowser("");

            BrowserSettings browserSettings = new BrowserSettings
            {
                FileAccessFromFileUrls = CefState.Enabled,
                UniversalAccessFromFileUrls = CefState.Enabled
            };
            _chromeBrowser.BrowserSettings = browserSettings;

//            _chromeBrowser.Load("http://www.google.com");

            //            _chromeBrowser.RegisterJsObject("CSharp", this);
            //            _ClientShellWinForms = new ClientShellWinForms(_chromeBrowser);
//            _ClientShellWinForms.LoadLocalUrl("html/index.html");
            LoadLocalUrl("html/index.html");

            // Add it to the form and fill it to the form window.
            pnlCefSharp.Controls.Add(_chromeBrowser);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void btnChromeDevTools_Click(object sender, System.EventArgs e)
        {
            _chromeBrowser.ShowDevTools();
        }

        public void LoadLocalUrl(string relativePath)
        {
            var localFile = $"{_rootPath}/{relativePath}";
            if (File.Exists(localFile) == false)
            {
                throw new Exception($"Cannot find the file {localFile}");
            }
            var filePath = $"file://{localFile}";
            _chromeBrowser.Load(filePath);
        }
    }
}
