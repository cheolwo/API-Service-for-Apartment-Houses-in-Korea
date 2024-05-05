using AutoMapper;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스.기본정보.ResponseModel;

namespace 국토교통부_공공데이터Common.MappingProfile
{
    public class 공동주택기본정보MappingProfile : Profile
    {
        public 공동주택기본정보MappingProfile()
        {
            CreateMap<공동주택기본정보Item, 공동주택>()
            .ForMember(dest => dest.법정동주소, opt =>
            {
                opt.PreCondition(src => src.KaptName != null);
                opt.MapFrom(src => src.KaptName);
            })
            .ForMember(dest => dest.분양형태, opt =>
            {
                opt.PreCondition(src => src.CodeSaleNm != null);
                opt.MapFrom(src => src.CodeSaleNm);
            })
            .ForMember(dest => dest.난방방식, opt =>
            {
                opt.PreCondition(src => src.CodeHeatNm != null);
                opt.MapFrom(src => src.CodeHeatNm);
            })
            .ForMember(dest => dest.건축물대장상연면적, opt =>
            {
                opt.PreCondition(src => src.KaptTarea != 0);
                opt.MapFrom(src => src.KaptTarea);
            })
            .ForMember(dest => dest.동수, opt =>
            {
                opt.PreCondition(src => src.KaptDongCnt != 0);
                opt.MapFrom(src => src.KaptDongCnt);
            })
            .ForMember(dest => dest.세대수, opt =>
            {
                opt.PreCondition(src => src.KaptdaCnt != 0);
                opt.MapFrom(src => src.KaptdaCnt);
            })
            .ForMember(dest => dest.시공사, opt =>
            {
                opt.PreCondition(src => src.KaptBcompany != null);
                opt.MapFrom(src => src.KaptBcompany);
            })
            .ForMember(dest => dest.시행사, opt =>
            {
                opt.PreCondition(src => src.KaptAcompany != null);
                opt.MapFrom(src => src.KaptAcompany);
            })
            .ForMember(dest => dest.관리사무소연락처, opt =>
            {
                opt.PreCondition(src => src.KaptTel != null);
                opt.MapFrom(src => src.KaptTel);
            })
            .ForMember(dest => dest.관리사무소팩스, opt =>
            {
                opt.PreCondition(src => src.KaptFax != null);
                opt.MapFrom(src => src.KaptFax);
            })
            .ForMember(dest => dest.홈페이지주소, opt =>
            {
                opt.PreCondition(src => src.KaptUrl != null);
                opt.MapFrom(src => src.KaptUrl);
            })
            .ForMember(dest => dest.단지분류, opt =>
            {
                opt.PreCondition(src => src.CodeAptNm != null);
                opt.MapFrom(src => src.CodeAptNm);
            })
            .ForMember(dest => dest.도로명주소, opt =>
            {
                opt.PreCondition(src => src.DoroJuso != null);
                opt.MapFrom(src => src.DoroJuso);
            })
            .ForMember(dest => dest.호수, opt =>
            {
                opt.PreCondition(src => src.HoCnt != 0);
                opt.MapFrom(src => src.HoCnt);
            })
            .ForMember(dest => dest.관리방식, opt =>
            {
                opt.PreCondition(src => src.CodeMgrNm != null);
                opt.MapFrom(src => src.CodeMgrNm);
            })
            .ForMember(dest => dest.복도유형, opt =>
            {
                opt.PreCondition(src => src.CodeHallNm != null);
                opt.MapFrom(src => src.CodeHallNm);
            })
            .ForMember(dest => dest.사용승인일, opt =>
            {
                opt.PreCondition(src => src.KaptUsedate != null);
                opt.MapFrom(src => src.KaptUsedate);
            })
            .ForMember(dest => dest.관리비부과면적, opt =>
            {
                opt.PreCondition(src => src.KaptMarea != 0);
                opt.MapFrom(src => src.KaptMarea);
            })
            .ForMember(dest => dest.전용면적별세대현황_60이하, opt =>
            {
                opt.PreCondition(src => src.KaptMparea_60 != 0);
                opt.MapFrom(src => src.KaptMparea_60);
            })
            .ForMember(dest => dest.전용면적별세대현황_60_85, opt =>
            {
                opt.PreCondition(src => src.KaptMparea_85 != 0);
                opt.MapFrom(src => src.KaptMparea_85);
            })
            .ForMember(dest => dest.전용면적별세대현황_85_135, opt =>
            {
                opt.PreCondition(src => src.KaptMparea_135 != 0);
                opt.MapFrom(src => src.KaptMparea_135);
            })
            .ForMember(dest => dest.전용면적별세대현황_135초과, opt =>
            {
                opt.PreCondition(src => src.KaptMparea_136 != 0);
                opt.MapFrom(src => src.KaptMparea_136);
            })
            .ForMember(dest => dest.대장전용면적합계, opt =>
            {
                opt.PreCondition(src => src.PrivArea != 0);
                opt.MapFrom(src => src.PrivArea);
            });
        }
    }
}
