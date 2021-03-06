using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using StackUnderflow.Models;

namespace StackUnderflow.Controllers
{
  public class ForumsController : Controller
  {
    private readonly StackUnderflowContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public ForumsController(UserManager<ApplicationUser> userManager, StackUnderflowContext db)
    {
      _db = db;
      _userManager = userManager;
    }

    public ActionResult Index()
    {
      List<Forum> allForums = _db.Forums.Include(forums => forums.Threads).ToList();
      return View(allForums);
    }

    [HttpGet("/Forums/{id}")]
    public ActionResult Show(int id)
    {
      ViewBag.Forum = _db.Forums.FirstOrDefault(forums => forums.ForumId == id);
      List<Thread> allThreads = _db.Threads.Include(threads => threads.Posts).Where(threads => threads.ForumId == id).ToList();
      return View(allThreads);
    }
  }
}