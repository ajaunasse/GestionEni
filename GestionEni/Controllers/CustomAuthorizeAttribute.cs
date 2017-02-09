using GestionEni.Context;
using GestionEni.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEni.Controllers
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute  
    {

        EFPersonneRepository context = new EFPersonneRepository(); // my entity  
        EFRoleRepository reporole = new EFRoleRepository();
        private readonly string[] allowedroles;
        public CustomAuthorizeAttribute(params string[] roles)
        {
            this.allowedroles = roles;
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool authorize = false;
            foreach (var role in allowedroles)
            {
                Role unrole = reporole.Roles.Where(x => x.libelle.Equals(role)).FirstOrDefault();
                Personne connectedUser = this.getUser(httpContext);
                Personne user = null;
                if (connectedUser != null)
                {
                    user = context.Personnes.Where(m => m.IdPersonne == connectedUser.IdPersonne/* getting user form current context */ && unrole.IdRole == connectedUser.Role).FirstOrDefault();
                }
                if (user != null)
                {
                    authorize = true; /* return true if Entity has current user(active) with specific role */
                    httpContext.Session["personneCo"] = user;
                }
            }
            return authorize;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new HttpUnauthorizedResult();
        }

        private Personne getUser(HttpContextBase httpContext)
        {
            if (httpContext.Request.Cookies["user"] != null)
            {
                return JsonConvert.DeserializeObject<Personne>(httpContext.Request.Cookies["user"].Value);
            }
            else
            {
                return null;
            }
        }
    }
}