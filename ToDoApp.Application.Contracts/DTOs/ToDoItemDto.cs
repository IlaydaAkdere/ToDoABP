using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.DTOs
{
    public class ToDoItemDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
    }
}
