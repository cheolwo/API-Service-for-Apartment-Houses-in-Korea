using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스.ResponseModel
{
    [XmlRoot("response")]
    public class 공동주택상세정보Response
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
        [XmlElement("item")]
        public 공동주택상세정보 Item { get; set; }
    }

    public class 공동주택상세정보
    {
        [XmlElement("kaptCode")]
        public string KaptCode { get; set; }

        [XmlElement("kaptName")]
        public string KaptName { get; set; }

        [XmlElement("codeMgr")]
        public string CodeMgr { get; set; }

        [XmlElement("kaptMgrCnt")]
        public decimal KaptMgrCnt { get; set; }

        [XmlElement("kaptCcompany")]
        public string KaptCcompany { get; set; }

        [XmlElement("codeSec")]
        public string CodeSec { get; set; }

        [XmlElement("kaptdScnt")]
        public decimal KaptdScnt { get; set; }

        [XmlElement("kaptdSecCom")]
        public string KaptdSecCom { get; set; }

        [XmlElement("codeClean")]
        public string CodeClean { get; set; }

        [XmlElement("kaptdClcnt")]
        public decimal KaptdClcnt { get; set; }

        [XmlElement("codeGarbage")]
        public string CodeGarbage { get; set; }

        [XmlElement("codeDisinf")]
        public string CodeDisinf { get; set; }

        [XmlElement("kaptdDcnt")]
        public int KaptdDcnt { get; set; }

        [XmlElement("disposalType")]
        public string DisposalType { get; set; }

        [XmlElement("codeStr")]
        public string CodeStr { get; set; }

        [XmlElement("kaptdEcapa")]
        public decimal KaptdEcapa { get; set; }

        [XmlElement("codeEcon")]
        public string CodeEcon { get; set; }

        [XmlElement("codeEmgr")]
        public string CodeEmgr { get; set; }

        [XmlElement("codeFalarm")]
        public string CodeFalarm { get; set; }

        [XmlElement("codeWsupply")]
        public string CodeWsupply { get; set; }

        [XmlElement("codeElev")]
        public string CodeElev { get; set; }

        [XmlElement("kaptdEcnt")]
        public int KaptdEcnt { get; set; }

        [XmlElement("kaptdPcnt")]
        public int KaptdPcnt { get; set; }

        [XmlElement("kaptdPcntu")]
        public int KaptdPcntu { get; set; }

        [XmlElement("codeNet")]
        public string CodeNet { get; set; }

        [XmlElement("kaptdCccnt")]
        public int KaptdCccnt { get; set; }

        [XmlElement("welfareFacility")]
        public string WelfareFacility { get; set; }

        [XmlElement("kaptdWtimebus")]
        public decimal KaptdWtimebus { get; set; }

        [XmlElement("subwayLine")]
        public string SubwayLine { get; set; }

        [XmlElement("subwayStation")]
        public string SubwayStation { get; set; }

        [XmlElement("kaptdWtimesub")]
        public decimal KaptdWtimesub { get; set; }

        [XmlElement("convenientFacility")]
        public string ConvenientFacility { get; set; }

        [XmlElement("educationFacility")]
        public string EducationFacility { get; set; }
    }
}
