using Microsoft.EntityFrameworkCore;


namespace DatabaseCodeFirst_TodoList.Data
{
    class ToDoListContex : DbContext
    {
        public DbSet<Models.ToDoList> ToDoList { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=ToDoList;Trusted_Connection=True;");
            
        }
    }
}

