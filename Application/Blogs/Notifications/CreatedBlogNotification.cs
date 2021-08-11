using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Application.Blogs.Notifications
{
    public class CreatedBlogNotification : INotification
    {
        
    }

    public class Test : INotificationHandler<CreatedBlogNotification>
    {
        public Task Handle(CreatedBlogNotification notification, CancellationToken cancellationToken)
        {
            return  Task.CompletedTask;
        }
    }
}