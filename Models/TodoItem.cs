using System.Runtime.Serialization;

public class TodoItem
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public bool IsDone { get; set; }
}