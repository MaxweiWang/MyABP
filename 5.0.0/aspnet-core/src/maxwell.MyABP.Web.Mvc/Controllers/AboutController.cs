using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using maxwell.MyABP.Controllers;

namespace maxwell.MyABP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : MyABPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
