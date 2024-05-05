using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.제사무비
{
    // XML 응답의 루트 요소를 나타냅니다.
    [XmlRoot("response")]
    public class 제사무비Response
    {
        // 응답의 헤더 부분
        [XmlElement("header")]
        public Header Header { get; set; }

        // 응답의 바디 부분
        [XmlElement("body")]
        public Body Body { get; set; }
    }

    // 응답 헤더 정보를 나타내는 클래스
    public class Header
    {
        // 응답 결과 코드
        [XmlElement("resultCode")]
        public string ResultCode { get; set; }

        // 응답 결과 메시지
        [XmlElement("resultMsg")]
        public string ResultMsg { get; set; }
    }

    // 응답 바디를 나타내는 클래스
    public class Body
    {
        // 바디에 포함된 항목
        [XmlElement("item")]
        public Item Item { get; set; }
    }

    // 실제 데이터를 담고 있는 항목 클래스
    public class Item
    {
        // 단지 코드
        [XmlElement("kaptCode")]
        public string KaptCode { get; set; }

        // 단지명
        [XmlElement("kaptName")]
        public string KaptName { get; set; }

        // 사무용품 비용
        [XmlElement("officeSupply")]
        public long OfficeSupply { get; set; }

        // 도서 및 인쇄비
        [XmlElement("bookSupply")]
        public long BookSupply { get; set; }

        // 교통비
        [XmlElement("transportCost")]
        public long TransportCost { get; set; }
    }
}
