using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.입주자대표회의운영비;
namespace 국토교통부_공공데이터Common.MappingProfile
{
    public class 입주자대표회의운영비MappingProfile : Profile
    {
        public 입주자대표회의운영비MappingProfile()
        {
            CreateMap<Item, 개별사용료>()
                .ForMember(dest => dest.입주자대표회의운영비, opt =>
                {
                    opt.Condition(src => src.PreMeet != 0); // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.PreMeet);
                });
        }
    }
}
