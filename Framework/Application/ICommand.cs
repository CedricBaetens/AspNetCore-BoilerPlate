using Framework.Common;
using MediatR;

namespace Framework.Application
{
    public interface ICommand : IRequest<Result>
    {
        
    }
}