using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.에너지사용정보_정보서비스.ResponseModel.단지에너지사용량
{
    /// <summary>
    /// 단지코드, 발생년월을 이용
    /// </summary>
    [XmlRoot("response")]
    public class 단지에너지사용량Response
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
        [XmlElement("kaptCode")]
        public string KaptCode { get; set; } // 단지 코드, 크기: 9, 필수

        [XmlElement("heat")]
        public long Heat { get; set; } // 난방사용금액, 크기: 22, 필수

        [XmlElement("hheat")]
        public long HHeat { get; set; } // 난방사용량(Mcal), 크기: 22, 필수

        [XmlElement("waterHot")]
        public long WaterHot { get; set; } // 급탕사용금액, 크기: 22, 필수

        [XmlElement("hwaterHot")]
        public long HWaterHot { get; set; } // 급탕사용량(ton), 크기: 22, 필수

        [XmlElement("gas")]
        public long Gas { get; set; } // 가스사용금액, 크기: 22, 필수

        [XmlElement("hgas")]
        public long HGas { get; set; } // 가스사용량(㎥), 크기: 22, 필수

        [XmlElement("elect")]
        public long Elect { get; set; } // 전기사용금액, 크기: 22, 필수

        [XmlElement("helect")]
        public long HElect { get; set; } // 전기사용량(Kwh), 크기: 22, 필수

        [XmlElement("waterCool")]
        public long WaterCool { get; set; } // 수도사용금액, 크기: 22, 필수

        [XmlElement("hwaterCool")]
        public long HWaterCool { get; set; } // 수도사용량(㎥), 크기: 22, 필수
    }

}
