using MediatR;

namespace 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스.RequestModel
{
    public class 공동주택기본정보Request : IRequest<Unit>
    {
        public string? kaptCode { get; set; }
    }
    public class 공동주택상세정보Request : IRequest<Unit>
    {
        public string? kaptCode { get; set; }
    }
}
