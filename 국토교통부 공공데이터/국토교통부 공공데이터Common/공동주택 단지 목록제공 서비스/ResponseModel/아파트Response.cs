using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.공동주택_단지_목록제공_서비스.ResponseModel
{
    [XmlRoot("response")]
    public class 아파트Response
    {
        [XmlElement("header")]
        public ResponseHeader Header { get; set; }

        [XmlElement("body")]
        public ResponseBody Body { get; set; }
    }

    public class ResponseHeader
    {
        [XmlElement("resultCode")]
        public string ResultCode { get; set; }

        [XmlElement("resultMsg")]
        public string ResultMsg { get; set; }
    }

    public class ResponseBody
    {
        [XmlElement("items")]
        public ItemList Items { get; set; }

        [XmlElement("numOfRows")]
        public int NumOfRows { get; set; }

        [XmlElement("pageNo")]
        public int PageNo { get; set; }

        [XmlElement("totalCount")]
        public int TotalCount { get; set; }
    }

    public class ItemList
    {
        [XmlElement("item")]
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        [XmlElement("as1")]
        public string As1 { get; set; }

        [XmlElement("as2")]
        public string As2 { get; set; }

        [XmlElement("as3")]
        public string As3 { get; set; }

        [XmlElement("as4")]
        public string As4 { get; set; }

        [XmlElement("bjdCode")]
        public string BjdCode { get; set; }

        [XmlElement("kaptCode")]
        public string KaptCode { get; set; }

        [XmlElement("kaptName")]
        public string KaptName { get; set; }
    }
}
