using Common.Configuration;
using Common.Model;
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
    public class 공동주택Configuration : IEntityTypeConfiguration<공동주택>
    {
        public void Configure(EntityTypeBuilder<공동주택> builder)
        {
            throw new NotImplementedException();
        }
    }
    public class 개별사용료Configuration : IEntityTypeConfiguration<개별사용료>
    {
        public void Configure(EntityTypeBuilder<개별사용료> builder)
        {
            throw new NotImplementedException();
        }
    }
    public class 에너지사용정보Configuration : IEntityTypeConfiguration<에너지사용정보>
    {
        public void Configure(EntityTypeBuilder<에너지사용정보> builder)
        {
            throw new NotImplementedException();
        }
    }
    public class 장기수선충당금Configuration : IEntityTypeConfiguration<장기수선충당금>
    {
        public void Configure(EntityTypeBuilder<장기수선충당금> builder)
        {
            throw new NotImplementedException();
        }
    }
    public class 공용관리비Configuration : IEntityTypeConfiguration<공용관리비>
    {
        public void Configure(EntityTypeBuilder<공용관리비> builder)
        {

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
