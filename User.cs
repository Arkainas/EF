﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframework_komplettering;

public class User
{
    public int? UserID { get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }
    public List<Article> Articles { get; } = new();
    
}
