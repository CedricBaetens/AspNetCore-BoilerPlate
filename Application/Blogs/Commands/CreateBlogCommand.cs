using System.Threading;
using System.Threading.Tasks;
using Application.Blogs.Notifications;
using Application.Interfaces;
using Domain.Blogs;
using Framework.Application;
using Framework.Common;
using Infrastructure.Interfaces;
using MediatR;

namespace Application.Blogs.Commands
{
    public class CreateBlogCommand : ICommand
    {
        
    }
    
    public class CreateBlogCommandHandler : ICommandHandler<CreateBlogCommand>
    {
        private readonly IMediator _mediator;
        private readonly IBlogRepository _blogRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CreateBlogCommandHandler(IMediator mediator, IBlogRepository blogRepository, IUnitOfWork unitOfWork)
        {
            _mediator = mediator;
            _blogRepository = blogRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            await _blogRepository.AddAsync(new Blog());
            
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            
            await _mediator.Publish(new CreatedBlogNotification(), cancellationToken);

            return Result.Success();
        }
    }
}