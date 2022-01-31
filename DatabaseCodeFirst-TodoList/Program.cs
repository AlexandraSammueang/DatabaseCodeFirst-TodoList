using System;
using DatabaseCodeFirst_TodoList.Data;
using System.Linq;
using DatabaseCodeFirst_TodoList.Models;


namespace DatabaseCodeFirst_TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            AddPost.AddPosts();
            RemovePost.RemovePosts();

        }
    }
}
