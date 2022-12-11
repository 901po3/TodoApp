using System;
using System.Collections.Generic;
using TodoApp.Models;

namespace TodoApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITodoRepository _repository = new TodoRepositoryInMemory();
            List<Todo> todos = new List<Todo>();
            todos = _repository.GetAll();

            foreach (var todo in todos)
            {
                Console.WriteLine($"{todo.Id} -  { todo.Title} ({ todo.IsDone})");
            }

            Todo newTodo = new Todo { Title = "database", IsDone = false };
            _repository.Add(newTodo);

            foreach (var todo in todos)
            {
                Console.WriteLine($"{todo.Id} -  { todo.Title} ({ todo.IsDone})");
            }
        }
    }
}
