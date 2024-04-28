using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.Model.ComplexExpense
{
    public class 제사무비
    {
        // 사무용품 비용
        [XmlElement("officeSupply")]
        public string 사무용품비용 { get; set; }

        // 도서 및 인쇄비
        [XmlElement("bookSupply")]
        public string 도서및인쇄비 { get; set; }

        // 교통비
        [XmlElement("transportCost")]
        public string 교통비 { get; set; }
    }
}