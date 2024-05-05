using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스.ResponseModel.단지에너지사용량;
namespace 국토교통부_공공데이터Common.에너지사용정보_정보서비스.MappingProfile
{
    public class 단지에너지사용량MappingProfile : Profile
    {
        public 단지에너지사용량MappingProfile()
        {
            CreateMap<Item, 에너지사용정보>()
                 .ForMember(dest => dest.난방사용금액, opt =>
                 {
                     opt.Condition(src => src.Heat != 0); ; // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.Heat);
                 })
                 .ForMember(dest => dest.난방사용량, opt =>
                 {
                     opt.Condition(src => src.HHeat != 0); ; // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.HHeat);
                 })
                 .ForMember(dest => dest.급탕사용금액, opt =>
                 {
                     opt.Condition(src => src.WaterHot != 0); ; // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.WaterHot);
                 })
                 .ForMember(dest => dest.급탕사용량, opt =>
                 {
                     opt.Condition(src => src.HWaterHot != 0); ; // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.HWaterHot);
                 })
                 .ForMember(dest => dest.가스사용금액, opt =>
                 {
                     opt.Condition(src => src.Gas != 0); ; // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.Gas);
                 })
                 .ForMember(dest => dest.가스사용량, opt =>
                 {
                     opt.Condition(src => src.HGas != 0); ; // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.HGas);
                 })
                 .ForMember(dest => dest.전기사용금액, opt =>
                 {
                     opt.Condition(src => src.Elect != 0); ; // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.Elect);
                 })
                 .ForMember(dest => dest.전기사용량, opt =>
                 {
                     opt.Condition(src => src.HElect != 0); ; // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.HElect);
                 })
                 .ForMember(dest => dest.수도사용금액, opt =>
                 {
                     opt.Condition(src => src.WaterCool != 0); ; // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.WaterCool);
                 })
                 .ForMember(dest => dest.수도사용량, opt =>
                 {
                     opt.Condition(src => src.HWaterCool != 0); ; // 값이 0이 아닌 경우에만 매핑
                     opt.MapFrom(src => src.HWaterCool);
                 });
        }
    }
}
