using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.인건비
{
    [XmlRoot("response")]
    public class 인건비Response
    {
        [XmlElement("header")]
        public Header Header { get; set; }

        [XmlElement("body")]
        public Body Body { get; set; }
    }

    public class Header
    {
        [XmlElement("resultCode")]
        public string ResultCode { get; set; }

        [XmlElement("resultMsg")]
        public string ResultMsg { get; set; }
    }

    public class Body
    {
        [XmlElement("item")]
        public Item Item { get; set; }
    }

    public class Item
    {
        [XmlElement("kaptCode")]
        public string KaptCode { get; set; }

        [XmlElement("kaptName")]
        public string KaptName { get; set; }

        [XmlElement("pay")]
        public int Pay { get; set; } // 금액 관련 필드는 int 형으로 변경하는 것이 좋을 수 있습니다.

        [XmlElement("sundryCost")]
        public int SundryCost { get; set; }

        [XmlElement("bonus")]
        public int Bonus { get; set; }

        [XmlElement("pension")]
        public int Pension { get; set; }

        [XmlElement("accidentPremium")]
        public int AccidentPremium { get; set; }

        [XmlElement("employPremium")]
        public int EmployPremium { get; set; }

        [XmlElement("nationalPension")]
        public int NationalPension { get; set; }

        [XmlElement("healthPremium")]
        public int HealthPremium { get; set; }

        [XmlElement("welfareBenefit")]
        public int WelfareBenefit { get; set; }
    }
}
