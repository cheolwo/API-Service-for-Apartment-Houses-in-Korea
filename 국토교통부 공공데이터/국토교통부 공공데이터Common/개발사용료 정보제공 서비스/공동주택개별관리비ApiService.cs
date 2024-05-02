using Microsoft.Extensions.Configuration;
using System.Web;
using System.Xml.Serialization;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.가스사용료;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.건물보험료;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.급탕비;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.난방비;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.생활폐기물수수료;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.선거관리위원회운영비;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.수도료;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.입주자대표회의운영비;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.전기료;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.정화조오물수수료;

namespace 국토교통부_공공데이터Common.개발사용료정보제공서비스
{
    public interface I공동주택개별관리비APIService
    {
        Task<급탕비Response> Get급탕비(개별사용료정보제공Request request);
    }
    /// <summary>
    /// http://apis.data.go.kr/1611000/AptCmnuseManageCostService
    /// </summary>
    public class 공동주택개별관리비APIService : I공동주택개별관리비APIService
    {
        private readonly HttpClient _httpClient;
        private string _serviceKey;
        public 공동주택개별관리비APIService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _serviceKey = configuration["공공데이터ServiceKey"] ??
                throw new ArgumentNullException(nameof(configuration));
        }
        public async Task<급탕비Response> Get급탕비(개별사용료정보제공Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpHotWaterCostInfo";
            string url = baseUrl + "?ServiceKey=" + _serviceKey + "&kaptCode=" + request.kaptCode + "&searchDate=" + request.searchDate;

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 급탕비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(급탕비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (급탕비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<난방비Response> Get난방비(개별사용료정보제공Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpHeatCostInfo";
            string url = baseUrl + "?ServiceKey=" + _serviceKey + "&kaptCode=" + request.kaptCode + "&searchDate=" + request.searchDate;

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 난방비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(난방비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (난방비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<가스사용료Response> Get가스사용료(개별사용료정보제공Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpGasRentalFeeInfo";
            string url = baseUrl + "?ServiceKey=" + _serviceKey + "&kaptCode=" + request.kaptCode + "&searchDate=" + request.searchDate;

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 가스사용료Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(가스사용료Response));
            using (StringReader reader = new StringReader(results))
            {
                return (가스사용료Response)serializer.Deserialize(reader);
            }
        }
        public async Task<전기료Response> Get전기료(개별사용료정보제공Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpElectricityCostInfo";
            string url = baseUrl + "?ServiceKey=" + _serviceKey + "&kaptCode=" + request.kaptCode + "&searchDate=" + request.searchDate;

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 전기료Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(전기료Response));
            using (StringReader reader = new StringReader(results))
            {
                return (전기료Response)serializer.Deserialize(reader);
            }
        }
        public async Task<수도료Response> Get수도료(개별사용료정보제공Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpWaterCostInfo";
            string url = baseUrl + "?ServiceKey=" + _serviceKey + "&kaptCode=" + request.kaptCode + "&searchDate=" + request.searchDate;

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 수도료Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(수도료Response));
            using (StringReader reader = new StringReader(results))
            {
                return (수도료Response)serializer.Deserialize(reader);
            }
        }
        public async Task<정화조오물수수료Response> Get정화조오물수수료(개별사용료정보제공Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpWaterPurifierTankFeeInfo";
            string url = baseUrl + "?ServiceKey=" + _serviceKey + "&kaptCode=" + request.kaptCode + "&searchDate=" + request.searchDate;

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 정화조오물수수료Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(정화조오물수수료Response));
            using (StringReader reader = new StringReader(results))
            {
                return (정화조오물수수료Response)serializer.Deserialize(reader);
            }
        }
        public async Task<생활폐기물수수료Response> Get생활폐기물수수료(개별사용료정보제공Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpDomesticWasteFeeInfo";
            string url = baseUrl + "?ServiceKey=" + _serviceKey + "&kaptCode=" + request.kaptCode + "&searchDate=" + request.searchDate;

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 생활폐기물수수료Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(생활폐기물수수료Response));
            using (StringReader reader = new StringReader(results))
            {
                return (생활폐기물수수료Response)serializer.Deserialize(reader);
            }
        }
        public async Task<입주자대표회의운영비Response> Get입주자대표회의운영비(개별사용료정보제공Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpMovingInRepresentationMtgInfo";
            string url = baseUrl + "?ServiceKey=" + _serviceKey + "&kaptCode=" + request.kaptCode + "&searchDate=" + request.searchDate;

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 입주자대표회의운영비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(입주자대표회의운영비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (입주자대표회의운영비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<건물보험료Response> Get건물보험료(개별사용료정보제공Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpBuildingInsuranceFeeInfo";
            string url = baseUrl + "?ServiceKey=" + _serviceKey + "&kaptCode=" + request.kaptCode + "&searchDate=" + request.searchDate;

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 건물보험료Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(건물보험료Response));
            using (StringReader reader = new StringReader(results))
            {
                return (건물보험료Response)serializer.Deserialize(reader);
            }
        }
        public async Task<선거관리위원회운영비Response> Get선거관리위원회운영비(개별사용료정보제공Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpElectionOrpnsInfo";
            string url = baseUrl + "?ServiceKey=" + _serviceKey + "&kaptCode=" + request.kaptCode + "&searchDate=" + request.searchDate;

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 선거관리위원회운영비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(선거관리위원회운영비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (선거관리위원회운영비Response)serializer.Deserialize(reader);
            }
        }
    }
    
}
