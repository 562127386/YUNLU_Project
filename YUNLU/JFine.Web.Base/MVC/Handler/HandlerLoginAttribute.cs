using JFine.Code.Online;
using JFine.Common.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JFine.Web.Base.MVC.Handler
{
    public class HandlerLoginAttribute : AuthorizeAttribute
    {
        public HandlerLoginAttribute()
        {
            
        }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            OnlineUser onlineUser = OnlineUser.Operator;
            int onlineResult = onlineUser.IsLogin();
            if (onlineResult != 1)
            {
                if (onlineResult == -1)
                {//被顶
                    CookieHelper.WriteCookie("jfine_login_error", "replace");
                    filterContext.HttpContext.Response.Write("<script>top.location.href = '/Login/Index';</script>");
                    
                }
                if (onlineResult == -2)
                {//过期
                    CookieHelper.WriteCookie("jfine_login_error", "overdue");
                    filterContext.HttpContext.Response.Write("<script>top.location.href = '/Login/Index';</script>");
                }              
                
            }
            return;
        }
    }
}