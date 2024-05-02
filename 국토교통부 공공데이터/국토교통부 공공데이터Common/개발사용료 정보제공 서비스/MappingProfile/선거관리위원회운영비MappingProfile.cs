using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.선거관리위원회운영비;

public class 선거관리위원회운영비MappingProfile : Profile
{
    public 선거관리위원회운영비MappingProfile()
    {
        CreateMap<Item, 개별사용료>()
            .ForMember(dest => dest.가스공용금액, opt =>
            {
                opt.Condition(src => src.ElectionMng != 0); // 값이 0이 아닌 경우에만 매핑
                opt.MapFrom(src => src.ElectionMng);
            });
    }
}
