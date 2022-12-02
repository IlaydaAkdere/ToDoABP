using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace ToDoApp.Entities
{
    public class ToDoItem :BasicAggregateRoot<Guid>
    {
        public string Text { get; set; }
    }
}
