using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using StackUnderflow.ViewModels;
using StackUnderflow.Models;

namespace StackUnderflow.Controllers
{
  public class AccountController : Controller
  {
    private readonly StackUnderflowContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, StackUnderflowContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register(RegisterViewModel model)
    {
      ApplicationUser user = new ApplicationUser { UserName = model.UserName, Email = model.Email };
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded)
      {
        return RedirectToAction("Index", "Forums");
      }
      else
      {
        return View();
      }
    }
  }
}