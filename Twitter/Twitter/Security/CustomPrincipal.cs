using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using Models;
using Services;

namespace Twitter.Security
{
    public class CustomPrincipal : IPrincipal
    {
        private LoginModel Login;
        public CustomPrincipal(LoginModel login)
        {
            this.Login = login;
            this.Identity = new GenericIdentity(login.Email);
        }
        public IIdentity Identity
        {
            get;
            set;
        }

        public bool IsInRole(string role)
        {
            var roles = role.Split(new char[] { ',' });
            return roles.Any(r => this.Login.Roles.Contains(r));
        }
    }
}