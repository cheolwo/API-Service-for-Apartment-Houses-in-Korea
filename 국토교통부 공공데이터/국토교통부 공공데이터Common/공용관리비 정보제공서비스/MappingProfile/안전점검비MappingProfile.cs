using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.안전점검비;
namespace 국토교통부_공공데이터Common.공용관리비_정보제공서비스.MappingProfile
{
    public class 안전점검비MappingProfile : Profile
    {
        public 안전점검비MappingProfile()
        {
            CreateMap<Item, 공용관리비>()
                .ForMember(dest => dest.안전점검비, opt =>
                {
                    opt.Condition(src => src.LrefCost3 != 0); ; // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.LrefCost3);
                });
        }
    }

}
