using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesMVC.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<AuthorBook> AurhorBooks { get; set; }

    }
}
