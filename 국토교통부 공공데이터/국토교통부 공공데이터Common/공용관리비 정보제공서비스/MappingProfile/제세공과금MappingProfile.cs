using AutoMapper;
using 국토교통부_공공데이터Common.Model.ComplexExpense;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.제세공과금;
namespace 국토교통부_공공데이터Common.공용관리비_정보제공서비스.MappingProfile
{
    public class 제세공과금MappingProfile : Profile
    {
        public 제세공과금MappingProfile()
        {
            CreateMap<Item, 제세공과금>()
                .ForMember(dest => dest.전기비용, opt =>
                {
                    opt.Condition(src => src.ElecCost != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.ElecCost);
                })
                .ForMember(dest => dest.우편비용, opt =>
                {
                    opt.Condition(src => src.PostageCost != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.PostageCost);
                })
                .ForMember(dest => dest.세금및기타비용, opt =>
                {
                    opt.Condition(src => src.TaxrestCost != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.TaxrestCost);
                })
                .ForMember(dest => dest.전화비용, opt =>
                {
                    opt.Condition(src => src.TelCost != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.TelCost);
                });
        }
    }
}
