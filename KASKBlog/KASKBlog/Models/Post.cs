﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KASKBlog.Models
{
    public class Post
    {
        [Key] public int ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}