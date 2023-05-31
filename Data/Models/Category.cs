using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public partial class Category
    {
        public Category() { }
       
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        //public virtual ICollection<Book> Books { get; set; }
    }
}
