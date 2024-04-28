﻿using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.재해예방비
{
    [XmlRoot("response")]
    public class 재해예방비Response
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

        [XmlElement("lrefCost4")]
        public long LrefCost4 { get; set; } // 재해예방비, 크기: 22, 필수
    }

}
