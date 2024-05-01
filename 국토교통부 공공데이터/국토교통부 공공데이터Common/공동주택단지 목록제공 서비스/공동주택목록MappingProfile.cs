using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.공동주택_단지_목록제공_서비스.ResponseModel;
public class 공동주택목록MappingProfile : Profile
{
    public 공동주택목록MappingProfile()
    {
        CreateMap<Item, 공동주택>()
            .ForMember(dest => dest.단지명, opt =>
            {
                opt.PreCondition(src => src.KaptName != null);
                opt.MapFrom(src => src.KaptName);
            })
            .ForMember(dest => dest.단지코드, opt =>
            {
                opt.PreCondition(src => src.KaptCode != null);
                opt.MapFrom(src => src.KaptCode);
            })
            .ForMember(dest => dest.시도, opt =>
            {
                opt.PreCondition(src => src.As1 != null);
                opt.MapFrom(src => src.As1);
            })
            .ForMember(dest => dest.시군구, opt =>
            {
                opt.PreCondition(src => src.As2 != null);
                opt.MapFrom(src => src.As2);
            })
            .ForMember(dest => dest.읍면동, opt =>
            {
                opt.PreCondition(src => src.As3 != null);
                opt.MapFrom(src => src.As3);
            })
            .ForMember(dest => dest.리, opt =>
            {
                opt.PreCondition(src => src.As4 != null);
                opt.MapFrom(src => src.As4);
            })
            .ForMember(dest => dest.법정동코드, opt =>
            {
                opt.PreCondition(src => src.BjdCode != null);
                opt.MapFrom(src => src.BjdCode);
            });
    }
}