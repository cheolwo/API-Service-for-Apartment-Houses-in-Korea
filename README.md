<h2 align="center"><strong><span style="color:red;">공공데이터 링크 </span></strong></h2>

![image](https://github.com/cheolwo/CommonHouse/assets/25167316/a7fd4c9e-3a2f-4c1b-84d1-fa53b35179af)


- [데이터 API 1 국토교통부_공동주택 기본 정보제공 서비스](https://www.data.go.kr/tcs/dss/selectApiDataDetailView.do?publicDataPk=15058453)
- [데이터 API 2 국토교통부_공동주택 단지 목록제공 서비스](https://www.data.go.kr/tcs/dss/selectApiDataDetailView.do?publicDataPk=15057332)
- [데이터 API 3 국토교통부_공동주택 에너지 사용 정보](https://www.data.go.kr/tcs/dss/selectApiDataDetailView.do?publicDataPk=15012964)
- [데이터 API 4 국토교통부_공동주택관리비(개별사용료)정보제공서비스](https://www.data.go.kr/data/15059469/openapi.do)
- [데이터 API 5 국토교통부_공동주택관리비(공용관리비)정보제공서비스](https://www.data.go.kr/data/15057937/openapi.do)
- [데이터 API 6 국토교통부_공동주택관리비(장기수선충당금)정보서비스](https://www.data.go.kr/tcs/dss/selectApiDataDetailView.do?publicDataPk=15059160)


<h2 align="center"><strong><span style="color:red;">프로세스</span></strong></h2>

![image](https://github.com/cheolwo/CommonHouse/assets/25167316/fa4bca89-aecb-46d4-a4cc-01f7712c5c87)


<h2 align="center"><strong><span style="color:red;">ERD</span></strong></h2>

![image](https://github.com/cheolwo/CommonHouse/assets/25167316/7f60bf14-a40e-4060-9a13-8c9a832c6bb1)

<h2 align="center"><strong><span style="color:red;">공통적인 모듈 간 관계</span></strong></h2>

![image](https://github.com/cheolwo/CommonHouse/assets/25167316/94547669-dcb0-4932-a3d7-fd4afc3a9770)

# Configuration Settings

Below you will find a basic example of the necessary `appsettings.json` configuration for this project. Please make sure to adjust the settings according to your local environment and security requirements.

## Basic Configuration

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "공동주택": "Server=localhost\\SQLEXPRESS01;Database=공동주택Db;Trusted_Connection=True;"
  },
   "공공데이터ServiceKey": "Your Service Key"
}

```
## Asp.net Core Service Container
```ServiceContainer
builder.Services.AddHttpClient();
builder.Services.AddDbContext<공동주택DbContext>(options =>
    options.UseInMemoryDatabase("공동주택Db"));
// Registering AutoMapper
builder.Services.AddAutoMapper(
    typeof(공동주택목록MappingProfile),

    typeof(가스사용료MappingProfile),
    typeof(건물보험료MappingProfile),
    typeof(급탕비MappingProfile),
    typeof(난방비MappingProfile),
    typeof(생활폐기물수수료MappingProfile),
    typeof(선거관리위원회운영비MappingProfile),
    typeof(수도료MappingProfile),
    typeof(입주자대표회의운영비MappingProfile),
    typeof(전기료MappingProfile),
    typeof(정화조오물수수료MappingProfile),

    typeof(공동주택기본정보MappingProfile),
    typeof(공동주택상세정보MappingProfile),

    typeof(경비비MappingProfile),
    typeof(교육훈련비MappingProfile),
    typeof(기타부대비용MappingProfile),
    typeof(소독비MappingProfile),
    typeof(수선비MappingProfile),
    typeof(승강기유지비MappingProfile),
    typeof(시설유지비MappingProfile),
    typeof(안전점검비MappingProfile),
    typeof(위탁관리수수료MappingProfile),
    typeof(인건비MappingProfile),
    typeof(재해예방비MappingProfile),
    typeof(제사무비MappingProfile),
    typeof(제세공과금MappingProfile),
    typeof(지능형홈네트워크설비유지비MappingProfile),
    typeof(차량유지비MappingProfile),
    typeof(청소비MappingProfile),
    typeof(피복비MappingProfile),

    typeof(단지별적립요율MappingProfile),
    typeof(단지별충당금잔액MappingProfile),
    typeof(단지별월부과액MappingProfile),
    typeof(단지별월사용액MappingProfile)
    );

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddTransient<공동주택단지목록APIService>();
builder.Services.AddTransient<공동주택단지정보APIService>();
builder.Services.AddTransient<공동주택개별관리비APIService>();
builder.Services.AddTransient<공동주택공용관리비APIService>();
builder.Services.AddTransient<공동주택에너지사용정보APIService>();
builder.Services.AddTransient<공동주택장기수선충당금APIService>();
```
<h2 align="center"><strong><span style="color:red;">Dcinside GitHub 갤러리 연재글</span></strong></h2>
https://gall.dcinside.com/mgallery/board/view/?id=github&no=63328&exception_mode=recommend&page=1
https://gall.dcinside.com/mgallery/board/view/?id=github&no=63379&exception_mode=recommend&page=1
