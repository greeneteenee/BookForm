using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookForm.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Display(Name ="Book Title")]
        public string BookTitle { get; set; }

        public string Author { get; set; }

        [Display(Name ="ISBN")]
        public string Isbn { get; set; }

        [Display(Name ="Publication Date")]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }


    }
}
