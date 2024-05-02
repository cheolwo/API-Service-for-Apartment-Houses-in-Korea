using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.소독비;
namespace 국토교통부_공공데이터Common.공용관리비_정보제공서비스.MappingProfile
{
    public class 소독비MappingProfile : Profile
    {
        public 소독비MappingProfile()
        {
            CreateMap<Item, 공용관리비>()
                .ForMember(dest => dest.소독비, opt =>
                {
                    opt.Condition(src => src.DisinfCost != 0); ; // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.DisinfCost);
                });
        }
    }

}
