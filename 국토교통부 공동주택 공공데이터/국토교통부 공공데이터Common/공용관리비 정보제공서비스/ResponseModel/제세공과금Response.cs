using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.제세공과금
{
    [XmlRoot("response")]
    public class 제세공과금Response
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

        [XmlElement("elecCost")]
        public int ElecCost { get; set; } // 전기 비용

        [XmlElement("postageCost")]
        public int PostageCost { get; set; } // 우편 비용

        [XmlElement("taxrestCost")]
        public int TaxrestCost { get; set; } // 세금 및 기타 비용

        [XmlElement("telCost")]
        public int TelCost { get; set; } // 전화 비용
    }
}
