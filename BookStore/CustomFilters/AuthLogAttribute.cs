using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;

namespace BookStore.CustomFilters
{
    public class AuthLogAttribute : TypeFilterAttribute
    {
        public AuthLogAttribute(string actionName, string roleName) : base (typeof(AuthorizeAction))
        {
        
        }
    }
    public class AuthorizeAction : IAuthorizationFilter {
        private readonly string _actionName;
        private readonly string _roleName;
        public AuthorizeAction(string roleName, string actionName) {
            _actionName = actionName;
            _roleName = roleName;
            View = "Authorize Failed";
        }
        public string View { get; set; }
        public void OnAuthorization (AuthorizationFilterContext filterContext)
        {
            switch(_actionName)
            { 
                case "Create";
                    if (!filterContext.HttpContext.User.IsInRole(_roleName)) {
                        var vr = new ViewResult();
                        vr.ViewName = View;
                        filterContext.Result = vr;

                    }
                    break
            }
        }
    }
}
