using System;
using System.Collections.Generic;

namespace RoundRobinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var listB = Team.createListOfTeams();
            var listA = Team.splitTeamList(listB);
            listB.Reverse();

            List<Match> matches = Match.generateMatches(listA, listB);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Jornada {match.MatchDay}: {match.HomeTeam.Name} vs {match.AwayTeam.Name} ");
            }
        }
    }
}
