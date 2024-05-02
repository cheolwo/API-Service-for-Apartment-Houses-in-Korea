using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using 국토교통부_공공데이터Common.Model.ComplexExpense;
using 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스.상세정보.ResponseModel;

namespace 국토교통부_공공데이터Common.Model
{
    public class 공동주택
    {
        [Key]
        [XmlElement("kaptCode")]
        public string 단지코드 { get; set; }
        [XmlElement("kaptName")]
        public string 단지명 { get; set; }
        [XmlElement("as1")]
        public string? 시도 { get; set; }
        [XmlElement("as2")]
        public string? 시군구 { get; set; }
        [XmlElement("as3")]
        public string? 읍면동 { get; set; }
        [XmlElement("as4")]
        public string? 리 { get; set; }
        [XmlElement("bjdCode")]
        public string? 법정동코드 { get; set; }
        [XmlElement("kaptAddr")]
        public string? 법정동주소 { get; set; }

        [XmlElement("codeSaleNm")]
        public string? 분양형태 { get; set; }

        [XmlElement("codeHeatNm")]
        public string? 난방방식 { get; set; }

        [XmlElement("kaptTarea")]
        public double? 건축물대장상연면적 { get; set; }

        [XmlElement("kaptDongCnt")]
        public int? 동수 { get; set; }

        [XmlElement("kaptdaCnt")]
        public int? 세대수 { get; set; }

        [XmlElement("kaptBcompany")]
        public string? 시공사 { get; set; }

        [XmlElement("kaptAcompany")]
        public string? 시행사 { get; set; }

        [XmlElement("kaptTel")]
        public string? 관리사무소연락처 { get; set; }

        [XmlElement("kaptFax")]
        public string? 관리사무소팩스 { get; set; }

        [XmlElement("kaptUrl")]
        public string? 홈페이지주소 { get; set; }

        [XmlElement("codeAptNm")]
        public string? 단지분류 { get; set; }

        [XmlElement("doroJuso")]
        public string? 도로명주소 { get; set; }

        [XmlElement("hoCnt")]
        public int? 호수 { get; set; }

        [XmlElement("codeMgrNm")]
        public string? 관리방식 { get; set; }

        [XmlElement("codeHallNm")]
        public string? 복도유형 { get; set; }

        [XmlElement("kaptUsedate")]
        public string? 사용승인일 { get; set; }

        [XmlElement("kaptMarea")]
        public double? 관리비부과면적 { get; set; }

        [XmlElement("kaptMparea_60")]
        public double? 전용면적별세대현황_60이하 { get; set; }

        [XmlElement("kaptMparea_85")]
        public double? 전용면적별세대현황_60_85 { get; set; }

        [XmlElement("kaptMparea_135")]
        public double? 전용면적별세대현황_85_135 { get; set; }

        [XmlElement("kaptMparea_136")]
        public double? 전용면적별세대현황_135초과 { get; set; }

        [XmlElement("privArea")]
        public double? 대장전용면적합계 { get; set; }
        // JSON으로 저장될 상세정보
        public string? 상세정보;  // JSON 문자열로 저장, 외부 접근 제한

        [NotMapped]
        public 공동주택상세정보? 상세정보Data
        {
            get => string.IsNullOrEmpty(상세정보) ? null : JsonConvert.DeserializeObject<공동주택상세정보>(상세정보);
            set => 상세정보 = JsonConvert.SerializeObject(value);
        }
        public List<개별사용료>? 개별사용료목록 { get; set; }
        public List<에너지사용정보>? 에너지사용목록 { get; set; }
        public List<공용관리비>? 공용관리비목록 { get; set; }
        public List<장기수선충당금>? 장기수선충당금목록 { get; set; }
    }
    public class 개별사용료
    {
        public string? date { get; set; }
        [XmlElement("gasC")]
        public long? 가스공용금액 { get; set; } // 가스 공용 금액, 크기: 22, 필수

        [XmlElement("gasP")]
        public long? 가스전용금액 { get; set; } // 가스 전용 금액, 크기: 22, 필수
        [XmlElement("buildInsu")]
        public long? 건물보험료 { get; set; } // 건물보험료, 크기: 22, 필수
        [XmlElement("waterHotC")]
        public long? 급탕공용금액 { get; set; } // 급탕 공용 금액, 크기: 22, 필수

        [XmlElement("waterHotP")]
        public long? 급탕전용금액 { get; set; } // 급탕 전용 금액, 크기: 22, 필수.
        [XmlElement("heatC")]
        public long? 난방공용금액 { get; set; } // 난방 공용 금액, 크기: 22, 필수

        [XmlElement("heatP")]
        public long? 난방전용금액 { get; set; } // 난방 전용 금액, 크기: 22, 필수
        [XmlElement("scrap")]
        public long? 생활폐기물수수료 { get; set; } // 생활폐기물수수료, 크기: 22, 필수
        [XmlElement("electionMng")]
        public long? 선거관리위원회운영비 { get; set; } // 선거관리위원회운영비, 크기: 22, 필수
        [XmlElement("waterCoolC")]
        public long? 수도공용금액 { get; set; } // 수도 공용 금액, 크기: 22, 필수

        [XmlElement("waterCoolP")]
        public long? 수도전용금액 { get; set; } // 수도 전용 금액, 크기: 22, 필수
        [XmlElement("preMeet")]
        public long? 입주자대표회의운영비 { get; set; } // 입주자대표회의 운영비, 크기: 22, 필수
        [XmlElement("electC")]
        public long? 전기공용금액 { get; set; } // 전기 공용 금액, 크기: 22, 필수

        [XmlElement("electP")]
        public long? 전기전용금액 { get; set; } // 전기 전용 금액, 크기: 22, 필수
        [XmlElement("purifi")]
        public long? 정화조오물수수료 { get; set; } // 정화조오물수수료, 크기: 22, 필수
        [ForeignKey("공동주택")]
        public string 단지코드 { get; set; }
        public 공동주택? 공동주택 { get; set; }
    }
    public class 공용관리비
    {
        public string? date { get; set; }
        [XmlElement("guardCost")]
        public long? 경비비 { get; set; }
        [XmlElement("eduCost")]
        public long? 교육훈련비 { get; set; }
        [XmlElement("disinfCost")]
        public long? 소독비 { get; set; }
        [XmlElement("lrefCost1")]
        public long? 수선비 { get; set; }
        [XmlElement("elevCost")]
        public long? 승강기유지비 { get; set; }
        [XmlElement("lrefCost2")]
        public long? 시설유지비 { get; set; }
        [XmlElement("lrefCost3")]
        public long? 안전점검비 { get; set; }
        [XmlElement("manageCost")]
        public long? 위탁관리수수료 { get; set; }

        [XmlElement("lrefCost4")]
        public long? 재해예방비 { get; set; }
        [XmlElement("hnetwCost")]
        public long? 지능형홈네트워크설비유지비 { get; set; }
        [XmlElement("cleanCost")]
        public long? 청소비 { get; set; }
        [XmlElement("clothesCost")]
        public long? 피복비 { get; set; }
        // JSON으로 저장될 문자열
        public string? 인건비Json { get; set; }
        [NotMapped]
        public 인건비? 인건비
        {
            get => string.IsNullOrEmpty(인건비Json) ? null : JsonConvert.DeserializeObject<인건비>(인건비Json);
            set => 인건비Json = JsonConvert.SerializeObject(value);
        }

        public string? 제사무비Json { get; set; }

        [NotMapped]
        public 제사무비? 제사무비
        {
            get => string.IsNullOrEmpty(제사무비Json) ? null : JsonConvert.DeserializeObject<제사무비>(제사무비Json);
            set => 제사무비Json = JsonConvert.SerializeObject(value);
        }

        public string? 제세공과금Json { get; set; }

        [NotMapped]
        public 제세공과금? 제세공과금
        {
            get => string.IsNullOrEmpty(제세공과금Json) ? null : JsonConvert.DeserializeObject<제세공과금>(제세공과금Json);
            set => 제세공과금Json = JsonConvert.SerializeObject(value);
        }

        public string? 차량유지비Json { get; set; }

        [NotMapped]
        public 차량유지비? 차량유지비
        {
            get => string.IsNullOrEmpty(차량유지비Json) ? null : JsonConvert.DeserializeObject<차량유지비>(차량유지비Json);
            set => 차량유지비Json = JsonConvert.SerializeObject(value);
        }

        public string? 기타부대비용Json { get; set; }

        [NotMapped]
        public 기타부대비용? 기타부대비용
        {
            get => string.IsNullOrEmpty(기타부대비용Json) ? null : JsonConvert.DeserializeObject<기타부대비용>(기타부대비용Json);
            set => 기타부대비용Json = JsonConvert.SerializeObject(value);
        }
        [ForeignKey("공동주택")]
        public string 단지코드 { get; set; }
        public 공동주택 공동주택 { get; set; }
    }
    public class 에너지사용정보 
    {
        public string date { get; set; }
        [XmlElement("heat")]
        public long? 난방사용금액 { get; set; } // 난방사용금액, 크기: 22, 필수

        [XmlElement("hheat")]
        public long? 난방사용량 { get; set; } // 난방사용량(Mcal), 크기: 22, 필수

        [XmlElement("waterHot")]
        public long? 급탕사용금액 { get; set; } // 급탕사용금액, 크기: 22, 필수

        [XmlElement("hwaterHot")]
        public long? 급탕사용량 { get; set; } // 급탕사용량(ton), 크기: 22, 필수

        [XmlElement("gas")]
        public long? 가스사용금액 { get; set; } // 가스사용금액, 크기: 22, 필수

        [XmlElement("hgas")]
        public long? 가스사용량 { get; set; } // 가스사용량(㎥), 크기: 22, 필수

        [XmlElement("elect")]
        public long? 전기사용금액 { get; set; } // 전기사용금액, 크기: 22, 필수

        [XmlElement("helect")]
        public long? 전기사용량 { get; set; } // 전기사용량(Kwh), 크기: 22, 필수

        [XmlElement("waterCool")]
        public long? 수도사용금액 { get; set; } // 수도사용금액, 크기: 22, 필수

        [XmlElement("hwaterCool")]
        public long? 수도사용량 { get; set; } // 수도사용량(㎥), 크기: 22, 필수
        [ForeignKey("공동주택")]
        public string 단지코드 { get; set; }
        public 공동주택 공동주택 { get; set; }
    }
    public class 장기수선충당금
    {
        public string date { get; set; }
        [XmlElement("SLevy")]
        public long? 월부과액 { get; set; } // 월부과액, 크기: 22, 필수
        [XmlElement("SUse")]
        public long? 월사용액 { get; set; } // 월사용액, 크기: 22, 필수
        [XmlElement("SPer")]
        public long? 적립요율 { get; set; } // 적립요율(%), 크기: 22, 필수
        [XmlElement("STot")]
        public long? 충당금잔액 { get; set; } // 충당금잔액, 크기: 22, 필수
        [ForeignKey("공동주택")]
        public string 단지코드 { get; set; }
        public 공동주택 공동주택 { get; set; }
    }
}