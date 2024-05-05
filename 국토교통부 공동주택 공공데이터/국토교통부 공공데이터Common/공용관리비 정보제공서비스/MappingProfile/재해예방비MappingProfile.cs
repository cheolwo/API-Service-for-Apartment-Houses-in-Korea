using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.재해예방비;
namespace 국토교통부_공공데이터Common.MappingProfile
{
    public class 재해예방비MappingProfile : Profile
    {
        public 재해예방비MappingProfile()
        {
            CreateMap<Item, 공용관리비>()
                .ForMember(dest => dest.재해예방비, opt =>
                {
                    opt.Condition(src => src.LrefCost4 != 0); ; // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.LrefCost4);
                });
        }
    }

}
