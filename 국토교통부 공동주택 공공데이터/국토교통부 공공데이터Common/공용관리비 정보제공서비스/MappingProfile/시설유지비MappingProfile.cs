﻿using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.시설유지비;
namespace 국토교통부_공공데이터Common.MappingProfile
{
    public class 시설유지비MappingProfile : Profile
    {
        public 시설유지비MappingProfile()
        {
            CreateMap<Item, 공용관리비>()
                .ForMember(dest => dest.시설유지비, opt =>
                {
                    opt.Condition(src => src.LrefCost2 != 0); ; // 값이 0이 아닌 경우에만 매핑
                    opt.MapFrom(src => src.LrefCost2);
                });
        }
    }

}
