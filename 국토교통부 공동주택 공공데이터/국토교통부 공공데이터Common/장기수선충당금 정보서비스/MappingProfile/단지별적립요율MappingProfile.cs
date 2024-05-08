using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.장기수선충당금_정보서비스.ResponseModel.적립요율;

namespace 국토교통부_공공데이터Common.MappingProfile
{
    public class 단지별적립요율MappingProfile : Profile
    {
        public 단지별적립요율MappingProfile()
        {
            CreateMap<Item, 장기수선충당금>()
                 .ForMember(dest => dest.적립요율, opt =>
                 {
                     opt.Condition(src => src.SPer != 0); ; // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.SPer);
                 });
        }
    }
}
