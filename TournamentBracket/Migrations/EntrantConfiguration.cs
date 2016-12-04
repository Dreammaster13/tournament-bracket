using System.Data.Entity.Migrations;
using TournamentBracket.Data;
using TournamentBracket.Models;
using TournamentBracket.Services;

namespace TournamentBracket.Migrations
{
    public class EntrantConfiguration
    {
        public static void Seed(DataContext context) {

            context.SaveChanges();
        }
    }
}
