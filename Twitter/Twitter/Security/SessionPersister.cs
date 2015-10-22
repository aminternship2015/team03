using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Twitter.Security
{
    public static class SessionPersister
    {
        static string emailSession = "email";
        public static string Email
        {
            get
            {
                if (HttpContext.Current == null)
                    return string.Empty;
                var session = HttpContext.Current.Session[emailSession];
                if (session != null)
                    return session as string;
                return null;
            }
            set
            {
                HttpContext.Current.Session[emailSession] = value;
            }
        }
    }
}