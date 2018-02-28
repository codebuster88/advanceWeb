using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace narnia.Models
{
    public class author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public virtual ICollection<book> Books { get; set; }
    }
}