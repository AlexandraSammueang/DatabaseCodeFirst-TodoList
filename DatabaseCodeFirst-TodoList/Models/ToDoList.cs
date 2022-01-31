using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCodeFirst_TodoList.Models
{
    class ToDoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ansvarig { get; set; }
        public bool Fixat { get; set; }
    }
}

//◦ Todo-appen:
//◦ Skapa ett object för en Todo-lista med posterna Namn, Ansvarig och Fixat
//◦ Med hjälp av Code-first-upplägget låter du EF skapa tabellen, I en ny databas.
//◦ Bygg ett enkelt admin för att kunna lägga till poster I Todo-listan
//◦ Gör också så att du kan ange ett Id på en todo-post, som du vill ta bort
//◦ Gör också så att du kan ange ett id för att sätta todo-posten som Fixad
