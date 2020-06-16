using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dono.Models
{
    public class Listings
    {
        public int Id { get; set;}
        public string Title { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public DateTime DatePosted { get; set; }
        public string Location { get; set; }
        public string UserId { get; set; }

    }
}
