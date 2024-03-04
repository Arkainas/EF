using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entityframework_komplettering;

public class DB : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Blog> Blogs { get; set; }

    public string DbPath { get; }

    public DB()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");

    }
    protected override void OnConfiguring(DbContextOptionsBuilder options) =>

        options.UseSqlite($"Data Source ={DbPath}");
}

