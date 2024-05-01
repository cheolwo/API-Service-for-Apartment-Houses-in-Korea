using MediatR;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 국토교통부_공공데이터Common.BatchService
{
    public class 비용수집BatchService : IJob
    {
        private readonly IMediator _mediator;
        public 비용수집BatchService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
