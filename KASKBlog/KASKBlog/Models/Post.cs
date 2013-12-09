using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KASKBlog.Models
{
    public class Post
    {
        // [Key] means that ID is the primary key in the database
        [Key] public int ID { get; set; }

        // [Required] means that this item is required when creating/editing/updating related information.
        [Required]
        public string Title { get; set; }

        // [Required] means that this item is required when creating/editing/updating related information.
        [Required]
        public string Body { get; set; }
    }
}