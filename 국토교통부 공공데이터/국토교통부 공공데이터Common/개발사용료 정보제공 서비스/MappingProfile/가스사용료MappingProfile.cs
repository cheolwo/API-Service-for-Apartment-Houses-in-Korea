using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.가스사용료;

namespace 국토교통부_공공데이터Common.MappingProfile
{
    public class 가스사용료MappingProfile : Profile
    {
        public 가스사용료MappingProfile()
        {
            CreateMap<Item, 개별사용료>()
                .ForMember(dest => dest.가스공용금액, opt => {
                    opt.Condition(src => src.GasC != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.GasC);
                })
                .ForMember(dest => dest.가스전용금액, opt => {
                    opt.Condition(src => src.GasP != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.GasP);
                });
        }
    }
}