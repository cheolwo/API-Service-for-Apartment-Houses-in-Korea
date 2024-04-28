using Microsoft.Extensions.Configuration;
using System.Xml.Serialization;
using 국토교통부_공공데이터Common.공동주택_단지_목록제공_서비스.ResponseModel;

namespace 국토교통부_공공데이터Common.국토교통부_공동주택단지목록제공서비스
{
    public interface I공동주택단지ApiService
    {
        Task<아파트Response> GetSidoAptListAsync(int sidoCode, int pageNo = 1, int numOfRows = 10);
        Task<아파트Response> GetTotalAptListAsync(
            int pageNo = 1, int numOfRows = 10);
    }
    public class 공동주택단지ApiService : I공동주택단지ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly string _baseUrl;
        private readonly string _serviceKey;

        public 공동주택단지ApiService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseUrl = configuration["AptListApi:BaseUrl"] ?? 
                throw new ArgumentNullException(nameof(configuration));
            _serviceKey = configuration["AptListApi:ServiceKey"] ?? 
                throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<아파트Response> GetSidoAptListAsync(int sidoCode,
            int pageNo = 1, int numOfRows = 10)
        {
            string url = $"{_baseUrl}/{_configuration["AptListApi:시도아파트목록"]}?" +
                $"ServiceKey={_serviceKey}&sidoCode={sidoCode}&pageNo={pageNo}&numOfRows={numOfRows}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var stream = await response.Content.ReadAsStreamAsync();
            XmlSerializer serializer = new XmlSerializer(typeof(아파트Response), 
                new XmlRootAttribute("response"));
            return (아파트Response)serializer.Deserialize(stream);
        }
        public async Task<아파트Response> GetTotalAptListAsync(
            int pageNo = 1, int numOfRows = 10)
        {
            string url = $"{_baseUrl}/{_configuration["AptListApi:전체아파트목록"]}?" +
                $"ServiceKey={_serviceKey}&pageNo={pageNo}&numOfRows={numOfRows}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var stream = await response.Content.ReadAsStreamAsync();
            XmlSerializer serializer = new XmlSerializer(typeof(아파트Response), 
                new XmlRootAttribute("response"));
            return (아파트Response)serializer.Deserialize(stream);
        }
    }
}
