using Framework.Common;
using MediatR;

namespace Framework.Application
{
    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand, IResult> where TCommand : ICommand
    {
        
    }
}