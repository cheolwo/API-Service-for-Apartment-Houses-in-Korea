using Microsoft.Extensions.Configuration;
using System.Web;
using System.Xml.Serialization;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스.ResponseModel.난방비;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.경비비;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.기타부대비용;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.소독비;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.수선비;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.승강기유지비;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.시설유지비;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.안전점검비;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.위탁관리수수료;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.재해예방비;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.제사무비;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.제세공과금;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.지능형홈네트워크설비유지비;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.차량유지비;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.청소비;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.ResponseModel.피복비;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스.인건비;

namespace 국토교통부_공공데이터Common.공용관리비정보제공서비스
{
    /// <summary>
    /// http://apis.data.go.kr/1611000/AptIndvdlzManageCostService
    /// </summary>
    public class 공동주택공용관리비APIService
    {
        private HttpClient _httpClient;
        private readonly string _serviceKey;
        public 공동주택공용관리비APIService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _serviceKey = configuration["공공데이터ServiceKey"] ?? throw new ArgumentNullException(nameof(configuration));
        }
        /// <summary>
        /// /getHsmpHeatCostInfo
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<난방비Response> Get난방비(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptIndvdlzManageCostService/getHsmpHeatCostInfo";
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

            // XML 응답을 난방비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(난방비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (난방비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<경비비Response> Get경비비(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpGuardCostInfo";
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

            // XML 응답을 경비비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(경비비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (경비비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<기타부대비용Response> Get기타부대비용(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpEtcCostInfo";
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

            // XML 응답을 기타부대비용Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(기타부대비용Response));
            using (StringReader reader = new StringReader(results))
            {
                return (기타부대비용Response)serializer.Deserialize(reader);
            }
        }
        public async Task<소독비Response> Get소독비(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpDisinfectionCostInfo";
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

            // XML 응답을 소독비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(소독비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (소독비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<수선비Response> Get수선비(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpRepairsCostInfo";
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

            // XML 응답을 수선비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(수선비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (수선비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<승강기유지비Response> Get승강기유지비(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpElevatorMntncCostInfo";
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

            // XML 응답을 승강기유지비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(승강기유지비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (승강기유지비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<시설유지비Response> Get시설유지비(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpFacilityMntncCostInfo";
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

            // XML 응답을 시설유지비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(시설유지비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (시설유지비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<안전점검비Response> Get안전점검비(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpSafetyCheckUpCostInfo";
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

            // XML 응답을 안전점검비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(안전점검비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (안전점검비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<위탁관리수수료Response> Get위탁관리수수료(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpConsignManageFeeInfo";
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

            // XML 응답을 위탁관리수수료Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(위탁관리수수료Response));
            using (StringReader reader = new StringReader(results))
            {
                return (위탁관리수수료Response)serializer.Deserialize(reader);
            }
        }
        public async Task<인건비Response> Get인건비(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpDisasterPreventionCostInfo";
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

            // XML 응답을 인건비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(인건비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (인건비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<재해예방비Response> Get재해예방비(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpDisasterPreventionCostInfo";
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

            // XML 응답을 재해예방비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(재해예방비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (재해예방비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<제사무비Response> Get제사무비(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpOfcrkCostInfo";
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

            // XML 응답을 제사무비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(제사무비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (제사무비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<제세공과금Response> Get제세공과금(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpTaxdueInfo";
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

            // XML 응답을 제세공과금Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(제세공과금Response));
            using (StringReader reader = new StringReader(results))
            {
                return (제세공과금Response)serializer.Deserialize(reader);
            }
        }
        public async Task<지능형홈네트워크설비유지비Response> Get지능형홈네트워크설비유지비(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpHomeNetworkMntncCostInfo";
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

            // XML 응답을 지능형홈네트워크설비유지비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(지능형홈네트워크설비유지비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (지능형홈네트워크설비유지비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<차량유지비Response> Get차량유지비(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpVhcleMntncCostInfo";
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

            // XML 응답을 차량유지비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(차량유지비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (차량유지비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<청소비Response> Get청소비(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpCleaningCostInfo";
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

            // XML 응답을 청소비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(청소비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (청소비Response)serializer.Deserialize(reader);
            }
        }
        public async Task<피복비Response> Get피복비(공용관리비Request request)
        {
            string baseUrl = "http://apis.data.go.kr/1611000/AptCmnuseManageCostService/getHsmpClothingCostInfo";
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

            // XML 응답을 피복비Response 객체로 역직렬화합니다.
            XmlSerializer serializer = new XmlSerializer(typeof(피복비Response));
            using (StringReader reader = new StringReader(results))
            {
                return (피복비Response)serializer.Deserialize(reader);
            }
        }
    }
}
