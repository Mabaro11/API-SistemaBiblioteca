using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public partial class Book
    {
        public Book()
        {

        }

        public int ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        public string Editorial { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Author { get; set; }
        public string CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public bool availability { get; set; }

    }
}
