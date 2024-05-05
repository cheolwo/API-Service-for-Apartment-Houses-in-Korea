using AutoMapper;
using 국토교통부_공공데이터Common.Model.ComplexExpense;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.기타부대비용;

namespace 국토교통부_공공데이터Common.MappingProfile
{
    public class 기타부대비용MappingProfile : Profile
    {
        public 기타부대비용MappingProfile()
        {
            CreateMap<Item, 기타부대비용>()
                .ForMember(dest => dest.관리용품구입비, opt =>
                {
                    opt.Condition(src => src.CareItemCost != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.CareItemCost);
                })
                .ForMember(dest => dest.전문가자문비, opt =>
                {
                    opt.Condition(src => src.AccountingCost != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.AccountingCost);
                })
                .ForMember(dest => dest.잡비, opt =>
                {
                    opt.Condition(src => src.HiddenCost != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.HiddenCost);
                });
        }
    }
}
