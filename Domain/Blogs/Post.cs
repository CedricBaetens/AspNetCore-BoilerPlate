using System;
using Framework.Domain;

namespace Domain.Blogs
{
    public class Post : Entity
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}