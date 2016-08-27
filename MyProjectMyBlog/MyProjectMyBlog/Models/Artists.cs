using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyProjectMyBlog.Models
{
    public class Artists
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Alias { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        public string BornIn { get; set; }

        public string Biography { get; set; }


    }
}