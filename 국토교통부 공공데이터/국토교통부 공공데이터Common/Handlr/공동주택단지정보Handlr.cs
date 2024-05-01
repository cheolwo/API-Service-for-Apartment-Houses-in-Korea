using MediatR;
using 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스;
using 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스.RequestModel;

namespace 국토교통부_공공데이터Common.Handlr
{
    public class 공동주택단지정보Handlr : IRequestHandler<공동주택상세정보Request>
    {
        private readonly 공동주택DbContext _context;
        private readonly 공동주택단지정보APIService _APIService;
        public 공동주택단지정보Handlr(공동주택DbContext context, 공동주택단지정보APIService aPIService)
        {
            _context = context;
            _APIService = aPIService;
        }

        public Task Handle(공동주택상세정보Request request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
