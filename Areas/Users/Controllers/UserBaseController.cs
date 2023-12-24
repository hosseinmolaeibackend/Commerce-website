using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Test.Areas.Users.Controllers
{
    [Authorize]
    public class UserBaseController : Controller
    {
    }
}
