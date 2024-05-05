## Future Development

As we continue to develop and enhance our project, we are planning to integrate several new APIs from the Ministry of Land, Infrastructure and Transport to enrich our application. These APIs will provide extensive data and functionality related to communal housing management. Here is what we are planning to integrate:

### Planned API Integrations

- **국토교통부_공동주택 입찰결과공지 정보제공 서비스**: This service provides detailed information on the results of bidding for communal housing projects. [More Info](https://www.data.go.kr/data/15059177/openapi.do)

- **국토교통부_공동주택 입찰공고 정보제공 서비스**: This service announces bidding opportunities for communal housing, enabling stakeholders to participate in upcoming projects. [More Info](https://www.data.go.kr/data/15058166/openapi.do)

- **국토교통부_공동주택 유지관리 이력 정보제공 서비스**: This API will provide a comprehensive history of maintenance records for communal housing, enhancing our data analytics capabilities. [More Info](https://www.data.go.kr/data/15058045/openapi.do)

- **국토교통부_공동주택 수의계약 공지 정보제공 서비스**: This service publishes notices of negotiated contracts related to communal housing, providing transparency in contract awarding processes. [More Info](https://www.data.go.kr/data/15057758/openapi.do)

These integrations will allow us to offer more comprehensive services to our users and help communal housing administrators manage their properties more efficiently.

We are excited about the possibilities these new features will bring and we are eager to see how they will improve our service offerings. Stay tuned for updates as we progress in our development journey!

Stay tuned for updates as we progress. We value your feedback to help shape the future of our project!


<h2 align="center"><strong><span style="color:red;">공공데이터 링크 </span></strong></h2>

![image](https://github.com/cheolwo/CommonHouse/assets/25167316/a7fd4c9e-3a2f-4c1b-84d1-fa53b35179af)


- [데이터 API 1 국토교통부_공동주택 기본 정보제공 서비스](https://www.data.go.kr/tcs/dss/selectApiDataDetailView.do?publicDataPk=15058453)
- [데이터 API 2 국토교통부_공동주택 단지 목록제공 서비스](https://www.data.go.kr/tcs/dss/selectApiDataDetailView.do?publicDataPk=15057332)
- [데이터 API 3 국토교통부_공동주택 에너지 사용 정보](https://www.data.go.kr/tcs/dss/selectApiDataDetailView.do?publicDataPk=15012964)
- [데이터 API 4 국토교통부_공동주택관리비(개별사용료)정보제공서비스](https://www.data.go.kr/data/15059469/openapi.do)
- [데이터 API 5 국토교통부_공동주택관리비(공용관리비)정보제공서비스](https://www.data.go.kr/data/15057937/openapi.do)
- [데이터 API 6 국토교통부_공동주택관리비(장기수선충당금)정보서비스](https://www.data.go.kr/tcs/dss/selectApiDataDetailView.do?publicDataPk=15059160)


<h2 align="center"><strong><span style="color:red;">ERD Example</span></strong></h2>

```mermaid
erDiagram
    "공동주택" ||--o{ "개별사용료" : has
    "공동주택" ||--o{ "에너지사용정보" : has
    "공동주택" ||--o{ "공용관리비" : has
    "공동주택" ||--o{ "장기수선충당금" : has

    "개별사용료" {
        string complexCode PK "단지코드"
        string date PK "날짜"
    }
    "에너지사용정보" {
        string complexCode PK "단지코드"
        string date PK "날짜"
    }
    "공용관리비" {
        string complexCode PK "단지코드"
        string date PK "날짜"
    }
    "장기수선충당금" {
        string complexCode PK "단지코드"
        string date PK "날짜"
    }
    "공동주택" {
        string complexCode PK "단지코드"
    }
```

<h2 align="center"><strong><span style="color:red;">Dcinside GitHub 갤러리 연재글</span></strong></h2>
https://gall.dcinside.com/mgallery/board/view/?id=github&no=63328&exception_mode=recommend&page=1
https://gall.dcinside.com/mgallery/board/view/?id=github&no=63379&exception_mode=recommend&page=1
https://gall.dcinside.com/mgallery/board/view/?id=github&no=63509&page=1
