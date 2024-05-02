using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.수도료;

public class 수도료MappingProfile : Profile
{
    public 수도료MappingProfile()
    {
        CreateMap<Item, 개별사용료>()
            .ForMember(dest => dest.가스공용금액, opt => {
                opt.Condition(src => src.WaterCoolC != 0); // 값이 0이 아닌 경우에만 매핑
                opt.MapFrom(src => src.WaterCoolC);
            })
            .ForMember(dest => dest.가스전용금액, opt => {
                opt.Condition(src => src.WaterCoolP != 0); // 값이 0이 아닌 경우에만 매핑
                opt.MapFrom(src => src.WaterCoolP);
            });
    }
}
