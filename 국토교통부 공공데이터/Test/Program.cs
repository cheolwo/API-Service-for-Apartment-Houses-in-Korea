// C# 샘플 코드
using System;
using System.Net;
using System.Net.Http;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            string url = "http://apis.data.go.kr/1611000/AptRepairsCostService/getHsmpMonthRetalFeeInfo"; // URL
            url += "?ServiceKey=" + "D0wkCvWHdCeJsYuU8A14KWl7mzOJ%2FiKbyKR%2F5xvnALYMf5wi5rcbCp2CXsx6xCsBhvgl5PJ8u%2Fwilufv%2FjhMcg%3D%3D"; // Service Key
            url += "&kaptCode=A10027953";
            url += "&searchDate=201507";

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