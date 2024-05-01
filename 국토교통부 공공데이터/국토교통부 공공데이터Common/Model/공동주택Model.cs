using Common.Model;
using System.Xml.Serialization;
using 국토교통부_공공데이터Common.Model.ComplexExpense;

namespace 국토교통부_공공데이터Common.Model
{
    public class 공동주택 : Center
    {
        [XmlElement("kaptCode")]
        public string 단지코드 { get; set; }
        [XmlElement("kaptName")]
        public string 단지명 { get; set; }
        [XmlElement("as1")]
        public string 시도 { get; set; }
        [XmlElement("as2")]
        public string 시군구 { get; set; }
        [XmlElement("as3")]
        public string 읍면동 { get; set; }
        [XmlElement("as4")]
        public string 리 { get; set; }
        [XmlElement("bjdCode")]
        public string 법정동코드 { get; set; }
        public List<개별사용료> 개별사용료목록 { get; set; }
        public List<에너지사용정보> 에너지사용목록 { get; set; }
        public List<공용관리비> 공용관리비목록 { get; set; }
        public List<장기수선충당금> 장기수선충당금목록 { get; set; }
    }
    public class 개별사용료 : Entity
    {
        public string? date { get; set; }
        [XmlElement("gasC")]
        public long 가스공용금액 { get; set; } // 가스 공용 금액, 크기: 22, 필수

        [XmlElement("gasP")]
        public long 가스전용금액 { get; set; } // 가스 전용 금액, 크기: 22, 필수
        [XmlElement("buildInsu")]
        public long 건물보험료 { get; set; } // 건물보험료, 크기: 22, 필수
        [XmlElement("waterHotC")]
        public long 급탕공용금액 { get; set; } // 급탕 공용 금액, 크기: 22, 필수

        [XmlElement("waterHotP")]
        public long 급탕전용금액 { get; set; } // 급탕 전용 금액, 크기: 22, 필수.
        [XmlElement("heatC")]
        public long 난방공용금액 { get; set; } // 난방 공용 금액, 크기: 22, 필수

        [XmlElement("heatP")]
        public long 난방전용금액 { get; set; } // 난방 전용 금액, 크기: 22, 필수
        [XmlElement("scrap")]
        public long 생활폐기물수수료 { get; set; } // 생활폐기물수수료, 크기: 22, 필수
        [XmlElement("electionMng")]
        public long 선거관리위원회운영비 { get; set; } // 선거관리위원회운영비, 크기: 22, 필수
        [XmlElement("waterCoolC")]
        public long 수도공용금액 { get; set; } // 수도 공용 금액, 크기: 22, 필수

        [XmlElement("waterCoolP")]
        public long 수도전용금액 { get; set; } // 수도 전용 금액, 크기: 22, 필수
        [XmlElement("preMeet")]
        public long 입주자대표회의운영비 { get; set; } // 입주자대표회의 운영비, 크기: 22, 필수
        [XmlElement("electC")]
        public long 전기공용금액 { get; set; } // 전기 공용 금액, 크기: 22, 필수

        [XmlElement("electP")]
        public long 전기전용금액 { get; set; } // 전기 전용 금액, 크기: 22, 필수
        [XmlElement("purifi")]
        public long 정화조오물수수료 { get; set; } // 정화조오물수수료, 크기: 22, 필수
        public Guid 공동주택Id { get; set; }
        public 공동주택 공동주택 { get; set; }
    }
    public class 공용관리비 : Entity
    {
        public string? date { get; set; }
        [XmlElement("guardCost")]
        public long 경비비 { get; set; }
        [XmlElement("eduCost")]
        public long 교육훈련비 { get; set; }
        [XmlElement("disinfCost")]
        public long 소독비 { get; set; }
        [XmlElement("lrefCost1")]
        public long 수선비 { get; set; }
        [XmlElement("elevCost")]
        public long 승강기유지비 { get; set; }
        [XmlElement("lrefCost2")]
        public long 시설유지비 { get; set; }
        [XmlElement("lrefCost3")]
        public long 안전점검비 { get; set; }
        [XmlElement("manageCost")]
        public long 위탁관리수수료 { get; set; }

        [XmlElement("lrefCost4")]
        public long 재해예방비 { get; set; }
        [XmlElement("hnetwCost")]
        public long 지능형홈네트워크설비유지비 { get; set; }
        [XmlElement("cleanCost")]
        public long 청소비 { get; set; }
        [XmlElement("clothesCost")]
        public long 피복비 { get; set; }
        public 인건비 인건비 { get; set; }
        public 제사무비 제사무비 { get; set; }
        public 제세공과금 제세공과금 { get; set; }
        public 차량유지비 차량유지비 { get; set; }
        public 기타부대비용 기타부대비용 { get; set; }
        public Guid 공동주택Id { get; set; }
        public 공동주택 공동주택 { get; set; }
    }
    public class 에너지사용정보 : Entity
    {
        public string date { get; set; }
        [XmlElement("heat")]
        public long 난방사용금액 { get; set; } // 난방사용금액, 크기: 22, 필수

        [XmlElement("hheat")]
        public long 난방사용량 { get; set; } // 난방사용량(Mcal), 크기: 22, 필수

        [XmlElement("waterHot")]
        public long 급탕사용금액 { get; set; } // 급탕사용금액, 크기: 22, 필수

        [XmlElement("hwaterHot")]
        public long 급탕사용량 { get; set; } // 급탕사용량(ton), 크기: 22, 필수

        [XmlElement("gas")]
        public long 가스사용금액 { get; set; } // 가스사용금액, 크기: 22, 필수

        [XmlElement("hgas")]
        public long 가스사용량 { get; set; } // 가스사용량(㎥), 크기: 22, 필수

        [XmlElement("elect")]
        public long 전기사용금액 { get; set; } // 전기사용금액, 크기: 22, 필수

        [XmlElement("helect")]
        public long 전기사용량 { get; set; } // 전기사용량(Kwh), 크기: 22, 필수

        [XmlElement("waterCool")]
        public long 수도사용금액 { get; set; } // 수도사용금액, 크기: 22, 필수

        [XmlElement("hwaterCool")]
        public long 수도사용량 { get; set; } // 수도사용량(㎥), 크기: 22, 필수
        public Guid 공동주택Id { get; set; }
        public 공동주택 공동주택 { get; set; }
    }
    public class 장기수선충당금 : Entity
    {
        public string date { get; set; }
        [XmlElement("SLevy")]
        public long 월부과액 { get; set; } // 월부과액, 크기: 22, 필수
        [XmlElement("SUse")]
        public long 월사용액 { get; set; } // 월사용액, 크기: 22, 필수
        [XmlElement("SPer")]
        public long 적립요율 { get; set; } // 적립요율(%), 크기: 22, 필수
        [XmlElement("STot")]
        public long 충당금잔액 { get; set; } // 충당금잔액, 크기: 22, 필수
        public Guid 공동주택Id { get; set; }
        public 공동주택 공동주택 { get; set; }
    }
}