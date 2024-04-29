using Microsoft.OpenApi.Models;
using 국토교통부_공공데이터Common.개발사용료정보제공서비스;
using 국토교통부_공공데이터Common.공용관리비정보제공서비스;
using 국토교통부_공공데이터Common.국토교통부_공동주택단지목록제공서비스;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스;
using 국토교통부_공공데이터Common.장기수선충당금_정보서비스;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

builder.Services.AddHttpClient();

// 공동주택단지APIService
builder.Services.AddSingleton(provider =>
    {
        var httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();
        var httpClient = httpClientFactory.CreateClient();
        return new 공동주택단지APIService(httpClient, provider.GetRequiredService<IConfiguration>());
    });
// 공동주택개별관리비ApiService 등록
builder.Services.AddSingleton(provider =>
{
    // IHttpClientFactory를 이용해 HttpClient 인스턴스 생성
    var httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();
    var httpClient = httpClientFactory.CreateClient();

    // IConfiguration을 builder.Configuration으로 참조
    return new 공동주택개별관리비ApiService(httpClient, builder.Configuration);
});

// 공동주택공용관리비APIService 등록
builder.Services.AddSingleton(provider =>
{
    var httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();
    var httpClient = httpClientFactory.CreateClient();
    return new 공동주택공용관리비APIService(httpClient, provider.GetRequiredService<IConfiguration>());
});

// 공동주택에너지사용정보APIService 등록
builder.Services.AddSingleton(provider =>
{
    var httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();
    var httpClient = httpClientFactory.CreateClient();
    return new 공동주택에너지사용정보APIService(httpClient, provider.GetRequiredService<IConfiguration>());
});

// 공동주택장기수선충당금APIService 등록
builder.Services.AddSingleton(provider =>
{
    var httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();
    var httpClient = httpClientFactory.CreateClient();
    return new 공동주택장기수선충당금APIService(httpClient, provider.GetRequiredService<IConfiguration>());
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
