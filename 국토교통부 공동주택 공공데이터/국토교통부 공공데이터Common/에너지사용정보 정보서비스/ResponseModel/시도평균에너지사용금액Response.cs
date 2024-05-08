using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.에너지사용정보_정보서비스.ResponseModel.시도평균에너지사용금액
{
    [XmlRoot("response")]
    public class 시도평균에너지사용금액Response
    {
        [XmlElement("header")]
        public Header Header { get; set; }

        [XmlElement("body")]
        public Body Body { get; set; }
    }

    public class Header
    {
        [XmlElement("resultCode")]
        public string ResultCode { get; set; } // 결과 코드, 크기: 2, 필수

        [XmlElement("resultMsg")]
        public string ResultMsg { get; set; } // 결과 메시지, 크기: 20, 필수
    }

    public class Body
    {
        [XmlElement("item")]
        public Item Item { get; set; }
    }

    public class Item
    {
        [XmlElement("heat")]
        public long Heat { get; set; } // 난방사용금액, 크기: 22, 필수

        [XmlElement("waterHot")]
        public long WaterHot { get; set; } // 급탕사용금액, 크기: 22, 필수

        [XmlElement("gas")]
        public long Gas { get; set; } // 가스사용금액, 크기: 22, 필수

        [XmlElement("elect")]
        public long Elect { get; set; } // 전기사용금액, 크기: 22, 필수

        [XmlElement("waterCool")]
        public long WaterCool { get; set; } // 수도사용금액, 크기: 22, 필수
    }

}
