using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.장기수선충당금_정보서비스.ResponseModel.월사용액;

namespace 국토교통부_공공데이터Common.장기수선충당금_정보서비스.MappingProfile
{
    public class 단지별사용액MappingProfile : Profile
    {
        public 단지별사용액MappingProfile()
        {
            CreateMap<Item, 장기수선충당금>()
                 .ForMember(dest => dest.월사용액, opt =>
                 {
                     opt.Condition(src => src.SUse != 0); ; // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.SUse);
                 });
        }
    }
}
