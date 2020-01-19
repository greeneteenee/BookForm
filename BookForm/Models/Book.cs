using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookForm.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string BookTitle { get; set; }

        public string Author { get; set; }

        public string Isbn { get; set; }

        public DateTime PublicationDate { get; set; }


    }
}
