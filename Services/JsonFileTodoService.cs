using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using mytodos.Models;
using Microsoft.AspNetCore.Hosting;

namespace mytodos.Services
{
    public class JsonFileTodoService
    {
        public JsonFileTodoService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "todos.json"); }
        }

        public IEnumerable<Todo> GetTodos()
        {
            using(var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Todo[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}