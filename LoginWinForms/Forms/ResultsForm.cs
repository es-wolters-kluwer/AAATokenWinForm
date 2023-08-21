using System;
using System.Net;
using System.Windows.Forms;

namespace LoginWinForms.Forms
{
    public partial class ResultsForm : Form
    {
        #region " Variables "

        private string _expiresIn;
        private string _accessToken;
        private string _refreshToken;

        #endregion

        #region " Constructors "

        public ResultsForm(string expiresIn, string accessToken, string refreshToken)
        {
            InitializeComponent();

            _expiresIn = expiresIn;
            _accessToken = accessToken;
            _refreshToken = refreshToken;
        }

        #endregion

        #region " Event Handlers "

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            enableTLS12();

            this.txtExpiresIn.Text    = _expiresIn;
            this.txtAccessToken.Text  = _accessToken;
            this.txtRefreshToken.Text = _refreshToken;
        }

        #endregion

        #region " Private Methods "

        private void enableTLS12()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | (SecurityProtocolType)768 | (SecurityProtocolType)3072;
        }

        #endregion
    }
}
