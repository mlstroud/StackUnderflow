using System.Collections.Generic;

namespace StackUnderflow.Models
{
  public class Post
  {
    public int PostId { get; set; }
    public string Message { get; set; }
    public int ThreadId { get; set; }
    public int ForumId {get; set;}
    public virtual ApplicationUser User { get; set; }
  }
}