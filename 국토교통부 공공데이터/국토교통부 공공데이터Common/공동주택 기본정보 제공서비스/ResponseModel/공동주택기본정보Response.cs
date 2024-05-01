using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스.ResponseModel
{
    [XmlRoot("response")]
    public class 공동주택기본정보Response
    {
        [XmlElement("header")]
        public ResponseHeader Header { get; set; }

        [XmlElement("body")]
        public 공동주택기본정보 Body { get; set; }
    }

    public class ResponseHeader
    {
        [XmlElement("resultCode")]
        public string ResultCode { get; set; }

        [XmlElement("resultMsg")]
        public string ResultMsg { get; set; }
    }

    public class 공동주택기본정보
    {
        [XmlElement("kaptCode")]
        public string KaptCode { get; set; }

        [XmlElement("kaptName")]
        public string KaptName { get; set; }

        [XmlElement("kaptAddr")]
        public string KaptAddr { get; set; }

        [XmlElement("codeSaleNm")]
        public string CodeSaleNm { get; set; }

        [XmlElement("codeHeatNm")]
        public string CodeHeatNm { get; set; }

        [XmlElement("kaptTarea")]
        public double KaptTarea { get; set; }

        [XmlElement("kaptDongCnt")]
        public int KaptDongCnt { get; set; }

        [XmlElement("kaptdaCnt")]
        public int KaptdaCnt { get; set; }

        [XmlElement("kaptBcompany")]
        public string KaptBcompany { get; set; }

        [XmlElement("kaptAcompany")]
        public string KaptAcompany { get; set; }

        [XmlElement("kaptTel")]
        public string KaptTel { get; set; }

        [XmlElement("kaptFax")]
        public string KaptFax { get; set; }

        [XmlElement("kaptUrl")]
        public string KaptUrl { get; set; }

        [XmlElement("codeAptNm")]
        public string CodeAptNm { get; set; }

        [XmlElement("doroJuso")]
        public string DoroJuso { get; set; }

        [XmlElement("hoCnt")]
        public int HoCnt { get; set; }

        [XmlElement("codeMgrNm")]
        public string CodeMgrNm { get; set; }

        [XmlElement("codeHallNm")]
        public string CodeHallNm { get; set; }

        [XmlElement("kaptUsedate")]
        public string KaptUsedate { get; set; }

        [XmlElement("kaptMarea")]
        public double KaptMarea { get; set; }

        [XmlElement("kaptMparea_60")]
        public double KaptMparea_60 { get; set; }

        [XmlElement("kaptMparea_85")]
        public double KaptMparea_85 { get; set; }

        [XmlElement("kaptMparea_135")]
        public double KaptMparea_135 { get; set; }

        [XmlElement("kaptMparea_136")]
        public double KaptMparea_136 { get; set; }

        [XmlElement("privArea")]
        public double PrivArea { get; set; }

        [XmlElement("bjdCode")]
        public string BjdCode { get; set; }
    }
}
