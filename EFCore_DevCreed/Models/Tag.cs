using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_DevCreed.Models
{
    public class Tag
    {
        public int TagId { get; set; }

        public ICollection<Post> posts { get; set; }
        public List<PostTag> postTags { get; set; }
    }

    public class PostTag
    {
        public int PostId { get; set; }
        public Post post { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
