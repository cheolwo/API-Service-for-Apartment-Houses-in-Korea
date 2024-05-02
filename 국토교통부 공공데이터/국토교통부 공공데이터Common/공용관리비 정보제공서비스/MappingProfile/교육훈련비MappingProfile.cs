using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.교육훈련비;
namespace 국토교통부_공공데이터Common.공용관리비_정보제공서비스.MappingProfile
{
    public class 교육훈련비MappingProfile : Profile
    {
        public 교육훈련비MappingProfile()
        {
            CreateMap<Item, 공용관리비>()
                .ForMember(dest => dest.교육훈련비, opt =>
                {
                    opt.Condition(src => src.EduCost != 0); ; // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.EduCost);
                });
        }
    }

}
