using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace LoginWinForms.Forms
{
    public partial class MainForm : Form
    {
        #region " Constructors "

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region " Event Handlers "

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            this.btnLogin.Enabled = false;

            NavigationForm navigationForm = new NavigationForm();
            navigationForm.WindowState = FormWindowState.Maximized;
            navigationForm.ShowDialog(this);

            this.btnLogin.Enabled = true;

            if (navigationForm.ErrorMessage != string.Empty)
            {
                MessageBox.Show(navigationForm.ErrorMessage, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (navigationForm.AuthorizationCode != String.Empty)
                {
                    string expiresIn = string.Empty;
                    string accessToken = string.Empty;
                    string refreshToken = string.Empty;
                    string returnMessage = string.Empty;

                    if (processOAuthCode(navigationForm.AuthorizationCode, ref accessToken, ref expiresIn, ref refreshToken, ref returnMessage))
                    {
                        ResultsForm resultsForm = new ResultsForm(expiresIn, accessToken, refreshToken);
                        resultsForm.ShowDialog(this);
                    }
                    else
                    {
                        MessageBox.Show(returnMessage, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.WindowState = FormWindowState.Normal;
            }
        }

        #endregion

        #region " Private Methods "

        private string getValueString(object valueObject)
        {
            string valueString = String.Empty;
            if (validateValue(valueObject)) { valueString = valueObject.ToString(); }
            return valueString;
        }

        private bool processOAuthCode(string code, ref string accessToken, ref string expiresIn, ref string refreshToken, ref string returnMessage)
        {
            bool ok = false;
            HttpResponseMessage httpResponse = null;

            using (HttpClient httpClient = new HttpClient() { BaseAddress = new Uri(Constants.TokenEndPoint)})
            {
                HttpRequestMessage         httpRequest = new HttpRequestMessage(HttpMethod.Post, "");
                Dictionary<String, String> parameters  = new Dictionary<String, String>();

                parameters.Add("grant_type", "authorization_code");
                parameters.Add("code", code);
                parameters.Add("redirect_uri", Constants.RedirectUri);
                parameters.Add("client_id", Constants.OAuthClientName);
                parameters.Add("client_secret", Constants.OAauthClientSecret);

                httpRequest.Content = new FormUrlEncodedContent(parameters);
                httpResponse = httpClient.SendAsync(httpRequest).Result;

                if (httpResponse != null)
                {
                    string content = string.Empty;
                    if (httpResponse != null) { content = httpResponse.Content.ReadAsStringAsync().Result; }

                    if (httpResponse.IsSuccessStatusCode)
                    {
                        JObject contentObject = JObject.Parse(content);
                        expiresIn    = getValueString(contentObject["expires_in"   ]);
                        accessToken  = getValueString(contentObject["access_token" ]);
                        refreshToken = getValueString(contentObject["refresh_token"]);
                        ok = true;
                    }
                    else
                    {
                        if (content != string.Empty) { content = " - " + content; }
                        returnMessage = String.Concat("Error obteniendo el token. Código HTTP: ", httpResponse.StatusCode, " - ", content);
                    }
                }
            }

            return ok;
        }

        private bool validateValue(object value)
        {
            bool   validationOK = (value != null) && (value != DBNull.Value) && (!string.IsNullOrEmpty(value.ToString()));
            return validationOK;
        }

        #endregion
    }
}