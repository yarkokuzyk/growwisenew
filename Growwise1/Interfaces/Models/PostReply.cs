﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Growwise.Data.Models
{
    public class PostReply
    {

        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Post Post { get; set; }
    }
}
