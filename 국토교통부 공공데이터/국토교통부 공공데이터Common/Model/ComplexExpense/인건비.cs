using System.Xml.Serialization;

namespace 국토교통부_공공데이터Common.Model.ComplexExpense
{
    public class 인건비
    {
        [XmlElement("pay")]
        public int 급여 { get; set; }

        [XmlElement("sundryCost")]
        public int 제수당 { get; set; }

        [XmlElement("bonus")]
        public int 상여금 { get; set; }

        [XmlElement("pension")]
        public int 퇴직금 { get; set; }

        [XmlElement("accidentPremium")]
        public int 산재보험료 { get; set; }

        [XmlElement("employPremium")]
        public int 고용보험료 { get; set; }

        [XmlElement("nationalPension")]
        public int 국민연금 { get; set; }

        [XmlElement("healthPremium")]
        public int 건강보험료 { get; set; }

        [XmlElement("welfareBenefit")]
        public int 식대등복리후생비 { get; set; }
    }
}