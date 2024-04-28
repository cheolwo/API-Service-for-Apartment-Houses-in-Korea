// C# 샘플 코드
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            string url = "http://apis.data.go.kr/1613000/AptListService2/getTotalAptList"; // URL
            url += "?ServiceKey=" + "D0wkCvWHdCeJsYuU8A14KWl7mzOJ%2FiKbyKR%2F5xvnALYMf5wi5rcbCp2CXsx6xCsBhvgl5PJ8u%2Fwilufv%2FjhMcg%3D%3D"; // Service Key
            url += "&pageNo=1";
            url += "&numOfRows=10";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }

            Console.WriteLine(results);
        }
    }
}