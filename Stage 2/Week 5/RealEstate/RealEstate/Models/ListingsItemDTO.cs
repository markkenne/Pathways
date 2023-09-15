//PropertyItemDTO.cs
namespace TodoApi.Models;

public class TodoItemDTO
{
    public long Id { get; set; }
    public string? Name { get; set; }

    public string? Worker { get; set; }
    public bool IsComplete { get; set; }

}