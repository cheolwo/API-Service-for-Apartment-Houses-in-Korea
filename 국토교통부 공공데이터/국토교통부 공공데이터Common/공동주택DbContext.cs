using Common.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.Model.ComplexExpense;

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
    public class 공동주택Configuration : CenterConfiguration<공동주택>
    {
        public override void Configure(EntityTypeBuilder<공동주택> builder)
        {
            base.Configure(builder);
        }
    }
    public class 개별사용료Configuration : EntityConfiguration<개별사용료>
    {
        public override void Configure(EntityTypeBuilder<개별사용료> builder)
        {
            base.Configure(builder);
        }
    }
    public class 에너지사용정보Configuration : EntityConfiguration<에너지사용정보>
    {
        public override void Configure(EntityTypeBuilder<에너지사용정보> builder)
        {
            base.Configure(builder);
        }
    }
    public class 장기수선충당금Configuration : EntityConfiguration<장기수선충당금>
    {
        public override void Configure(EntityTypeBuilder<장기수선충당금> builder)
        {
            base.Configure(builder);
        }
    }
    public class 공용관리비Configuration : EntityConfiguration<공용관리비>
    {
        public override void Configure(EntityTypeBuilder<공용관리비> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.인건비)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                    v => JsonConvert.DeserializeObject<인건비>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));

            builder.Property(e => e.제사무비)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                    v => JsonConvert.DeserializeObject<제사무비>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));

            builder.Property(e => e.제세공과금)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                    v => JsonConvert.DeserializeObject<제세공과금>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));

            builder.Property(e => e.차량유지비)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                    v => JsonConvert.DeserializeObject<차량유지비>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
        }
    }
}
