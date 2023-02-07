using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public partial class Reader
    {
        public Reader()
        {

        }

        public int ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string DNI { get; set; }

    }
}
