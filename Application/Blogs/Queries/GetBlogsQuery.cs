using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Blogs.Models;
using Application.Blogs.Services;
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
        private readonly IBlogService _blogService;
        public GetBlogsQueryHandler(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IEnumerable<BlogDto>> Handle(GetBlogsQuery request, CancellationToken cancellationToken)
        {
            var result = await _blogService.GetAll();

            return result;
        }
    }
}