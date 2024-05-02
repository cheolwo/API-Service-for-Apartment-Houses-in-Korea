using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.난방비;

public class 난방비MappingProfile : Profile
{
    public 난방비MappingProfile()
    {
        CreateMap<Item, 개별사용료>()
            .ForMember(dest => dest.난방공용금액, opt => {
                opt.Condition(src => src.HeatC != 0); // 값이 0이 아닌 경우에만 매핑
                opt.MapFrom(src => src.HeatC);
            })
            .ForMember(dest => dest.난방전용금액, opt => {
                opt.Condition(src => src.HeatP != 0); // 값이 0이 아닌 경우에만 매핑
                opt.MapFrom(src => src.HeatP);
            });
    }
}
