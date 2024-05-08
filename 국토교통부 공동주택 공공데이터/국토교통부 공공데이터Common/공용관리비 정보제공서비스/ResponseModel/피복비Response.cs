using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.피복비
{
    [XmlRoot("response")]
    public class 피복비Response
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

        [XmlElement("clothesCost")]
        public int ClothesCost { get; set; } // 피복비
    }

}
