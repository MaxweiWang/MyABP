using Microsoft.AspNetCore.Antiforgery;
using maxwell.MyABP.Controllers;

namespace maxwell.MyABP.Web.Host.Controllers
{
    public class AntiForgeryController : MyABPControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
