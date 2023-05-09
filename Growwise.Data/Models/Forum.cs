using System;
using System.Collections.Generic;
using System.Text;

namespace Growwise.Data.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string ImageURL { get; set; }

        public IEnumerable<Post> Posts { get; set; }

    }
}
