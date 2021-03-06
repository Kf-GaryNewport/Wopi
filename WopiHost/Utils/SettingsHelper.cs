﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace com.microsoft.dx.officewopi.Utils
{
    //public class SettingsHelper
    //{
    //    public static string ClientId
    //    {
    //        get { return ConfigurationManager.AppSettings["ida:ClientId"]; }
    //    }

    //    public static string ClientSecret
    //    {
    //        get { return ConfigurationManager.AppSettings["ida:ClientSecret"]; }
    //    }

    //    //public static string AuthorizationUri = "https://login.microsoftonline.com";
    //    //public static string Authority = String.Format("{0}/common", AuthorizationUri);
    //    //public static string AADGraphResourceId = "https://graph.windows.net";
    //    //public static string MicrosoftGraphResourceId = "https://graph.microsoft.com";
    //    //public static string Audience = "https://officewopi.azurewebsites.net";

    //    public static string AuthorizationUri
    //    {
    //        get { return ConfigurationManager.AppSettings["AuthorizationUri"]; }
    //    }

    //    public static string Authority = String.Format("{0}/common", AuthorizationUri);

    //    public static string AADGraphResourceId
    //    {
    //        get { return ConfigurationManager.AppSettings["AADGraphResourceId"]; }
    //    }

    //    public static string MicrosoftGraphResourceId
    //    {
    //        get { return ConfigurationManager.AppSettings["MicrosoftGraphResourceId"]; }
    //    }
    //    public static string Audience
    //    {
    //        get { return ConfigurationManager.AppSettings["Audience"]; }
    //    }
    //}

    public class SettingsHelper
    {
        public static string ClientId
        {
            get { return System.Environment.GetEnvironmentVariable("ida:ClientId"); }
        }

        public static string ClientSecret
        {
            get { return System.Environment.GetEnvironmentVariable("ida:ClientSecret"); }

        }

        //public static string AuthorizationUri = "https://login.microsoftonline.com";
        //public static string Authority = String.Format("{0}/common", AuthorizationUri);
        //public static string AADGraphResourceId = "https://graph.windows.net";
        //public static string MicrosoftGraphResourceId = "https://graph.microsoft.com";
        //public static string Audience = "https://officewopi.azurewebsites.net";

        public static string AuthorizationUri
        {
            get { return System.Environment.GetEnvironmentVariable("AuthorizationUri"); }
        }

        public static string Authority = String.Format("{0}/common", AuthorizationUri);

        public static string AADGraphResourceId
        {
            get { return System.Environment.GetEnvironmentVariable("AADGraphResourceId"); }
        }

        public static string MicrosoftGraphResourceId
        {
            get { return System.Environment.GetEnvironmentVariable("MicrosoftGraphResourceId"); }
        }
        public static string Audience
        {
            get { return System.Environment.GetEnvironmentVariable("Audience"); }
        }
    }
}