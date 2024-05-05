using Microsoft.Extensions.Configuration;
using System.Xml.Serialization;
using 국토교통부_공공데이터Common.장기수선충당금_정보서비스.ResponseModel.월부과액;
using 국토교통부_공공데이터Common.장기수선충당금_정보서비스.ResponseModel.월사용액;
using 국토교통부_공공데이터Common.장기수선충당금_정보서비스.ResponseModel.적립요율;
using 국토교통부_공공데이터Common.장기수선충당금_정보서비스.ResponseModel.충당금잔액;
/// <summary>
/// Service for accessing long-term repair reserve fund data of apartment complexes.
/// This service connects to the Ministry of Land, Infrastructure and Transport's API 
/// to retrieve data on long-term maintenance funds required for apartment complexes, aiding in financial planning and maintenance scheduling.
/// </summary>
/// <remarks>
/// API details:
/// - Category: Regional Development - Urban and Regional
/// - Managed by: Housing Construction Supply Division
/// - Contact number: 044-201-3380
/// - API Type: REST
/// - Data Format: XML
/// - Usage Fee: Free; additional traffic can be requested upon registration of usage cases.
///   - Development account: 10,000 calls/day.
///   - Operational accounts: Extendable based on usage case submission.
/// - Approval Type: Automatic for both development and operational phases.
/// - Usage Permissions: No restrictions on use.
/// - Reference Document: [장기수선충당금 정보 활용가이드 v1.3](https://www.data.go.kr/tcs/dss/selectApiDataDetailView.do?publicDataPk=15059160)
/// </remarks>
namespace 국토교통부_공공데이터Common.장기수선충당금_정보서비스
{
    public class 공동주택장기수선충당금APIService
    {
        private readonly HttpClient _httpClient;
        private string _serviceKey;
        public 공동주택장기수선충당금APIService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _serviceKey = configuration["공공데이터ServiceKey"] ??
                throw new ArgumentNullException("공공데이터ServiceKey is Null");
        }
        public async Task<단지별월부과액Response> Get단지별월부과액(장기수선충당금Request request)
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

            // XML 응답을 단지별월부과액Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(단지별월부과액Response));
            using (StringReader reader = new StringReader(results))
            {
                return (단지별월부과액Response)serializer.Deserialize(reader);
            }
        }
        public async Task<단지별월사용액Response> Get단지별월사용액(장기수선충당금Request request)
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

            // XML 응답을 단지별월사용액Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(단지별월사용액Response));
            using (StringReader reader = new StringReader(results))
            {
                return (단지별월사용액Response)serializer.Deserialize(reader);
            }
        }
        public async Task<단지별적립요율Response> Get단지별적립요율(장기수선충당금Request request)
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

            // XML 응답을 단지별적립요율Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(단지별적립요율Response));
            using (StringReader reader = new StringReader(results))
            {
                return (단지별적립요율Response)serializer.Deserialize(reader);
            }
        }
        public async Task<단지별충당금잔액Response> Get단지별충당금잔액(장기수선충당금Request request)
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

            // XML 응답을 단지별충당금잔액Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(단지별충당금잔액Response));
            using (StringReader reader = new StringReader(results))
            {
                return (단지별충당금잔액Response)serializer.Deserialize(reader);
            }
        }
    }
}
