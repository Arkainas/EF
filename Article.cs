using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframework_komplettering;
public class Article
{
    public int? ArticleID { get; set; }
    public string? Title { get; set; }
    public int? UserID { get; set; }
    public User? User { get; set; }
    public int? BlogID { get; set; }
    public Blog? Blog { get; set; }
    public List<Category> Categories { get; } = new();
}

