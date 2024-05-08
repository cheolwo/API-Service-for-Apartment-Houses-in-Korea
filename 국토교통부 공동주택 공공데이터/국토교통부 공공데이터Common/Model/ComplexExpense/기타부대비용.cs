using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.Model.ComplexExpense
{
    public class 기타부대비용
    {
        [XmlElement("careItemCost")]
        public long 관리용품구입비 { get; set; } // 관리용품구입비, 크기: 22, 필수

        [XmlElement("accountingCost")]
        public long 전문가자문비 { get; set; } // 전문가자문비 등, 크기: 22, 필수

        [XmlElement("hiddenCost")]
        public long 잡비 { get; set; } // 잡비, 크기: 22, 필수
    }
}