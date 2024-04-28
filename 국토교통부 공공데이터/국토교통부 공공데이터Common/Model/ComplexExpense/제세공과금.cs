using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.Model.ComplexExpense
{
    public class 제세공과금
    {
        [XmlElement("elecCost")]
        public int 전기비용 { get; set; } // 전기 비용

        [XmlElement("postageCost")]
        public int 우편비용 { get; set; } // 우편 비용

        [XmlElement("taxrestCost")]
        public int 세금및기타비용 { get; set; } // 세금 및 기타 비용

        [XmlElement("telCost")]
        public int 전화비용 { get; set; } // 전화 비용
    }
}