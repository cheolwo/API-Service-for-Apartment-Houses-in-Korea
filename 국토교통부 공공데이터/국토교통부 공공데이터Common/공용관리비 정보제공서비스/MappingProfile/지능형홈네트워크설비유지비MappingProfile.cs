using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.지능형홈네트워크설비유지비;
namespace 국토교통부_공공데이터Common.공용관리비_정보제공서비스.MappingProfile
{
    public class 지능형홈네트워크설비유지비MappingProfile : Profile
    {
        public 지능형홈네트워크설비유지비MappingProfile()
        {
            CreateMap<Item, 공용관리비>()
                .ForMember(dest => dest.지능형홈네트워크설비유지비, opt =>
                {
                    opt.Condition(src => src.HnetwCost != 0); ; // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.HnetwCost);
                });
        }
    }

}
