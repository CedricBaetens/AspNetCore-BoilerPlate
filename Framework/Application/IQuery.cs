using MediatR;

namespace Framework.Application
{
    public interface IQuery<out TRespone> : IRequest<TRespone>
    {
        
    }
}