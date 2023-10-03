using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_DevCreed.Models
{
    public class Book
    {
       // [Key]
        public int booknumber { get; set; }
        public string name { get; set; }
        public string author { get; set; }

    }
}
