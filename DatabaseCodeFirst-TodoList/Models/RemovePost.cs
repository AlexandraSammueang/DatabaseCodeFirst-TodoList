using System;
using System.Linq;
using DatabaseCodeFirst_TodoList.Data;

namespace DatabaseCodeFirst_TodoList.Models
{
    class RemovePost
    {
        public static void RemovePosts()
        {
            Console.WriteLine("Vilken post vill du ta bort?");

            using (var db = new ToDoListContex())
            {
                var removePost = db.ToDoList.SingleOrDefault(c => c.Id == Convert.ToInt32(Console.ReadLine()));
                db.ToDoList.Remove(removePost);
                var affectedRows = db.SaveChanges();
                Console.WriteLine($"Ändrade rader: { affectedRows}");

            }
            using (var db = new ToDoListContex())
            {
                var toDoList = db.ToDoList;
                foreach (var list in toDoList)
                {
                    Console.WriteLine($"{list.Id}\t {list.Name}\t {list.Ansvarig}\t {list.Fixat}\t ");
                }
                
            }

        }
    }

}
    
