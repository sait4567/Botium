using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Botium
{
    public partial class BotiumMain : Form
    {
        public BotiumMain()
        {
            InitializeComponent();
        }
        private void loginMethod()
        {
            HtmlElementCollection inputs = homeBrowser.Document.GetElementsByTagName("input");
            foreach (HtmlElement idData in inputs)
            {
                if (idData.GetAttribute("id").Contains("bgcdw_login_form_username"))
                {                    
                    idData.InnerText = idBox.Text;
                    foreach (HtmlElement passData in inputs)
                    {
                        if (passData.GetAttribute("id").Contains("bgcdw_login_form_password"))
                        {
                            passData.InnerText = passBox.Text;                            
                        }
                    }
                }
            }

            HtmlElementCollection buttons = homeBrowser.Document.GetElementsByTagName("button");
            foreach (HtmlElement loginbutton in buttons)
            {
                if (loginbutton.InnerText == "Giriş")//for Turkish
                {
                    loginbutton.InvokeMember("click");
                }
                else if (loginbutton.InnerText == "Login")//for English
                {
                    loginbutton.InvokeMember("click");
                }
                //if you have another language add it here
                //example
                //else if (loginbutton.InnerText == "login button text")
                //{
                //    loginbutton.InvokeMember("click");
                //}
            }
            consoleBox.Text = "Trying to login...";
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginMethod();                
        }

        public string server;
        public string dosid;

        private void dosidMethod()
        {
            HttpWebResponse Res = null;
            CookieContainer CC = new CookieContainer();
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(homeBrowser.Url);
            Req.Proxy = null;
            Req.UseDefaultCredentials = true;
            Req.CookieContainer = CC;
            Res = (HttpWebResponse)Req.GetResponse();
            if (Res.Cookies != null && Res.Cookies.Count != 0)
            {
                foreach (Cookie c in Res.Cookies)
                {
                    string cookie = c.ToString();
                    string[] spt = cookie.Split('\n');
                    foreach (string item in spt)
                    {
                        if (item.Contains("dosid="))
                        {
                            dosid = item.Split('=')[1].ToString();
                            server = homeBrowser.Url.AbsoluteUri.Substring(8, 3);
                            consoleBox.Text = "Sid= " + dosid + "\n" + "Server= " + server + "\n";
                        }
                    }
                }
            }
        }
        private void homeBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            dosidMethod();
            homeBrowserResize();
            mapBrowser.Navigate("https://" + server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution");
        }
        private void homeBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            homeBrowserResize();
        }

        object pswaHeight;
        object pswaWidth;
        int pswaHeightInt;
        int pswaWidthInt;
        private enum Exec
        {
            OLECMDID_OPTICAL_ZOOM = 63
        }

        private enum execOpt
        {
            OLECMDEXECOPT_DODEFAULT = 0,
            OLECMDEXECOPT_PROMPTUSER = 1,
            OLECMDEXECOPT_DONTPROMPTUSER = 2,
            OLECMDEXECOPT_SHOWHELP = 3
        }
        private void homeBrowserResize()
        {
            pswaHeight = Screen.PrimaryScreen.WorkingArea.Height;
            pswaWidth = Screen.PrimaryScreen.WorkingArea.Width;
            pswaHeightInt = System.Convert.ToInt32(pswaHeight);
            pswaWidthInt = System.Convert.ToInt32(pswaWidth);

            if (((double)this.homeBrowser.Width > Math.Round((double)this.pswaWidthInt / 5.6) & (double)this.homeBrowser.Width < Math.Round((double)this.pswaWidthInt / 2.97)) | ((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 3.0) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 2.4)))
            {
                try
                {
                    object MyWeb = RuntimeHelpers.GetObjectValue(this.homeBrowser.ActiveXInstance);
                    NewLateBinding.LateCall(MyWeb, null, "ExecWB", new object[]
                    {
                BotiumMain.Exec.OLECMDID_OPTICAL_ZOOM,
                BotiumMain.execOpt.OLECMDEXECOPT_PROMPTUSER,
                40,
                IntPtr.Zero
                    }, null, null, null, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (((double)this.homeBrowser.Width > Math.Round((double)this.pswaWidthInt / 2.97) & (double)this.homeBrowser.Width < Math.Round((double)this.pswaWidthInt / 2.58)) | ((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 2.4) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 2.13)))
            {
                try
                {
                    object MyWeb2 = RuntimeHelpers.GetObjectValue(this.homeBrowser.ActiveXInstance);
                    NewLateBinding.LateCall(MyWeb2, null, "ExecWB", new object[]
                    {
                BotiumMain.Exec.OLECMDID_OPTICAL_ZOOM,
                BotiumMain.execOpt.OLECMDEXECOPT_PROMPTUSER,
                50,
                IntPtr.Zero
                    }, null, null, null, true);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message);
                }
            }
            if (((double)this.homeBrowser.Width > Math.Round((double)this.pswaWidthInt / 2.58) & (double)this.homeBrowser.Width < Math.Round((double)this.pswaWidthInt / 2.23)) | ((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 2.13) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 1.85)))
            {
                try
                {
                    object MyWeb3 = RuntimeHelpers.GetObjectValue(this.homeBrowser.ActiveXInstance);
                    NewLateBinding.LateCall(MyWeb3, null, "ExecWB", new object[]
                    {
                BotiumMain.Exec.OLECMDID_OPTICAL_ZOOM,
                BotiumMain.execOpt.OLECMDEXECOPT_PROMPTUSER,
                60,
                IntPtr.Zero
                    }, null, null, null, true);
                }
                catch (Exception ex3)
                {
                    MessageBox.Show(ex3.Message);
                }
            }
            if (((double)this.homeBrowser.Width > Math.Round((double)this.pswaWidthInt / 2.23) & (double)this.homeBrowser.Width < Math.Round((double)this.pswaWidthInt / 1.89)) | ((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 1.85) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 1.64)))
            {
                try
                {
                    object MyWeb4 = RuntimeHelpers.GetObjectValue(this.homeBrowser.ActiveXInstance);
                    NewLateBinding.LateCall(MyWeb4, null, "ExecWB", new object[]
                    {
                BotiumMain.Exec.OLECMDID_OPTICAL_ZOOM,
                BotiumMain.execOpt.OLECMDEXECOPT_PROMPTUSER,
                70,
                IntPtr.Zero
                    }, null, null, null, true);
                }
                catch (Exception ex4)
                {
                    MessageBox.Show(ex4.Message);
                }
            }
            if (((double)this.homeBrowser.Width > Math.Round((double)this.pswaWidthInt / 1.89) & (double)this.homeBrowser.Width < Math.Round((double)this.pswaWidthInt / 1.6)) | ((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 1.64) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 1.53)))
            {
                try
                {
                    object MyWeb5 = RuntimeHelpers.GetObjectValue(this.homeBrowser.ActiveXInstance);
                    NewLateBinding.LateCall(MyWeb5, null, "ExecWB", new object[]
                    {
                BotiumMain.Exec.OLECMDID_OPTICAL_ZOOM,
                BotiumMain.execOpt.OLECMDEXECOPT_PROMPTUSER,
                80,
                IntPtr.Zero
                    }, null, null, null, true);
                }
                catch (Exception ex5)
                {
                    MessageBox.Show(ex5.Message);
                }
            }
            if (((double)this.homeBrowser.Width > Math.Round((double)this.pswaWidthInt / 1.6) & (double)this.homeBrowser.Width < Math.Round((double)this.pswaWidthInt / 1.2)) | ((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 1.53) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 1.16)))
            {
                try
                {
                    object MyWeb6 = RuntimeHelpers.GetObjectValue(this.homeBrowser.ActiveXInstance);
                    NewLateBinding.LateCall(MyWeb6, null, "ExecWB", new object[]
                    {
                BotiumMain.Exec.OLECMDID_OPTICAL_ZOOM,
                BotiumMain.execOpt.OLECMDEXECOPT_PROMPTUSER,
                90,
                IntPtr.Zero
                    }, null, null, null, true);
                }
                catch (Exception ex6)
                {
                    MessageBox.Show(ex6.Message);
                }
            }
            if ((double)this.homeBrowser.Width > Math.Round((double)this.pswaWidthInt / 1.2) && (double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 1.16))
            {
                try
                {
                    object MyWeb7 = RuntimeHelpers.GetObjectValue(this.homeBrowser.ActiveXInstance);
                    NewLateBinding.LateCall(MyWeb7, null, "ExecWB", new object[]
                    {
                BotiumMain.Exec.OLECMDID_OPTICAL_ZOOM,
                BotiumMain.execOpt.OLECMDEXECOPT_PROMPTUSER,
                100,
                IntPtr.Zero
                    }, null, null, null, true);
                }
                catch (Exception ex7)
                {
                    MessageBox.Show(ex7.Message);
                }
            }
            //height
            if (((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 5.6) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 2.97)) | ((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 3.0) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 2.4)))
            {
                try
                {
                    object MyWeb = RuntimeHelpers.GetObjectValue(this.homeBrowser.ActiveXInstance);
                    NewLateBinding.LateCall(MyWeb, null, "ExecWB", new object[]
                    {
                BotiumMain.Exec.OLECMDID_OPTICAL_ZOOM,
                BotiumMain.execOpt.OLECMDEXECOPT_PROMPTUSER,
                40,
                IntPtr.Zero
                    }, null, null, null, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 2.97) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaWidthInt / 2.58)) | ((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 2.4) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 2.13)))
            {
                try
                {
                    object MyWeb2 = RuntimeHelpers.GetObjectValue(this.homeBrowser.ActiveXInstance);
                    NewLateBinding.LateCall(MyWeb2, null, "ExecWB", new object[]
                    {
                BotiumMain.Exec.OLECMDID_OPTICAL_ZOOM,
                BotiumMain.execOpt.OLECMDEXECOPT_PROMPTUSER,
                50,
                IntPtr.Zero
                    }, null, null, null, true);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message);
                }
            }
            if (((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 2.58) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 2.23)) | ((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 2.13) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 1.85)))
            {
                try
                {
                    object MyWeb3 = RuntimeHelpers.GetObjectValue(this.homeBrowser.ActiveXInstance);
                    NewLateBinding.LateCall(MyWeb3, null, "ExecWB", new object[]
                    {
                BotiumMain.Exec.OLECMDID_OPTICAL_ZOOM,
                BotiumMain.execOpt.OLECMDEXECOPT_PROMPTUSER,
                60,
                IntPtr.Zero
                    }, null, null, null, true);
                }
                catch (Exception ex3)
                {
                    MessageBox.Show(ex3.Message);
                }
            }
            if (((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 2.23) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 1.89)) | ((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 1.85) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 1.64)))
            {
                try
                {
                    object MyWeb4 = RuntimeHelpers.GetObjectValue(this.homeBrowser.ActiveXInstance);
                    NewLateBinding.LateCall(MyWeb4, null, "ExecWB", new object[]
                    {
                BotiumMain.Exec.OLECMDID_OPTICAL_ZOOM,
                BotiumMain.execOpt.OLECMDEXECOPT_PROMPTUSER,
                70,
                IntPtr.Zero
                    }, null, null, null, true);
                }
                catch (Exception ex4)
                {
                    MessageBox.Show(ex4.Message);
                }
            }
            if (((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 1.89) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 1.6)) | ((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 1.64) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 1.53)))
            {
                try
                {
                    object MyWeb5 = RuntimeHelpers.GetObjectValue(this.homeBrowser.ActiveXInstance);
                    NewLateBinding.LateCall(MyWeb5, null, "ExecWB", new object[]
                    {
                BotiumMain.Exec.OLECMDID_OPTICAL_ZOOM,
                BotiumMain.execOpt.OLECMDEXECOPT_PROMPTUSER,
                80,
                IntPtr.Zero
                    }, null, null, null, true);
                }
                catch (Exception ex5)
                {
                    MessageBox.Show(ex5.Message);
                }
            }
            if (((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 1.6) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 1.2)) | ((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 1.53) & (double)this.homeBrowser.Height < Math.Round((double)this.pswaHeightInt / 1.16)))
            {
                try
                {
                    object MyWeb6 = RuntimeHelpers.GetObjectValue(this.homeBrowser.ActiveXInstance);
                    NewLateBinding.LateCall(MyWeb6, null, "ExecWB", new object[]
                    {
                BotiumMain.Exec.OLECMDID_OPTICAL_ZOOM,
                BotiumMain.execOpt.OLECMDEXECOPT_PROMPTUSER,
                90,
                IntPtr.Zero
                    }, null, null, null, true);
                }
                catch (Exception ex6)
                {
                    MessageBox.Show(ex6.Message);
                }
            }
            if ((double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 1.2) && (double)this.homeBrowser.Height > Math.Round((double)this.pswaHeightInt / 1.16))
            {
                try
                {
                    object MyWeb7 = RuntimeHelpers.GetObjectValue(this.homeBrowser.ActiveXInstance);
                    NewLateBinding.LateCall(MyWeb7, null, "ExecWB", new object[]
                    {
                BotiumMain.Exec.OLECMDID_OPTICAL_ZOOM,
                BotiumMain.execOpt.OLECMDEXECOPT_PROMPTUSER,
                100,
                IntPtr.Zero
                    }, null, null, null, true);
                }
                catch (Exception ex7)
                {
                    MessageBox.Show(ex7.Message);
                }
            }
        }


    }
}
