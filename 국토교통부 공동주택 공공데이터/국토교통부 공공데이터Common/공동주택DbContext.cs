using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using 국토교통부_공공데이터Common.Model;

namespace 국토교통부_공공데이터Common
{
    public class 공동주택DbContext : DbContext
    {
        public 공동주택DbContext(DbContextOptions<공동주택DbContext> dbContextOptions) 
            : base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new 공동주택Configuration());
            modelBuilder.ApplyConfiguration(new 개별사용료Configuration());
            modelBuilder.ApplyConfiguration(new 에너지사용정보Configuration());
            modelBuilder.ApplyConfiguration(new 공용관리비Configuration());
            modelBuilder.ApplyConfiguration(new 장기수선충당금Configuration());
        }
    }
    public class 공동주택Configuration : IEntityTypeConfiguration<공동주택>
    {
        public void Configure(EntityTypeBuilder<공동주택> builder)
        {
            builder.HasKey(e => e.단지코드); // Primary key 설정
            builder.Property(p => p.상세정보).HasColumnType("nvarchar(max)");
        }
    }
    public class 개별사용료Configuration : IEntityTypeConfiguration<개별사용료>
    {
        public void Configure(EntityTypeBuilder<개별사용료> builder)
        {
            builder.HasKey(e => new { e.단지코드, e.date }); // 복합 키 설정
        }
    }
    public class 에너지사용정보Configuration : IEntityTypeConfiguration<에너지사용정보>
    {
        public void Configure(EntityTypeBuilder<에너지사용정보> builder)
        {
            builder.HasKey(e => new { e.단지코드, e.date }); // 복합 키 설정
        }
    }
    public class 장기수선충당금Configuration : IEntityTypeConfiguration<장기수선충당금>
    {
        public void Configure(EntityTypeBuilder<장기수선충당금> builder)
        {
            builder.HasKey(e => new { e.단지코드, e.date }); // 복합 키 설정
        }
    }
    public class 공용관리비Configuration : IEntityTypeConfiguration<공용관리비>
    {
        public void Configure(EntityTypeBuilder<공용관리비> builder)
        {
            builder.HasKey(e => new { e.단지코드, e.date }); // 복합 키 설정

            // Configure JSON serialization properties
            builder.Property(e => e.인건비Json).HasColumnName("인건비").HasColumnType("nvarchar(max)");
            builder.Property(e => e.제사무비Json).HasColumnName("제사무비").HasColumnType("nvarchar(max)");
            builder.Property(e => e.제세공과금Json).HasColumnName("제세공과금").HasColumnType("nvarchar(max)");
            builder.Property(e => e.차량유지비Json).HasColumnName("차량유지비").HasColumnType("nvarchar(max)");
            builder.Property(e => e.기타부대비용Json).HasColumnName("기타부대비용").HasColumnType("nvarchar(max)");

            // Ensures the JSON strings are ignored for direct database mapping
            // Entity properties that represent the actual data models are marked as NotMapped
            builder.Ignore(e => e.인건비);
            builder.Ignore(e => e.제사무비);
            builder.Ignore(e => e.제세공과금);
            builder.Ignore(e => e.차량유지비);
            builder.Ignore(e => e.기타부대비용);
        }
    }
}
