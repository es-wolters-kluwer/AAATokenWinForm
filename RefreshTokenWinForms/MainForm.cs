using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace RefreshTokenWinForms
{
    public partial class MainForm : Form
    {
        #region " Constructors "

        public MainForm()
        {
            InitializeComponent();
            enableTLS12();
        }

        #endregion

        #region " Event Handlers "

        private void btnGetNewAccessToken_Click(object sender, EventArgs e)
        {

            if (this.txtRefreshToken.Text == String.Empty)
            {
                MessageBox.Show("Hay que indicar un Refresh Token.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string expiresIn       = String.Empty;
                string accessToken     = String.Empty;
                string refreshTokenNew = String.Empty;

                HttpClient httpClient = new HttpClient() { BaseAddress = new Uri(Constants.TokenEndPoint) };
                Dictionary<string, string> parameters = new Dictionary<string, string>();

                parameters.Add("grant_type", "refresh_token");
                parameters.Add("client_id", Constants.OAuthClientName);
                parameters.Add("client_secret", Constants.OAauthClientSecret);
                parameters.Add("refresh_token", this.txtRefreshToken.Text);

                HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, "");
                httpRequest.Content = new FormUrlEncodedContent(parameters);
                HttpResponseMessage httpResponse = httpClient.SendAsync(httpRequest).Result;

                if ((httpResponse != null) && (httpResponse.IsSuccessStatusCode) && (httpResponse.Content != null))
                {
                    string content = httpResponse.Content.ReadAsStringAsync().Result;
                    JObject contentJson = JObject.Parse(content);

                    if (contentJson["refresh_token"] == null)
                    {
                        showHttpError(this.Text, "En la respuesta no viene el parámetro 'refresh_token'.", ref httpResponse);
                    }
                    else
                    {
                        if (contentJson["access_token"] == null)
                        {
                            showHttpError(this.Text, "En la respuesta no viene el parámetro 'access_token'.", ref httpResponse);
                        }
                        else
                        {
                            if (contentJson["expires_in"] == null)
                            {
                                showHttpError(this.Text, "En la respuesta no viene el parámetro 'expires_in'.", ref httpResponse);
                            }
                            else
                            {
                                expiresIn       = contentJson["expires_in"   ].ToString();
                                accessToken     = contentJson["access_token" ].ToString();
                                refreshTokenNew = contentJson["refresh_token"].ToString();
                            }
                        }
                    }
                }
                else
                {
                    showHttpError(this.Text, "Error al obtener un AccessToken.", ref httpResponse);
                }

                this.txtExpiresIn.Text       = expiresIn;
                this.txtAccessToken.Text     = accessToken;
                this.txtRefreshTokenNew.Text = refreshTokenNew;
            }
        }

        #endregion

        #region " Private Methods "

        private void enableTLS12()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | (SecurityProtocolType)(768) | (SecurityProtocolType)(3072);
        }

        private void showHttpError(string title, string message, ref HttpResponseMessage httpResponse)
        { 
            if (httpResponse != null) {
                message += "\r\n" + "HTTP status code " + httpResponse.StatusCode;
                if (httpResponse.Content != null) { message += ": " + httpResponse.Content.ReadAsStringAsync().Result; }
            }
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}
