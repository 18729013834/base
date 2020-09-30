﻿using System.Web;
using System.Web.Mvc;
using SSO.Utilities;
/*add customized code between this region*/
/*add customized code between this region*/


namespace case1.Web.Controllers
{
    public class AccountController : AccountBaseController
    {
        protected override ActionResult ToActionRegistered(RegisterModelBase model)
        {
            if (!string.IsNullOrEmpty(model.OrigUrl))
            {
                return this.Redirect(HttpUtility.UrlDecode(model.OrigUrl));
            }
            return this.RedirectToRoute(new { Controller = "Student1", Action = "index", Area ="srctest6"});
        }

        protected override ActionResult ToActionLogined(LoginModelBase model)
        {
            if (!string.IsNullOrEmpty(model.OrigUrl))
            {
                return this.Redirect(HttpUtility.UrlDecode(model.OrigUrl));
            }
            return this.RedirectToRoute(new { Controller = "Student1", Action = "index", Area ="srctest6"});
        }/*add customized code between this region*/
/*add customized code between this region*/
    }
}