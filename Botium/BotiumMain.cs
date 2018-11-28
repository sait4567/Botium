using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
                    idData.InnerText = "";
                    idData.InnerText = idBox.Text;
                }
            }
            foreach (HtmlElement passData in inputs)
            {
                if (passData.GetAttribute("id").Contains("bgcdw_login_form_password"))
                {
                    passData.InnerText = passBox.Text;
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
            consoleBox.Text = "Trying to Login...";
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
            mapBrowser.Navigate("https://" + server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution");
        }
    }
}
