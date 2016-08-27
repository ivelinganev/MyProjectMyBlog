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

        [Required]
        [DataType(DataType.MultilineText)]
        public string Lyrics { get; set; } //promqna tuk
        
        [Required]
        public DateTime Date { get; set; }

        public int?  CommentsCount { get; set; }

        public ApplicationUser Auhtor { get; set; }




    }
}