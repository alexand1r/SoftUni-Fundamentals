using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();
            Problem2();
            BlogDbContext db;
            db = new BlogDbContext();
            Post post;
            Problem3(db, out post);
            Problem4(db, post);
            Problem5(db);
            Problem6(db);
            Problem7(db);

        }

        private static void Problem7(BlogDbContext db)
        {
            // var db = new BlogDbContext();
            var startDate = new DateTime(2016, 05, 19);
            var endDate = new DateTime(2016, 06, 14);
            var posts = db.Database.SqlQuery<PostData>(
              @"SELECT ID, Title, Date FROM Posts
                WHERE CONVERT(date, Date)
                BETWEEN {0} AND {1}
                ORDER BY Date",
              startDate, endDate);
            foreach (var p in posts)
                Console.WriteLine(
                  $"#{p.ID}: {p.Title} ({p.Date})");
        }

        private static void Problem6(BlogDbContext db)
        {
            //var db = new BlogDbContext();
            var lastPost = db.Posts
              .OrderByDescending(p => p.ID)
              .First();
            db.Comments.RemoveRange(
              lastPost.Comments);
            lastPost.Tags.Clear();
            db.Posts.Remove(lastPost);
            db.SaveChanges();
            Console.WriteLine(
              $"Deleted post #{lastPost.ID}");
        }

        private static void Problem5(BlogDbContext db)
        {
            //var db = new BlogDbContext();
            var user = db.Users
                .Where(u => u.Username == "maria")
                .First();
            user.PasswordHash =
              Guid.NewGuid().ToByteArray();
            db.SaveChanges();
            Console.WriteLine(
                "User #{0} ({1}) has a new random password.",
                user.ID, user.Username);
        }

        private static void Problem4(BlogDbContext db, Post post)
        {
            //var db = new BlogDbContext();
            post = new Post()
            {
                Title = "New Post Title",
                Date = DateTime.Now,
                Body = "This post have comments and tags",
                User = db.Users.First(),
                Comments = new Comment[] {
                    new Comment() { Text = "Comment 1", Date = DateTime.Now },
                    new Comment() { Text = "Comment 2", Date = DateTime.Now,
                      User = db.Users.First() } },
                Tags = db.Tags.Take(3).ToList()
            };
            db.Posts.Add(post);
            db.SaveChanges();
        }

        private static void Problem3(BlogDbContext db, out Post post)
        {
            
            post = new Post()
            {
                Title = "New Title",
                Body = "New Post Body",
                Date = DateTime.Now
            };
            db.Posts.Add(post);
            db.SaveChanges();
            Console.WriteLine("Post #{0} created.", post.ID);
        }

        private static void Problem2()
        {
            var db = new BlogDbContext();
            // Use LINQ to query the Posts enities
            var posts = db.Posts.Select(p => new
            {
                p.ID,
                p.Title,
                Comments = p.Comments.Count(),
                Tags = p.Tags.Count()
            });
            Console.WriteLine("SQL query:\n{0}\n", posts);
            foreach (var p in posts)
                Console.WriteLine($"{p.ID} {p.Title} ({p.Comments} comments, {p.Tags} tags)");
        }

        private static void Problem1()
        {
            var db = new BlogDbContext();
            foreach (var user in db.Users)
                Console.WriteLine(user.Username);
        }
    }
}
