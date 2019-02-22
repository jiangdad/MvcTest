using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Director
    {
        public Director()
        {
            //Movie = new HashSet<Movie>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Movie> Movie { get; set; }
    }
}