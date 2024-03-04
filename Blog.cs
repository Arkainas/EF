using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframework_komplettering;
public class Blog
{
    public int? BlogID { get; set; }
    public string? Name { get; set; }

    public List<Article> Articles { get; } = new();
}
