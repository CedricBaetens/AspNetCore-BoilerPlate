using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Blogs.Models;
using Application.Interfaces;
using AutoMapper;
using Framework.Application;

namespace Application.Blogs.Queries
{
    public class GetBlogsQuery : IQuery<IEnumerable<BlogDto>>
    {
        
    }
    
    public class GetBlogsQueryHandler : IQueryHandler<GetBlogsQuery, IEnumerable<BlogDto>>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public GetBlogsQueryHandler( IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BlogDto>> Handle(GetBlogsQuery request, CancellationToken cancellationToken)
        {
            var blogs = await _blogRepository.GetAllAsync();

            var result = _mapper.Map<IEnumerable<BlogDto>>(blogs);

            return result;
        }
    }
}