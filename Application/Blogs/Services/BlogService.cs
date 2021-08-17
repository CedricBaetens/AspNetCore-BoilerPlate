using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Blogs.Models;
using Application.Interfaces;
using AutoMapper;

namespace Application.Blogs.Services
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogDto>> GetAll();
    }
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;
        
        public BlogService(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }
        
        public async Task<IEnumerable<BlogDto>> GetAll()
        {
            var blogs = await _blogRepository.GetAllAsync();

            var result = _mapper.Map<IEnumerable<BlogDto>>(blogs);

            return result;
        }
    }
}