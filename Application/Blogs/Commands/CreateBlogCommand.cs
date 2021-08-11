using System.Threading;
using System.Threading.Tasks;
using Application.Blogs.Notifications;
using Framework.Application;
using Framework.Common;
using MediatR;

namespace Application.Blogs.Commands
{
    public class CreateBlogCommand : ICommand
    {
        
    }
    
    public class CreateBlogCommandHandler : ICommandHandler<CreateBlogCommand>
    {
        private readonly IMediator _mediator;
        public CreateBlogCommandHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IResult> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Publish(new CreatedBlogNotification());

            return Result.Success();
        }
    }
}