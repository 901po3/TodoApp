using System;
using System.Linq;
using System.Collections.Generic;

namespace TodoApp.Models
{
    public class TodoRepositoryInMemory : ITodoRepository
    {
        private static List<Todo> _todos = new List<Todo>();

        public TodoRepositoryInMemory()
        {
            _todos = new List<Todo>
            {
                new Todo { Id = 1, Title = "1번 타이틀", IsDone = true },
                new Todo { Id = 2, Title = "2번 타이틀", IsDone = true },
                new Todo { Id = 3, Title = "3번 타이틀", IsDone = false },
            };
        }


        // 인-메모리 데이터베이스 사용 영역
        public void Add(Todo model)
        {
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model);
        }

        public List<Todo> GetAll()
        {
            return _todos;
        }
    }
}
