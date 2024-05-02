using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.제사무비;
namespace 국토교통부_공공데이터Common.공용관리비_정보제공서비스.MappingProfile
{
    public class 제사무비MappingProfile : Profile
    {
        public 제사무비MappingProfile()
        {
            CreateMap<Item, 공용관리비>()
                .ForMember(dest => dest.제사무비.교통비, opt =>
                {
                    opt.Condition(src => src.TransportCost != 0); ; // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.TransportCost);
                })
                .ForMember(dest => dest.제사무비.도서및인쇄비, opt =>
                {
                    opt.Condition(src => src.BookSupply != 0); ; // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.BookSupply);
                })
                .ForMember(dest => dest.제사무비.사무용품비용, opt =>
                {
                    opt.Condition(src => src.OfficeSupply != 0); ; // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.OfficeSupply);
                });
        }
    }

}
