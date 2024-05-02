using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace 국토교통부_공공데이터Common.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "공동주택",
                columns: table => new
                {
                    단지코드 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    단지명 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    시도 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    시군구 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    읍면동 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    리 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    법정동코드 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    법정동주소 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    분양형태 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    난방방식 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    건축물대장상연면적 = table.Column<double>(type: "float", nullable: false),
                    동수 = table.Column<int>(type: "int", nullable: false),
                    세대수 = table.Column<int>(type: "int", nullable: false),
                    시공사 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    시행사 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    관리사무소연락처 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    관리사무소팩스 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    홈페이지주소 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    단지분류 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    도로명주소 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    호수 = table.Column<int>(type: "int", nullable: false),
                    관리방식 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    복도유형 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    사용승인일 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    관리비부과면적 = table.Column<double>(type: "float", nullable: false),
                    전용면적별세대현황_60이하 = table.Column<double>(type: "float", nullable: false),
                    전용면적별세대현황_60_85 = table.Column<double>(type: "float", nullable: false),
                    전용면적별세대현황_85_135 = table.Column<double>(type: "float", nullable: false),
                    전용면적별세대현황_135초과 = table.Column<double>(type: "float", nullable: false),
                    대장전용면적합계 = table.Column<double>(type: "float", nullable: false),
                    상세정보 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_공동주택", x => x.단지코드);
                });

            migrationBuilder.CreateTable(
                name: "개별사용료",
                columns: table => new
                {
                    date = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    단지코드 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    가스공용금액 = table.Column<long>(type: "bigint", nullable: false),
                    가스전용금액 = table.Column<long>(type: "bigint", nullable: false),
                    건물보험료 = table.Column<long>(type: "bigint", nullable: false),
                    급탕공용금액 = table.Column<long>(type: "bigint", nullable: false),
                    급탕전용금액 = table.Column<long>(type: "bigint", nullable: false),
                    난방공용금액 = table.Column<long>(type: "bigint", nullable: false),
                    난방전용금액 = table.Column<long>(type: "bigint", nullable: false),
                    생활폐기물수수료 = table.Column<long>(type: "bigint", nullable: false),
                    선거관리위원회운영비 = table.Column<long>(type: "bigint", nullable: false),
                    수도공용금액 = table.Column<long>(type: "bigint", nullable: false),
                    수도전용금액 = table.Column<long>(type: "bigint", nullable: false),
                    입주자대표회의운영비 = table.Column<long>(type: "bigint", nullable: false),
                    전기공용금액 = table.Column<long>(type: "bigint", nullable: false),
                    전기전용금액 = table.Column<long>(type: "bigint", nullable: false),
                    정화조오물수수료 = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_개별사용료", x => new { x.단지코드, x.date });
                    table.ForeignKey(
                        name: "FK_개별사용료_공동주택_단지코드",
                        column: x => x.단지코드,
                        principalTable: "공동주택",
                        principalColumn: "단지코드",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "공용관리비",
                columns: table => new
                {
                    date = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    단지코드 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    경비비 = table.Column<long>(type: "bigint", nullable: false),
                    교육훈련비 = table.Column<long>(type: "bigint", nullable: false),
                    소독비 = table.Column<long>(type: "bigint", nullable: false),
                    수선비 = table.Column<long>(type: "bigint", nullable: false),
                    승강기유지비 = table.Column<long>(type: "bigint", nullable: false),
                    시설유지비 = table.Column<long>(type: "bigint", nullable: false),
                    안전점검비 = table.Column<long>(type: "bigint", nullable: false),
                    위탁관리수수료 = table.Column<long>(type: "bigint", nullable: false),
                    재해예방비 = table.Column<long>(type: "bigint", nullable: false),
                    지능형홈네트워크설비유지비 = table.Column<long>(type: "bigint", nullable: false),
                    청소비 = table.Column<long>(type: "bigint", nullable: false),
                    피복비 = table.Column<long>(type: "bigint", nullable: false),
                    인건비 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    제사무비 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    제세공과금 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    차량유지비 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    기타부대비용 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_공용관리비", x => new { x.단지코드, x.date });
                    table.ForeignKey(
                        name: "FK_공용관리비_공동주택_단지코드",
                        column: x => x.단지코드,
                        principalTable: "공동주택",
                        principalColumn: "단지코드",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "에너지사용정보",
                columns: table => new
                {
                    date = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    단지코드 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    난방사용금액 = table.Column<long>(type: "bigint", nullable: false),
                    난방사용량 = table.Column<long>(type: "bigint", nullable: false),
                    급탕사용금액 = table.Column<long>(type: "bigint", nullable: false),
                    급탕사용량 = table.Column<long>(type: "bigint", nullable: false),
                    가스사용금액 = table.Column<long>(type: "bigint", nullable: false),
                    가스사용량 = table.Column<long>(type: "bigint", nullable: false),
                    전기사용금액 = table.Column<long>(type: "bigint", nullable: false),
                    전기사용량 = table.Column<long>(type: "bigint", nullable: false),
                    수도사용금액 = table.Column<long>(type: "bigint", nullable: false),
                    수도사용량 = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_에너지사용정보", x => new { x.단지코드, x.date });
                    table.ForeignKey(
                        name: "FK_에너지사용정보_공동주택_단지코드",
                        column: x => x.단지코드,
                        principalTable: "공동주택",
                        principalColumn: "단지코드",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "장기수선충당금",
                columns: table => new
                {
                    date = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    단지코드 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    월부과액 = table.Column<long>(type: "bigint", nullable: false),
                    월사용액 = table.Column<long>(type: "bigint", nullable: false),
                    적립요율 = table.Column<long>(type: "bigint", nullable: false),
                    충당금잔액 = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_장기수선충당금", x => new { x.단지코드, x.date });
                    table.ForeignKey(
                        name: "FK_장기수선충당금_공동주택_단지코드",
                        column: x => x.단지코드,
                        principalTable: "공동주택",
                        principalColumn: "단지코드",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "개별사용료");

            migrationBuilder.DropTable(
                name: "공용관리비");

            migrationBuilder.DropTable(
                name: "에너지사용정보");

            migrationBuilder.DropTable(
                name: "장기수선충당금");

            migrationBuilder.DropTable(
                name: "공동주택");
        }
    }
}
