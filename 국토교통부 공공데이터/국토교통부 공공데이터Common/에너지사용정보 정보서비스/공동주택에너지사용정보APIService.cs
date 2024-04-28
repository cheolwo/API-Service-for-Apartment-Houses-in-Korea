using Microsoft.Extensions.Configuration;
using System.Web;
using System.Xml.Serialization;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스.RequestModel;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스.ResponseModel.단지에너지사용량;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스.ResponseModel.단지평균에너지사용금액;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스.ResponseModel.시군구평균에너지사용금액;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스.ResponseModel.시도평균에너지사용금액;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스.ResponseModel.전국평균에너지사용금액;

namespace 국토교통부_공공데이터Common.에너지사용정보_정보서비스
{
    public class 공동주택에너지사용정보APIService
    {
        private readonly HttpClient _httpClient;
        private string _serviceKey;
        public 공동주택에너지사용정보APIService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _serviceKey = configuration["공공데이터ServiceKey"] ??
                throw new ArgumentNullException(nameof(configuration));
        }
        public async Task<단지에너지사용량Response> Get단지에너지사용량(단지에너지사용량Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpHotWaterCostInfo";
            var queryParameters = HttpUtility.ParseQueryString(string.Empty);
            queryParameters["ServiceKey"] = _serviceKey;
            queryParameters["kaptCode"] = request.kaptCode;
            queryParameters["searchDate"] = request.searchDate;

            string url = $"{baseUrl}?{queryParameters}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 단지에너지사용량Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(단지에너지사용량Response));
            using (StringReader reader = new StringReader(results))
            {
                return (단지에너지사용량Response)serializer.Deserialize(reader);
            }
        }
        public async Task<단지평균에너지사용금액Response> Get단지평균에너지사용금액(단지평균에너지사용금액Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpHotWaterCostInfo";
            var queryParameters = HttpUtility.ParseQueryString(string.Empty);
            queryParameters["ServiceKey"] = _serviceKey;
            queryParameters["kaptCode"] = request.kaptCode;
            queryParameters["searchDate"] = request.searchDate;

            string url = $"{baseUrl}?{queryParameters}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 단지평균에너지사용금액Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(단지평균에너지사용금액Response));
            using (StringReader reader = new StringReader(results))
            {
                return (단지평균에너지사용금액Response)serializer.Deserialize(reader);
            }
        }
        public async Task<시군구평균에너지사용금액Response> Get시군구평균에너지사용금액(시군구평균에너지사용금액Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpHotWaterCostInfo";
            var queryParameters = HttpUtility.ParseQueryString(string.Empty);
            queryParameters["ServiceKey"] = _serviceKey;
            queryParameters["sigunguCode"] = request.sigunguCode;
            queryParameters["searchDate"] = request.searchDate;

            string url = $"{baseUrl}?{queryParameters}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 시군구평균에너지사용금액Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(시군구평균에너지사용금액Response));
            using (StringReader reader = new StringReader(results))
            {
                return (시군구평균에너지사용금액Response)serializer.Deserialize(reader);
            }
        }
        public async Task<시도평균에너지사용금액Response> Get시도평균에너지사용금액(시도평균에너지사용금액Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpHotWaterCostInfo";
            var queryParameters = HttpUtility.ParseQueryString(string.Empty);
            queryParameters["ServiceKey"] = _serviceKey;
            queryParameters["sidoCode"] = request.sidoCode;
            queryParameters["searchDate"] = request.searchDate;

            string url = $"{baseUrl}?{queryParameters}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 시도평균에너지사용금액Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(시도평균에너지사용금액Response));
            using (StringReader reader = new StringReader(results))
            {
                return (시도평균에너지사용금액Response)serializer.Deserialize(reader);
            }
        }
        public async Task<전국평균에너지사용금액Response> Get전국평균에너지사용금액(전국평균에너지사용금액Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpHotWaterCostInfo";
            var queryParameters = HttpUtility.ParseQueryString(string.Empty);
            queryParameters["ServiceKey"] = _serviceKey;
            queryParameters["searchDate"] = request.searchDate;

            string url = $"{baseUrl}?{queryParameters}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 전국평균에너지사용금액Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(전국평균에너지사용금액Response));
            using (StringReader reader = new StringReader(results))
            {
                return (전국평균에너지사용금액Response)serializer.Deserialize(reader);
            }
        }
    }
}
