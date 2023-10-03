using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_DevCreed.Models
{
   // [Index(nameof(Title))]
    public class Post
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Content { get; set; }

        //public string Descriptionkey { get; set; }
        //public int BLogkey { get; set; }
        //public Blog Blog { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public List<PostTag> PostTags { get; set; }
        public override string ToString()
        {
            return $"{Id}: {Title}: {Content}";
        }
    }
}
