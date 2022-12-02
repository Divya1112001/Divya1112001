using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Security.Principal;
using System.Threading;

namespace Authentication.Models
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        private const string Realm = "my Realm";
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //id authorization header is empty or null,then we need
            //to return Unarthorized
            if (actionContext.Request.Headers.Authorization==null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                if(actionContext.Response.StatusCode==HttpStatusCode.Unauthorized)
                {
                    actionContext.Response.Headers.Add("WWW-Authenticate",
                        string.Format("Basic realm=\"{0)", Realm));
                }
            }
           else
            {
                //get the authentication token 
                string authToken = actionContext.Request.Headers.Authorization.Parameter;
                //decode the string
                string authcode = Encoding.UTF8.GetString(Convert.FromBase64String(authToken));
                //convert the decoded string into array
                string[] unamepassarray = authcode.Split(':');
                //first elemt is username and second name is password
                string username = unamepassarray[0];
                string password = unamepassarray[1];
                //call the login method and pass username and password
                if(UserValidate.Login(username,password))
                {
                    var identity = new GenericIdentity(username);
                    IPrincipal principal = new GenericPrincipal(identity, null);
                     Thread.CurrentPrincipal = principal;
                    if (HttpContext.Current != null)
                    {
                        HttpContext.Current.User = principal;
                    }
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
        }
    }
}
