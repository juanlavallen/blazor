namespace Taskly.Models;

public class TasklyItem
{
    public Guid Id { get; set; }
    public string Title { get; set; } = default!;
    public string Summary { get; set; } = default!;
    public string Priority { get; set; } = default!;
    public bool IsDone { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
