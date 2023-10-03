using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_DevCreed.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required] 
        public string Url { get; set; }
       
        public decimal Price { get; set; }
        public string description { get; set; }
        public List<Post> Posts { get; set; }



        //public BlogImage BlogImage { get; set; }
        public override string ToString()
        {
            return $"{Id}: {Url}";
        }
    }
}
