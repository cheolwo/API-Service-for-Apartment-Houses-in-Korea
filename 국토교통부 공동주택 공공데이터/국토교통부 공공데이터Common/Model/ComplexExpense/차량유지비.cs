using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.Model.ComplexExpense
{
    public class 차량유지비
    {
        [XmlElement("fuelCost")]
        public long 연료비 { get; set; } // 연료비, 크기: 22, 필수

        [XmlElement("refairCost")]
        public long 수리비 { get; set; } // 수리비, 크기: 22, 필수

        [XmlElement("carInsurance")]
        public long 보험료 { get; set; } // 보험료, 크기: 22, 필수

        [XmlElement("carEtc")]
        public long 기타차량유지비 { get; set; } // 기타 차량 유지비, 크기: 22, 필수
    }
}