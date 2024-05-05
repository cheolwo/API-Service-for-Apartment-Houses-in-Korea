<h2 align="center"><strong><span style="color:red;">프로세스</span></strong></h2>

![image](https://github.com/cheolwo/CommonHouse/assets/25167316/fa4bca89-aecb-46d4-a4cc-01f7712c5c87)


<h2 align="center"><strong><span style="color:red;">ERD</span></strong></h2>

![image](https://github.com/cheolwo/CommonHouse/assets/25167316/7f60bf14-a40e-4060-9a13-8c9a832c6bb1)

<h2 align="center"><strong><span style="color:red;">공통적인 모듈 간 관계</span></strong></h2>

![image](https://github.com/cheolwo/CommonHouse/assets/25167316/94547669-dcb0-4932-a3d7-fd4afc3a9770)

<h2 align="center"><strong><span style="color:red;">Dcinside GitHub 갤러리</span></strong></h2>
https://gall.dcinside.com/mgallery/board/view/?id=github&no=63328&exception_mode=recommend&page=1
https://gall.dcinside.com/mgallery/board/view/?id=github&no=63379&exception_mode=recommend&page=1


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
   "공공데이터ServiceKey": ""
}

```서비스컨테이너

