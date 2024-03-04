using Entityframework_komplettering;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Threading.Channels;



DB db = new DB();


db.Users.Add(new User { Name = "Kevin" });
db.SaveChanges();

db.Blogs.Add(new Blog { Name = "Blogg för hatare av entity framework" });
db.Blogs.Add(new Blog { Name = "Bloggen för dom som spenderade ALLDELES FÖR LÅNG TID på att få detta att funka" });
db.SaveChanges();

Blog blog = db.Blogs.Where(b => b.Name == "Bloggen för dom som spenderade ALLDELES FÖR LÅNG TID på att få detta att funka").First();

db.Users.First().Articles.Add(new Article { Title = "SQL for dummies", Blog = blog });
db.Users.First().Articles.Add(new Article { Title = "Why entity framework is outdated", Blog = blog });
db.Users.First().Articles.Add(new Article { Title = "Why you should learn POSTGRES instead of entity framework", Blog = blog });

db.SaveChanges();

Console.WriteLine(db.Articles.First().User.Articles.First().Blog.Articles.First().Title);




