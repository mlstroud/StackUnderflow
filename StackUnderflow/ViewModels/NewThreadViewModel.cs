using StackUnderflow.Models;

namespace StackUnderflow.ViewModels
{
  public class NewThreadViewModel
  {
    public string Title { get; set; }
    public int ForumId { get; set; }
    public string Message { get; set; }
    public ApplicationUser User { get; set; }
  }
}