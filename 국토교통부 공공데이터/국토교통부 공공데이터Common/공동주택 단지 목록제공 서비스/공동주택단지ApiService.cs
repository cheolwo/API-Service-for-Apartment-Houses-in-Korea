using Microsoft.Extensions.Configuration;
using System.Xml.Serialization;
using 국토교통부_공공데이터Common.공동주택_단지_목록제공_서비스;
using 국토교통부_공공데이터Common.공동주택_단지_목록제공_서비스.ResponseModel;

namespace 국토교통부_공공데이터Common.국토교통부_공동주택단지목록제공서비스
{
    public interface I공동주택단지APIService
    {
        Task<아파트Response> GetSidoAptListAsync(공동주택단지Request request);
        Task<아파트Response> GetTotalAptListAsync(공동주택단지Request request);
    }

    public class 공동주택단지APIService : I공동주택단지APIService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly string _baseUrl;
        private readonly string _serviceKey;

        public 공동주택단지APIService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseUrl = configuration["AptListApi:BaseUrl"] ??
                throw new ArgumentNullException(nameof(configuration));
            _serviceKey = configuration["AptListApi:ServiceKey"] ??
                throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<아파트Response> GetSidoAptListAsync(공동주택단지Request request)
        {
            string url = $"{_baseUrl}/{_configuration["AptListApi:시도아파트목록"]}?" +
                $"ServiceKey={_serviceKey}&sidoCode={request.sidoCode}&pageNo={request.pageNo}&numOfRows={request.numOfRows}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var stream = await response.Content.ReadAsStreamAsync();
            XmlSerializer serializer = new XmlSerializer(typeof(아파트Response),
                new XmlRootAttribute("response"));
            return (아파트Response)serializer.Deserialize(stream);
        }

        public async Task<아파트Response> GetTotalAptListAsync(공동주택단지Request request)
        {
            string url = $"{_baseUrl}/{_configuration["AptListApi:전체아파트목록"]}?" +
                $"ServiceKey={_serviceKey}&pageNo={request.pageNo}&numOfRows={request.numOfRows}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var stream = await response.Content.ReadAsStreamAsync();
            XmlSerializer serializer = new XmlSerializer(typeof(아파트Response),
                new XmlRootAttribute("response"));
            return (아파트Response)serializer.Deserialize(stream);
        }
    }
}
