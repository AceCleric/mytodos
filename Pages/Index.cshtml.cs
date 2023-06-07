using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mytodos.Models;
using mytodos.Services;

namespace mytodos.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public JsonFileTodoService TodoService;
    public IEnumerable<Todo> Todos { get; private set; }

    public IndexModel(ILogger<IndexModel> logger, JsonFileTodoService todoService)
    {
        _logger = logger;
        TodoService = todoService;
    }

    public void OnGet()
    {
        Todos = TodoService.GetTodos();
    }
}
