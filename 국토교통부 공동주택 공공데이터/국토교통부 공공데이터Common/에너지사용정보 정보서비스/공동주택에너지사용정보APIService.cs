using Microsoft.Extensions.Configuration;
using System.Web;
using System.Xml.Serialization;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스.RequestModel;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스.ResponseModel.단지에너지사용량;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스.ResponseModel.단지평균에너지사용금액;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스.ResponseModel.시군구평균에너지사용금액;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스.ResponseModel.시도평균에너지사용금액;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스.ResponseModel.전국평균에너지사용금액;

/// <summary>
/// Service for accessing energy usage information of apartment complexes.
/// Interacts with the Ministry of Land, Infrastructure and Transport's API 
/// to fetch energy consumption data specific to apartment complexes, enhancing energy management and reporting capabilities.
/// </summary>
/// <remarks>
/// API details:
/// - Category: Regional Development - Urban and Regional
/// - Managed by: Housing Construction Supply Division
/// - Contact number: 044-201-3380
/// - API Type: REST
/// - Data Format: XML
/// - Usage Fee: Free; traffic limits are extendable on application.
///   - Development account: 10,000 calls/day.
///   - Operational accounts: Traffic increase available upon case registration.
/// - Approval Type: Automatic for both development and operational phases.
/// - Usage Permissions: Unrestricted.
/// - Reference Document: [공동주택에너지사용정보 활용가이드 v1.1](https://www.data.go.kr/tcs/dss/selectApiDataDetailView.do?publicDataPk=15012964)
/// </remarks>
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
