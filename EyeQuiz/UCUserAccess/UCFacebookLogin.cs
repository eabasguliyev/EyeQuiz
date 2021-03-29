using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeQuiz.Entities;
using EyeQuiz.Extensions;
using EyeQuiz.Helpers;
using EyeQuiz.Helpers.FileHelpers;
using Facebook;
using Newtonsoft.Json;

namespace EyeQuiz.UCUserAccess
{
    public partial class UCFacebookLogin : UserControl
    {
        private readonly Uri _loginUrl;
        protected FacebookClient _fb;

        public FacebookOAuthResult FacebookOAuthResult { get; set; }
        
        public UCFacebookLogin()
        {
            var config = GetApiConfig("ApiConfig.json");

            if (config == null)
            {
                MessageBox.Show("Api config file could not be find", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new ArgumentNullException("config");
            }
            if (string.IsNullOrWhiteSpace(config.AppId))
                throw new ArgumentNullException("appId");

            _fb = new FacebookClient();
            _loginUrl = GenerateLoginUrl(config.AppId, config.ExtendedPermissions);

            InitializeComponent();
        }

        private Uri GenerateLoginUrl(string appId, string extendedPermissions)
        {
            dynamic parameters = new ExpandoObject();
            parameters.client_id = appId;
            parameters.redirect_uri = "https://github.com/eabasquliyev/EyeQuiz";
            parameters.response_type = "token";
            parameters.display = "popup";

            if (!string.IsNullOrWhiteSpace(extendedPermissions))
                parameters.scope = extendedPermissions;

            return _fb.GetLoginUrl(parameters);
        }

        private void UCFacebookLogin_Load(object sender, EventArgs e)
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            WebBrowser.Navigate(_loginUrl.AbsoluteUri);

            base.OnLoad(e);
        }

        private FacebookApiConfig GetApiConfig(string fileName)
        {
            var json = string.Empty;

            FacebookApiConfig config = null;

            try
            {
                using (var fs = File.OpenRead(fileName))
                using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                    json = sr.ReadToEnd();

                config = JsonConvert.DeserializeObject<FacebookApiConfig>(json);
            }
            catch
            {
                // log
            }
            return config;
        }

        private void WebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            FacebookOAuthResult oAuthResult;

            if (_fb.TryParseOAuthCallbackUrl(e.Url, out oAuthResult))
            {
                FacebookOAuthResult = oAuthResult;

                var fb = new FacebookClient(FacebookOAuthResult.AccessToken);

                dynamic result = fb.Get("me?fields=email,name");
                
                //GetData(user_id, fb.AccessToken);

                MessageBox.Show($"Welcome {result.name}");

                var userEmail = (string) result.email;

                if (Program.Database.CheckEmail((string) result.email))
                {
                    var userFullname = (string)result.name;
                    var newUser = new User()
                    {
                        FacebookUser = true,
                        Fullname = userFullname,
                        Email = userEmail,
                    };

                    Register(newUser);
                }

                LogoutClient(fb.AccessToken);

                Form1.Instance.Login(Login(userEmail));

                this.Dispose();

                var ucLogin = Form1.Instance.Controls["PanelUcArea"].Controls["UcLogin"] as UCLogin;

                ucLogin.BringToFront();
            }
            else
            {
                FacebookOAuthResult = null;
            }
        }

        public string ResponseString { get; set; }
        private async Task GetData(string user_id, string access_token)
        {
            var client = new HttpClient();

            ResponseString = await client.GetStringAsync($@"https://graph.facebook.com/{user_id}?fields=id,name,email&access_token={access_token}");
            
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private User Login(string userMail)
        {
            return Program.Database.Users.SingleOrDefault(u => u.FacebookUser && u.Email == userMail);
        }

        private void Register(User user)
        {
            Program.Database.Register(user);
            JsonHelper.Serialize(Program.Database);
        }

        private void LogoutClient(string accesToken)
        {
            var fb = new FacebookClient();

            var logoutUrl = fb.GetLogoutUrl(new
            {
                next = "https://github.com/eabasquliyev/EyeQuiz",
                access_token = accesToken
            });
            var webBrowser = new WebBrowser();
            webBrowser.Navigated += (o, args) =>
            {
                if (args.Url.AbsoluteUri == "https://github.com/eabasquliyev/EyeQuiz")
                    return;
            };

            webBrowser.Navigate(logoutUrl.AbsoluteUri);
        }
    }
}
