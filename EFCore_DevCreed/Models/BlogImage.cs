using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_DevCreed.Models
{
    public class BlogImage
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Caption { get; set; }
        public int BlogKey { get; set; }

        public Blog Blog { get; set; }
    }
}
