using MediatR;
using Quartz;

namespace 국토교통부_공공데이터Common.BatchService
{
    public class 공동주택InitializeBatchService : IJob
    {
        private readonly IMediator _mediator;
        public 공동주택InitializeBatchService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
