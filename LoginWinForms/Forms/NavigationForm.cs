using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Policy;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace LoginWinForms.Forms
{
    public partial class NavigationForm : Form
    {
        #region " Constructors "

        public NavigationForm()
        {
            InitializeComponent();
            // Call to AAA to authenticate the user...
            string url = String.Concat
            (
                Constants.AuthorizeEndPoint,
                "?client_id=", Constants.OAuthClientName,
                "&response_type=code+id_token",
                "&response_mode=fragment",
                "&redirect_uri=", Constants.RedirectUri,
                "&scope=WK.ES.A3EquipoContex+IDInfo+openid+offline_access",
                "&state=state",
                "&nonce=", Guid.NewGuid().ToString(),
                "&acr_values=wkOwnedAppId:", Constants.LicensedAppId
            );
            enableTLS12();
            this.webView21.Source = new Uri(url);
        }

        #endregion

        #region " Properties "

        public string AuthorizationCode = string.Empty;
        public string ErrorMessage      = string.Empty;

        #endregion

        #region " Event Handlers "

        private void webView21_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            // Captures all consent traffic. Filter the traffic for the redirect URI. The URIs query string contains either the authorization code or an error.

            // Gets the URL
            Uri url = webView21.Source;
            Uri urlRedirect = new Uri(Constants.RedirectUri);

            if (url.Host == urlRedirect.Host)            
            {
                // here you can check params returned by validation
                Dictionary<string, string> parameters = GetQueryStringParams(url.AbsoluteUri.ToString());
                if (parameters.ContainsKey("error_description"))
                {
                    this.ErrorMessage = WebUtility.UrlDecode(parameters["error_description"]);
                }
                // retrieves the authorization code
                this.AuthorizationCode = parameters["code"];
                this.Close();
            }
        }

        #endregion

        #region " Private Methods "

        private void enableTLS12()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | (SecurityProtocolType) 768 | (SecurityProtocolType) 3072;
        }

        /*
        private KeyValuePair<string, string> getKeyValuePair(string text, string separator)
        {
            KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>();

            string key   = String.Empty;
            string value = String.Empty;

            if (text.Contains(separator)) {
                string[] parts = text.Split(new string[] { separator }, StringSplitOptions.None);
                if ((parts != null) && (parts.Length == 2)) { keyValuePair = new KeyValuePair<string, string> (parts[0], parts[1]); }
            }

            return keyValuePair;
        }
        */

        /*
        private Dictionary<string, string> getQueryStringParams(string url)
        {
            Dictionary<string, string> requestParamsDic = new Dictionary<string, string>();

            if ((url != null) && (url != String.Empty))
            {
                string requestParams = String.Empty;

                if (url.Contains("?")) {
                    requestParams = url.Split(new string[] {"?"}, StringSplitOptions.None)[1];
                } else {
                    if (url.Contains("#")) { requestParams = url.Split(new string[] { "#" }, StringSplitOptions.None)[1]; }
                }

                if ((requestParams != null) && (requestParams != String.Empty))
                {
                    string[] requestParamsArray = requestParams.Split(new string[] { "&" }, StringSplitOptions.None);
                    KeyValuePair<string, string> requestParam;

                    for (int i = 0; i < requestParamsArray.Length; i++) {
                        requestParam = getKeyValuePair(requestParamsArray[i], "=");
                        requestParamsDic.Add(requestParam.Key, requestParam.Value);
                    }
                }
            }

            return requestParamsDic;
        }
        */

        #endregion

        private Dictionary<string, string> GetQueryStringParams(string url)
        {
            Dictionary<string, string> requestParamsDic = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(url))
            {
                string requestParams = string.Empty;

                if (url.Contains("?"))
                {
                    requestParams = url.Split(new[] { "?" }, StringSplitOptions.None)[1];
                }
                else if (url.Contains("#"))
                {
                    requestParams = url.Split(new[] { "#" }, StringSplitOptions.None)[1];
                }

                if (!string.IsNullOrEmpty(requestParams))
                {
                    string[] requestParamsArray = requestParams.Split(new[] { "&" }, StringSplitOptions.None);
                    KeyValuePair<string, string> requestParam = new KeyValuePair<string, string>();

                    for (int i = 0; i < requestParamsArray.Length; i++)
                    {
                        requestParam = GetKeyValuePair(requestParamsArray[i], "=");
                        requestParamsDic.Add(requestParam.Key, requestParam.Value);
                    }
                }
            }

            return requestParamsDic;
        }

        private KeyValuePair<string, string> GetKeyValuePair(string text, string separator)
        {
            KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>();
            string key = string.Empty;
            string value = string.Empty;

            if (text.Contains(separator))
            {
                string[] parts = text.Split(new[] { separator }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    keyValuePair = new KeyValuePair<string, string>(parts[0], parts[1]);
                }
            }

            return keyValuePair;
        }
    }
}
