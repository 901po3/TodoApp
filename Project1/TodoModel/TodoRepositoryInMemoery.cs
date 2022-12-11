using System;
using System.Linq;
using System.Collections.Generic;

namespace TodoModel
{
    public class TodoRepositoryInMemoery : ITodoRepository
    {
        List<Todo> todos = new List<Todo>();

        public TodoRepositoryInMemoery()
        {
            todos = new List<Todo>
            {
                new Todo { Id = 1, Name = "one", IsDone = true},
                new Todo { Id = 2, Name = "two", IsDone = true},
                new Todo { Id = 3, Name = "three", IsDone = false}
            };
        }

        public void Add(Todo todo)
        {
            todo.Id = todos.Max(t => t.Id) + 1;
            todos.Add(todo);
        }

        public List<Todo> GetAll()
        {
            return todos;
        }
    }
}
