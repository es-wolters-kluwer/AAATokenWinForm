using System.Configuration;


    public static class Constants
    {
        public static string OAuthClientName = ConfigurationManager.AppSettings["OAuthClientName"];
        public static string OAauthClientSecret = ConfigurationManager.AppSettings["OAauthClientSecret"];
        public static string LicensedAppId      = ConfigurationManager.AppSettings["LicensedAppId"];

        public static string AuthorizeEndPoint = ConfigurationManager.AppSettings["AuthorizeEndPoint"];
        public static string TokenEndPoint = ConfigurationManager.AppSettings["TokenEndPoint"];

        public const string RedirectUri        = "http://oob/oauth20_desktop.srf";

        public const string RedirectPath       = "/oauth20_desktop.srf";
        public const string ErrorPath          = "/err.srf";
    }
