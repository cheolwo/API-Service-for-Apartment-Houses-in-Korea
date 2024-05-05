using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.위탁관리수수료;
namespace 국토교통부_공공데이터Common.MappingProfile
{
    public class 위탁관리수수료MappingProfile : Profile
    {
        public 위탁관리수수료MappingProfile()
        {
            CreateMap<Item, 공용관리비>()
                .ForMember(dest => dest.위탁관리수수료, opt =>
                {
                    opt.Condition(src => src.ManageCost != 0); ; // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.ManageCost);
                });
        }
    }

}
