using AutoMapper;
using 국토교통부_공공데이터Common.Model.ComplexExpense;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.제사무비;
namespace 국토교통부_공공데이터Common.공용관리비_정보제공서비스.MappingProfile
{
    public class 제사무비MappingProfile : Profile
    {
        public 제사무비MappingProfile()
        {
            CreateMap<Item, 제사무비>()
                .ForMember(dest => dest.사무용품비용, opt =>
                {
                    opt.Condition(src => src.OfficeSupply != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.OfficeSupply);
                })
                .ForMember(dest => dest.도서및인쇄비, opt =>
                {
                    opt.Condition(src => src.BookSupply != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.BookSupply);
                })
                .ForMember(dest => dest.교통비, opt =>
                {
                    opt.Condition(src => src.TransportCost != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.TransportCost);
                });
        }
    }
}
