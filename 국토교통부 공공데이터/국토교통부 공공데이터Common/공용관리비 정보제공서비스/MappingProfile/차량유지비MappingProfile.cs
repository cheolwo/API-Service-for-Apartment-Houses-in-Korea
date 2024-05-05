using AutoMapper;
using 국토교통부_공공데이터Common.Model.ComplexExpense;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.차량유지비;
namespace 국토교통부_공공데이터Common.MappingProfile
{
    public class 차량유지비MappingProfile : Profile
    {
        public 차량유지비MappingProfile()
        {
            CreateMap<Item, 차량유지비>()
                 .ForMember(dest => dest.연료비, opt =>
                 {
                     opt.Condition(src => src.FuelCost != 0); // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.FuelCost);
                 })
                 .ForMember(dest => dest.수리비, opt =>
                 {
                     opt.Condition(src => src.RefairCost != 0); // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.RefairCost);
                 })
                 .ForMember(dest => dest.보험료, opt =>
                 {
                     opt.Condition(src => src.CarInsurance != 0); // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.CarInsurance);
                 })
                 .ForMember(dest => dest.기타차량유지비, opt =>
                 {
                     opt.Condition(src => src.CarEtc != 0); // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.CarEtc);
                 });
        }
    }

}
