using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace mytodos.Models
{
    public class Todo
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Finished { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Todo>(this);
    }
}