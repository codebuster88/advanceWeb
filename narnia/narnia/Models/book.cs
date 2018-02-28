using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace narnia.Models
{
    public class book
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Isbn { get; set; }
        public string Synopsis { get; set; }
        public string ImageUrl { get; set; }
        public virtual author Author { get; set; }
    }
}