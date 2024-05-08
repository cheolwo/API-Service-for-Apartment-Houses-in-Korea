using MediatR;

namespace 국토교통부_공공데이터Common.공동주택_단지_목록제공_서비스
{
    public class 공동주택단지Request : IRequest<Unit>
    {
        public int sidoCode;

        public int pageNo = 1;

        public int numOfRows = 10;
    }
}
