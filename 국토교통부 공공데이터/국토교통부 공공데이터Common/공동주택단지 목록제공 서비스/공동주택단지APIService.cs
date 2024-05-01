using Microsoft.Extensions.Configuration;
using System.Xml.Serialization;
using 국토교통부_공공데이터Common.공동주택_단지_목록제공_서비스.ResponseModel;

namespace 국토교통부_공공데이터Common.국토교통부_공동주택단지목록제공서비스
{
    public interface I공동주택단지APIService
    {
        Task<아파트Response> GetTotalAptListAsync();
    }

    public class 공동주택단지APIService : I공동주택단지APIService
    {
        private readonly HttpClient _httpClient;
        private readonly string _serviceKey;

        public 공동주택단지APIService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _serviceKey = configuration["AptListApi:ServiceKey"] ??
                throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<아파트Response> GetTotalAptListAsync()
        {
            var totalCount = await GetTotalCount();
            return  await GetTotal공동주택(totalCount);
        }
        private async Task<int> GetTotalCount()
        {
            string url = "http://apis.data.go.kr/1613000/AptListService2/getTotalAptList" +
                $"?ServiceKey={_serviceKey}&pageNo=1&numOfRows=1";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var stream = await response.Content.ReadAsStreamAsync();
            XmlSerializer serializer = new XmlSerializer(typeof(아파트Response),
                new XmlRootAttribute("response"));
            var 아파트Response = (아파트Response)serializer.Deserialize(stream);
            if (아파트Response == null) { throw new ArgumentNullException(nameof(아파트Response)); }
            return 아파트Response.Body.TotalCount;
        }
        private async Task<아파트Response> GetTotal공동주택(int totalCount)
        {
            string url = "http://apis.data.go.kr/1613000/AptListService2/getTotalAptList" +
                $"?ServiceKey={_serviceKey}&pageNo=1&numOfRows={totalCount}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var stream = await response.Content.ReadAsStreamAsync();
            XmlSerializer serializer = new XmlSerializer(typeof(아파트Response),
                new XmlRootAttribute("response"));
            return (아파트Response)serializer.Deserialize(stream);
        }
    }
}
