using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.정화조오물수수료;
namespace 국토교통부_공공데이터Common.MappingProfile
{
    public class 정화조오물수수료MappingProfile : Profile
    {
        public 정화조오물수수료MappingProfile()
        {
            CreateMap<Item, 개별사용료>()
                .ForMember(dest => dest.정화조오물수수료, opt =>
                {
                    opt.Condition(src => src.Purifi != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.Purifi);
                });
        }
    }
}
