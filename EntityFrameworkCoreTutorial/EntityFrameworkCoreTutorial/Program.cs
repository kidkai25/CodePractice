using System;
using System.Linq;

namespace EntityFrameworkCoreTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new BlogginContext())
            {
                //Create
                Console.WriteLine("Inserting a new blog");
                db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                db.SaveChanges();

                //Read
                Console.WriteLine("Querying for a blog");
                var blog = db.Blogs.OrderBy(b => b.BlogId).First();

                //Update
                Console.WriteLine("Updating the blog and adding a post");
                blog.Url = "http://devblogs.microsoft.com/dotnet";
                blog.Posts.Add(
                    new Post
                    {
                        Title = "Hello Wolrd",
                        Content = "I wrote an app using EF Core"
                    });
                db.SaveChanges();


                //Delete
                Console.WriteLine("Delete the blog");
                db.Remove(blog);
                db.SaveChanges();
                            
            }
        }
    }
}
