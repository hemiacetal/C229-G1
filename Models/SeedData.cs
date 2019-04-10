using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace C229_G1.Models
{
    public static  class SeedData
    {
        public static void EnsurePoputated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                    .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();


            if (!context.Clubs.Any())
            {

                context.Clubs.AddRange(
                    new Club { ClubFullName = "Chelsea Football Club", Country = "England", HeadCoachName = "Maurizio Sarri", Ground = "Stamford Bridge"},
                    new Club { ClubFullName = "Futbol Club Barcelona", Country = "Spain", HeadCoachName = "	Ernesto Valverde", Ground = "Camp Nou"},
                    new Club { ClubFullName = "Liverpool Football Club", Country = "England", HeadCoachName = "	Jürgen Klopp", Ground = "Anfield"}

                );
                context.SaveChanges();
            }


            if (!context.Players.Any())
            {
                context.Players.AddRange(
                new Player
                {
                    PlayerName = "Kepa Arrizabalaga",
                    Age = 24,
                    CountryOfBirth = "Spain",
                    PlayingPosition = "Goalkeeper",
                    ClubID = context.Clubs.FirstOrDefault(cl => cl.ClubFullName == "Chelsea Football Club").ClubID
                }, 
                new Player
                {
                    PlayerName = "Antonio Rüdiger",
                    Age = 26,
                    CountryOfBirth = "Germany",
                    PlayingPosition = "Defender",
                    ClubID = context.Clubs.FirstOrDefault(cl => cl.ClubFullName == "Chelsea Football Club").ClubID
                },
                new Player
                {
                    PlayerName = "Marcos Alonso",
                    Age = 28,
                    CountryOfBirth = "Spain",
                    PlayingPosition = "Defender",
                    ClubID = context.Clubs.FirstOrDefault(cl => cl.ClubFullName == "Chelsea Football Club").ClubID
                },



                new Player
                {
                    PlayerName = "Marc-André ter Stegen",
                    Age = 26,
                    CountryOfBirth = "Germany",
                    PlayingPosition = "Goalkeeper",
                    ClubID = context.Clubs.FirstOrDefault(cl => cl.ClubFullName == "Futbol Club Barcelona").ClubID
                },
                new Player
                {
                    PlayerName = "Nélson Semedo",
                    Age = 25,
                    CountryOfBirth = "Portugal",
                    PlayingPosition = "Defender",
                    ClubID = context.Clubs.FirstOrDefault(cl => cl.ClubFullName == "Futbol Club Barcelona").ClubID
                },
                new Player
                {
                    PlayerName = "	Gerard Piqué",
                    Age = 32,
                    CountryOfBirth = "Spain",
                    PlayingPosition = "Defender",
                    ClubID = context.Clubs.FirstOrDefault(cl => cl.ClubFullName == "Futbol Club Barcelona").ClubID
                },



                new Player
                {
                    PlayerName = "Fabinho",
                    Age = 25,
                    CountryOfBirth = "Brazil",
                    PlayingPosition = "Midfielder",
                    ClubID = context.Clubs.FirstOrDefault(cl => cl.ClubFullName == "Liverpool Football Club").ClubID
                },
                new Player
                {
                    PlayerName = "Virgil van Dijk",
                    Age = 27,
                    CountryOfBirth = "Netherlands",
                    PlayingPosition = "Defender",
                    ClubID = context.Clubs.FirstOrDefault(cl => cl.ClubFullName == "Liverpool Football Club").ClubID
                },
                new Player
                {
                    PlayerName = "Georginio Wijnaldum",
                    Age = 28,
                    CountryOfBirth = "Netherlands",
                    PlayingPosition = "Midfielder",
                    ClubID = context.Clubs.FirstOrDefault(cl => cl.ClubFullName == "Liverpool Football Club").ClubID
                }
                );

            }
            context.SaveChanges();
        }
    }
}

