using Microsoft.Extensions.Configuration;
using System.Xml.Serialization;
using 국토교통부_공공데이터Common.장기수선충당금_정보서비스.ResponseModel.월부과액;
using 국토교통부_공공데이터Common.장기수선충당금_정보서비스.ResponseModel.월사용액;
using 국토교통부_공공데이터Common.장기수선충당금_정보서비스.ResponseModel.적립요율;
using 국토교통부_공공데이터Common.장기수선충당금_정보서비스.ResponseModel.충당금잔액;

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
