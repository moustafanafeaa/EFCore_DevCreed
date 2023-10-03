using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_DevCreed.Models
{
    public class Author
    {
        public int Id { get; set; }


        [Required,MaxLength(30)]
        public string FName { get; set; }


        [Required, MaxLength(30)]
        public string LName { get; set; }
        //[Required,MaxLength(60)]
        //public string FullName {get; set; }

    }
}
