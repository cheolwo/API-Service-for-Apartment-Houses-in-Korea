using AutoMapper;
using 국토교통부_공공데이터Common.Model.ComplexExpense;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.인건비;
namespace 국토교통부_공공데이터Common.MappingProfile
{
    public class 인건비MappingProfile : Profile
    {
        public 인건비MappingProfile()
        {
            CreateMap<Item, 인건비>()
                .ForMember(dest => dest.급여, opt =>
                {
                    opt.Condition(src => src.Pay != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.Pay);
                })
                .ForMember(dest => dest.제수당, opt =>
                {
                    opt.Condition(src => src.SundryCost != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.SundryCost);
                })
                .ForMember(dest => dest.상여금, opt =>
                {
                    opt.Condition(src => src.Bonus != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.Bonus);
                })
                .ForMember(dest => dest.퇴직금, opt =>
                {
                    opt.Condition(src => src.Pension != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.Pension);
                })
                .ForMember(dest => dest.산재보험료, opt =>
                {
                    opt.Condition(src => src.AccidentPremium != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.AccidentPremium);
                })
                .ForMember(dest => dest.고용보험료, opt =>
                {
                    opt.Condition(src => src.EmployPremium != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.EmployPremium);
                })
                .ForMember(dest => dest.국민연금, opt =>
                {
                    opt.Condition(src => src.NationalPension != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.NationalPension);
                })
                .ForMember(dest => dest.건강보험료, opt =>
                {
                    opt.Condition(src => src.HealthPremium != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.HealthPremium);
                })
                .ForMember(dest => dest.식대등복리후생비, opt =>
                {
                    opt.Condition(src => src.WelfareBenefit != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.WelfareBenefit);
                });
        }
    }

}
