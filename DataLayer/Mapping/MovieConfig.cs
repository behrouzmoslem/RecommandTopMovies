using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using DomainClass;

namespace DataLayer.Mapping
{
    public class MovieConfig : EntityTypeConfiguration<Movie>
    {
        public MovieConfig()
        {
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.HasKey(x=>x.Id);
            this.ToTable("Movie");
            this.Property(x => x.LatinName).HasMaxLength(150).IsRequired().IsConcurrencyToken();
            this.Property(x => x.LatinName).HasColumnType("nvarchar");
            this.Property(x => x.PersianName).HasMaxLength(150).IsRequired().IsConcurrencyToken();
            this.Property(x => x.PersianName).HasColumnType("nvarchar");
            this.Property(x => x.Rate).HasColumnType("Float"); 
            this.Ignore(x => x.FullName); 
        }
    }

    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasKey(x => x.Id);
            this.Property(x => x.Rows).HasColumnType("TimeStamp");
            this.Property(x => x.UserName).IsRequired().HasMaxLength(70);
            this.Property(x => x.IsActived).HasColumnType("bit");
        }
    }

    public class UserMovieConfig:EntityTypeConfiguration<UserMovie>
    {
        public UserMovieConfig()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Accepted).HasColumnName("IsAccepted").HasColumnType("Bit");

           

        }
    }

}
