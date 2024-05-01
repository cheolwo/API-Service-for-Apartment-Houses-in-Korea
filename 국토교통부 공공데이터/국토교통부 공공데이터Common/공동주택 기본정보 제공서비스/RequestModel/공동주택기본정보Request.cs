using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스.RequestModel
{
    public class 공동주택기본정보Request : IRequest
    {
        public string? kaptCode { get; set; }
    }
    public class 공동주택상세정보Request : IRequest
    {
        public string? kaptCode { get; set; }
    }
}
