using System;
using DatabaseCodeFirst_TodoList.Data;


namespace DatabaseCodeFirst_TodoList.Models
{
    class AddPost
    {

        public static void AddPosts()
        {
            bool keepAsking = true;
            while (keepAsking)
            {
                using (var database = new ToDoListContex())
                {
                    var todoList = database.ToDoList;
                    foreach (var list in todoList)
                    {
                        Console.WriteLine($"{list.Id}\t {list.Name}\t {list.Ansvarig}\t {list.Fixat}\t ");
                    }
                }
                Console.WriteLine(@"Vill du lägga till en punkt på ""att-göra"" listan? ");
                string ask = Console.ReadLine();

                if (ask == "ja" || ask == "Ja" )
                {
                    Console.Write("Vad ska göras?: ");
                    var syssla = Console.ReadLine();
                    
                    Console.Write("Vem ansvarar för att detta blir gjort?: ");
                    var ansvarig = Console.ReadLine();

                    Console.Write("Är detta fixat?: ");
                    var fixat = Console.ReadLine();

                    Console.Clear();
                    using (var database = new ToDoListContex())
                    {
                        var newToDoPost = new ToDoList
                        {
                            Name = syssla,
                            Ansvarig = ansvarig,
                            Fixat = fixat=="ja" ==true
                        };

                        database.Add(newToDoPost);
                        database.SaveChanges();
                    }
                }
                
                Console.WriteLine("You like to exit?");
                string exitAnswer = Console.ReadLine();
                if (exitAnswer == "ja")
                {
                    keepAsking = false;
                }
                   
            }
        }
    }
}