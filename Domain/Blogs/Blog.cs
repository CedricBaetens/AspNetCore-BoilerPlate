using System;
using System.Collections.Generic;
using Framework.Domain;

namespace Domain.Blogs
{
    public class Blog : Entity
    {
        public string Url { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }
}