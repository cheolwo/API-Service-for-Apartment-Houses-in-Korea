using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.인건비;
namespace 국토교통부_공공데이터Common.공용관리비_정보제공서비스.MappingProfile
{
    public class 인건비MappingProfile : Profile
    {
        public 인건비MappingProfile()
        {
            CreateMap<Item, 공용관리비>()
                .ForMember(dest => dest.인건비.건강보험료, opt =>
                {
                    opt.Condition(src => src.HealthPremium != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.HealthPremium);
                })
                .ForMember(dest => dest.인건비.고용보험료, opt =>
                {
                    opt.Condition(src => src.EmployPremium != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.EmployPremium);
                })
                .ForMember(dest => dest.인건비.국민연금, opt =>
                {
                    opt.Condition(src => src.NationalPension != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.NationalPension);
                })
                .ForMember(dest => dest.인건비.급여, opt =>
                {
                    opt.Condition(src => src.Pay != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.Pay);
                })
                .ForMember(dest => dest.인건비.산재보험료, opt =>
                {
                    opt.Condition(src => src.AccidentPremium != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.AccidentPremium);
                })
                .ForMember(dest => dest.인건비.상여금, opt =>
                {
                    opt.Condition(src => src.Bonus != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.Bonus);
                })
                .ForMember(dest => dest.인건비.식대등복리후생비, opt =>
                {
                    opt.Condition(src => src.WelfareBenefit != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.WelfareBenefit);
                })
                .ForMember(dest => dest.인건비.제수당, opt =>
                {
                    opt.Condition(src => src.SundryCost != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.SundryCost);
                })
                .ForMember(dest => dest.인건비.퇴직금, opt =>
                {
                    opt.Condition(src => src.Pension != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.Pension);
                });
        }
    }

}
