using System;
using MediatR;
using Domain;
using System.Threading.Tasks;
using System.Threading;
using Persistence;

namespace Application.Activities
{
    public class ActivityDetails
    {
        public class Query : IRequest<Activity>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Activity>
        {
            private DataContext context;
            public Handler(DataContext context)
            {
                this.context = context;

            }
            public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
            {
                var requestedActivity = await this.context.Activities.FindAsync(request.Id);
                return requestedActivity;
            }
        }
    }
}