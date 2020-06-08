using System.Collections.Generic;

namespace StackUnderflow.Models
{
  public class Thread
  {
    public int ThreadId { get; set; }
    public string Title { get; set; }
    public int ForumId { get; set; }
    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<Post> Posts { get; }

    public Thread()
    {
      this.Threads = new HashSet<Post>();
    }
  }
}