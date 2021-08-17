using Application.Blogs.Models;
using AutoMapper;
using Domain.Blogs;

namespace Application.Blogs.Profiles
{
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            CreateMap<Blog, BlogDto>();
        }
    }
}