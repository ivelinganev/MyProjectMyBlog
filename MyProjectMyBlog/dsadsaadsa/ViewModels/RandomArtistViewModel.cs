using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyProjectMyBlog.Models;

namespace MyProjectMyBlog.ViewModels
{
    public class RandomArtistViewModel
    {
        public Artists Artist { get; set; }
        public List<Customer> Customers { get; set; }
    }
}