﻿using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.수도료
{
    [XmlRoot("response")]
    public class 수도료Response
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

        [XmlElement("kaptName")]
        public string KaptName { get; set; } // 단지명, 크기: 50, 필수

        [XmlElement("waterCoolC")]
        public long WaterCoolC { get; set; } // 수도 공용 금액, 크기: 22, 필수

        [XmlElement("waterCoolP")]
        public long WaterCoolP { get; set; } // 수도 전용 금액, 크기: 22, 필수
    }

}
