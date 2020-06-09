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
using StackUnderflow.ViewModels;

namespace StackUnderflow.Controllers
{
  public class ThreadsController : Controller
  {
    private readonly StackUnderflowContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public ThreadsController(UserManager<ApplicationUser> userManager, StackUnderflowContext db)
    {
      _db = db;
      _userManager = userManager;
    }

    [HttpGet("/Threads/New")]
    public ActionResult New(int forumId)
    {
      ViewBag.Forum = _db.Forums.FirstOrDefault(forums => forums.ForumId == forumId);
      return View();
    }

    [HttpPost("/Threads/New")]
    public ActionResult New(NewThreadViewModel newThread)
    {
      Thread thread = new Thread();
      thread.Title = newThread.Title;
      thread.ForumId = newThread.ForumId;
      Post post = new Post();
      post.Message = newThread.Message;
      post.ForumId = newThread.ForumId;
      _db.Threads.Add(thread);
      _db.SaveChanges();
      post.ThreadId = _db.Threads.OrderByDescending(threads => threads.ThreadId).Select(threads => threads.ThreadId).FirstOrDefault();
      _db.Posts.Add(post);
      _db.SaveChanges();

      return RedirectToAction("Show", "Forums", new { id = newThread.ForumId });
    }
  }
}