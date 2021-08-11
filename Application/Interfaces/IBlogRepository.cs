using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Blogs;

namespace Application.Interfaces
{
    public interface IBlogRepository : IRepository<Blog>
    {
        
    }
}