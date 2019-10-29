using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class MiniContext : DbContext
    {
        private readonly string connectionString;
        public MiniContext(string connectionString)
        {
            this.connectionString = connectionString;
            Database.EnsureCreated();
        }
        //public MiniContext(DbContextOptions<MiniContext> options) : base(options)
        //{

        //}

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Team Milan = new Team 
            {
                Name = "AC Milan", 
                CoachName = "Вася Пупкин", 
                BaseCity = "Милан",

            };
            Team Barcelona = new Team
            {
                Name = "FC Barcelona",
                CoachName = "Артур Пирожков",
                BaseCity = "Барселона"
            };
            Team RealMadrid = new Team
            {
                Name = "FC RealMadrid",
                CoachName = "Мистер Бин",
                BaseCity = "Мадрид"
            };
            modelBuilder.Entity<Team>().HasData(Milan);
            modelBuilder.Entity<Team>().HasData(Barcelona);
            modelBuilder.Entity<Team>().HasData(RealMadrid);
            //modelBuilder.Entity<Player>().HasData(
            //    //new { FullName = "Роналдо", Age = 31, Role = "Нападающий", Wage = 563212, TeamId = Barcelona.Id },
            //    new { FullName = "Зидан", Age = 42, Role = "Полузащитник", Wage = 323232, TeamId = Barcelona.Id },
            //    new { FullName = "Роналдо(зубастик)", Age = 46, Role = "Нападающий", Wage = 523145, TeamId = Barcelona.Id },
            //    new { FullName = "Кака", Age = 36, Role = "Полузащитник", Wage = 852321, TeamId = Barcelona.Id },
            //    new { FullName = "Аршавин", Age = 38, Role = "Полузащитник", Wage = 423326, TeamId = Barcelona.Id },
            //    new { FullName = "Ривалдо", Age = 46, Role = "Полузащитник", Wage = 541124, TeamId = Barcelona.Id },
            //    new { FullName = "Дель Пиеро", Age = 45, Role = "Нападающий", Wage = 231879, TeamId = Barcelona.Id },
            //    new { FullName = "Мальдини", Age = 44, Role = "защитник", Wage = 215463, TeamId = Milan.Id },
            //    new { FullName = "Тотти", Age = 39, Role = "Полузащитник", Wage = 654456, TeamId = Milan.Id },
            //    new { FullName = "Хави", Age = 38, Role = "Полузащитник", Wage = 322658, TeamId = Milan.Id },
            //    new { FullName = "Месси", Age = 33, Role = "Нападающий", Wage = 421123, TeamId = Milan.Id },
            //    new { FullName = "Погребняк", Age = 36, Role = "Нападающий", Wage = 522021, TeamId = Milan.Id },
            //    new { FullName = "Коул", Age = 37, Role = "защитник", Wage = 322323, TeamId = Milan.Id },
            //    new { FullName = "Буффон", Age = 38, Role = "вратарь", Wage = 145654, TeamId = Milan.Id },
            //    new { FullName = "Креспо", Age = 39, Role = "Нападающий", Wage = 123321, TeamId = RealMadrid.Id },
            //    new { FullName = "Неста", Age = 42, Role = "защитник", Wage = 658452, TeamId = RealMadrid.Id },
            //    new { FullName = "Вилья", Age = 36, Role = "Нападающий", Wage = 321555, TeamId = RealMadrid.Id },
            //    new { FullName = "Торрес", Age = 34, Role = "Нападающий", Wage = 321545, TeamId = RealMadrid.Id },
            //    new { FullName = "Педро", Age = 33, Role = "полузащитник", Wage = 321544, TeamId = RealMadrid.Id },
            //    new { FullName = "БыстроногийАбилардо", Age = 41, Role = "Полузащитник", Wage = 251458, TeamId = RealMadrid.Id },
            //    new { FullName = "Пеле", Age = 70, Role = "Нападающий", Wage = 113221, TeamId = RealMadrid.Id }
            //    );
            //modelBuilder.Entity<Player>().HasData(new Player { FullName = "Роналдо", Age = 31, Role = "Нападающий", Wage = 563212, TeamId = Barcelona.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Зидан", Age = 42, Role = "Полузащитник", Wage = 323232, TeamId = Barcelona.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Роналдо(зубастик)", Age = 46, Role = "Нападающий", Wage = 523145, TeamId = Barcelona.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Кака", Age = 36, Role = "Полузащитник", Wage = 852321, TeamId = Barcelona.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Аршавин", Age = 38, Role = "Полузащитник", Wage = 423326, TeamId = Barcelona.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Ривалдо", Age = 46, Role = "Полузащитник", Wage = 541124, TeamId = RealMadrid.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Мальдини", Age = 44, Role = "защитник", Wage = 215463, TeamId = RealMadrid.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Тотти", Age = 39, Role = "Полузащитник", Wage = 654456, TeamId = RealMadrid.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Хави", Age = 38, Role = "Полузащитник", Wage = 322658, TeamId = RealMadrid.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Месси", Age = 33, Role = "Нападающий", Wage = 421123, TeamId = RealMadrid.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Погребняк", Age = 36, Role = "Нападающий", Wage = 522021, TeamId = Milan.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Коул", Age = 37, Role = "защитник", Wage = 322323, TeamId = Milan.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Буффон", Age = 38, Role = "вратарь", Wage = 145654, TeamId = Milan.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Креспо", Age = 39, Role = "Нападающий", Wage = 123321, TeamId = Milan.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Неста", Age = 42, Role = "защитник", Wage = 658452, TeamId = Milan.Id/*, TeamId = Barcelona.Id */});
            modelBuilder.Entity<Player>().HasData(new Player { FullName = "Вилья", Age = 36, Role = "Нападающий", Wage = 321555, TeamId = Milan.Id/*, TeamId = Barcelona.Id */});
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder.UseLazyLoadingProxies().EnableSensitiveDataLogging().UseSqlServer(connectionString);
        }
    }
}
