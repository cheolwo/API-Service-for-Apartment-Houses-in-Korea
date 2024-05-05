using Microsoft.Extensions.Configuration;
using System.Web;
using System.Xml.Serialization;
using 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스.RequestModel;
using 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스.기본정보.ResponseModel;
using 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스.상세정보.ResponseModel;

/// <summary>
/// Initializes a new instance of the service for accessing basic information about apartment complexes.
/// This service interacts with the Ministry of Land, Infrastructure and Transport's API to fetch basic data of housing complexes.
/// </summary>
/// <remarks>
/// This API provides access to:
/// - Category: Regional Development - Urban and Regional
/// - Managed by: Housing Construction Supply Division
/// - Contact: 044-201-3380
/// - API Type: REST
/// - Data Format: XML
/// - Usage Fee: Free, with traffic allowances available upon application.
///   Development account: 10,000 calls per day; Operational accounts can apply for increased traffic based on usage cases.
/// - Approval Type: Automatic approval for both development and operational stages.
/// - Usage Permissions: No restrictions on usage scope.
/// - Documentation: [공동주택기본정보 활용가이드 v1.6](https://www.data.go.kr/data/15058453/openapi.do)
/// </remarks>
namespace 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스
{
    public interface I공동주택단지정보APIService
    {
        Task<공동주택기본정보Response> Get공동주택기본정보(공동주택기본정보Request request);
    }
    public class 공동주택단지정보APIService : I공동주택단지정보APIService
    {
        private readonly string _serviceKey;
        public HttpClient _httpClient;
        public 공동주택단지정보APIService(IConfiguration configuration, HttpClient httpClient)
        {
            _serviceKey = configuration["공공데이터ServiceKey"] ??
               throw new ArgumentNullException("공공데이터ServiceKey is Null");
            _httpClient = httpClient;
        }
        public async Task<공동주택기본정보Response> Get공동주택기본정보(공동주택기본정보Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1613000/AptBasisInfoService1/getAphusBassInfo";
            string url = baseUrl + "?ServiceKey=" + _serviceKey + "&kaptCode=" + request.kaptCode;

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 공동주택기본정보Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(공동주택기본정보Response));
            using (StringReader reader = new StringReader(results))
            {
                return (공동주택기본정보Response)serializer.Deserialize(reader);
            }
        }
        public async Task<공동주택상세정보Response> Get공동주택상세정보(공동주택상세정보Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1613000/AptBasisInfoService1/getAphusDtlInfo";
            string url = baseUrl + "?ServiceKey=" + _serviceKey + "&kaptCode=" + request.kaptCode;

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and content {errorContent}");
            }

            string results = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Raw XML Response:");
            Console.WriteLine(results);

            // XML 응답을 공동주택상세정보Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(공동주택상세정보Response));
            using (StringReader reader = new StringReader(results))
            {
                return (공동주택상세정보Response)serializer.Deserialize(reader);
            }
        }
    }
}
