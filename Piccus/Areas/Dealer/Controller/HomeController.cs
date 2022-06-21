using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Piccus.Core.StringInfo;
using Piccus.Web.BaseController;
using Piccus.Entities.Concrete;

namespace Piccus.Web.Areas.Dealer.Controllers
{
    [Area(AreaInfo.Dealer)]
    [Authorize(Roles = RoleInfo.Dealer)]
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
