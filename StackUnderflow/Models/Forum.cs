using System.Collections.Generic;

namespace StackUnderflow.Models
{
  public class Forum
  {
    public int ForumId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual ICollection<Thread> Threads { get; }

    public Forum()
    {
      this.Threads = new HashSet<Thread>();
    }
  }
}