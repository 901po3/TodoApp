using System;
using System.Collections.Generic;
using System.Text;

namespace TodoModel
{
    interface ITodoRepository
    {
        void Add(Todo todo);
        List<Todo> GetAll();
    }
}
