using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Piccus.Core.StringInfo;
using Piccus.Web.BaseController;
using Piccus.Entities.Concrete;

namespace Piccus.Web.Areas.Admin.Controllers
{
    [Area(AreaInfo.Admin)]
    [Authorize(Roles = RoleInfo.Admin)]
    public class HomeController : BaseIdentityController
    {
        public HomeController(UserManager<AppUser> userManager) : base(userManager)
        {
        }

        #region Index
        public IActionResult Index()
        {
            return View();
        }

        #endregion
    }
}
