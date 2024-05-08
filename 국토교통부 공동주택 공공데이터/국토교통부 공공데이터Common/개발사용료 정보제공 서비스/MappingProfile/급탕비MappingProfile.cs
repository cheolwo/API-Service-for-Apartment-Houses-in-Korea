using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.급탕비;

namespace 국토교통부_공공데이터Common.MappingProfile
{
    public class 급탕비MappingProfile : Profile
    {
        public 급탕비MappingProfile()
        {
            CreateMap<Item, 개별사용료>()
                .ForMember(dest => dest.급탕공용금액, opt =>
                {
                    opt.Condition(src => src.WaterHotC != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.WaterHotC);
                })
                .ForMember(dest => dest.급탕전용금액, opt =>
                {
                    opt.Condition(src => src.WaterHotC != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.WaterHotP);
                });
        }
    }
}
