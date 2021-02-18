using System;
using System.Collections.Generic;
using System.Text;

namespace RoundRobinApp
{
    class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private int matchDay;

        public Team HomeTeam
        {
            get { return homeTeam; }
            set { homeTeam = value; }
        }

        public Team AwayTeam
        {
            get { return awayTeam; }
            set { awayTeam = value; }
        }

        public int MatchDay
        {
            get { return matchDay; }
            set { matchDay = value; }
        }

        public static List<Match> generateMatches(List<Team> listTeamsA, List<Team> listTeamsB)
        {
            List<Match> matches = new List<Match>();
            int div = 2;
            int numberOfTeams = listTeamsA.Count + listTeamsB.Count;
            int numberOfMatches = (numberOfTeams / div) * (numberOfTeams - 1);
            bool isEmpty = matches.Count == 0;
            int i = 1;

            while (numberOfMatches != 0 && i <= numberOfTeams - 1)
            {

                int matchCounter = 0;
                foreach (Team teamA in listTeamsA)
                {
                    Match match = new Match();
                    match.HomeTeam = teamA;
                    match.AwayTeam = listTeamsB[matchCounter++];
                    match.MatchDay = i;
                    matches.Add(match);
                    --numberOfMatches;

                }
                i++;
                listTeamsB.Add(listTeamsA[listTeamsA.Count - 1]);
                listTeamsA.RemoveAt(listTeamsA.Count - 1);
                listTeamsA.Add(listTeamsB[0]);
                listTeamsB.RemoveAt(0);

            }


            return matches;
        }
    }
}
