using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activities
{
    public class ActivityCollection
    {
        public class Query : IRequest<List<Activity>> {}

        
        public class Handler : IRequestHandler<Query, List<Activity>>
        {
            private readonly DataContext context;


            /// <summary>Initializes a new instance of the <see cref="Handler" /> class.</summary>
            /// <param name="context">The context of the data.</param>
            public Handler(DataContext context) => this.context = context;


            /// <summary>Handles a request</summary>
            /// <param name="request">The request</param>
            /// <param name="cancellationToken">Cancellation token</param>
            /// <returns>Response from the request</returns>
            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                
                var activities = await this.context.Activities.ToListAsync(cancellationToken: cancellationToken);
                return activities;
            }
        }
    }
}