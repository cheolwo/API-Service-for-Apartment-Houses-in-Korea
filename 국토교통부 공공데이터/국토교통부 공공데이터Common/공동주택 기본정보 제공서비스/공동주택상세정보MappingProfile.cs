using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스.상세정보.ResponseModel;

namespace 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스
{
    public class 공동주택상세정보MappingProfile : Profile
    {
        public 공동주택상세정보MappingProfile()
        {
            CreateMap<공동주택상세정보, 공동주택>()
                .ForMember(dest => dest.상세정보Data, opt => opt.MapFrom(src => src));
        }
    }   
}
