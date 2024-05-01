using MediatR;

namespace 국토교통부_공공데이터Common.장기수선충당금_정보서비스
{
    public class 장기수선충당금Request : IRequest<Unit>
    {
        public string kaptCode = string.Empty;
        public string searchDate = string.Empty;
        public string serviceKey = string.Empty;
    }
}
