using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyProjectMyBlog.Models
{
    public class Post
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Artist { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        //[Required]
        //[StringLength(2000)]
        //public string Body { get; set; }

        //public string Link { get; set; }

        [Required]
        public string Body { get; set; }
        

        [Required]
        public DateTime Date { get; set; }

        public ApplicationUser Auhtor { get; set; }

        public int?  CommentsCount { get; set; }



    }
}