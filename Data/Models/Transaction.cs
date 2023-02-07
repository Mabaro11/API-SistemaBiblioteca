using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public partial class Transaction
    {
        public int ID { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int BookID { get; set; }
        public virtual Book Book { get; set; }
        public int ReaderID { get; set; }
        public virtual Reader Reader { get; set; }
    }
}
