using System;
using System.Collections.Generic;
using System.Text;

namespace RoundRobinApp
{
    class Team
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static List<Team> createListOfTeams()
        {
            int j = 0;
            List<Team> list = new List<Team>();
            for (int i = 0; i < 20; i++)
            {
                j = i + 1;
                Team x = new Team();
                x.Name = $"Equipo {j}";
                list.Add(x);
            }
            return list;
        }

        public static List<Team> splitTeamList(List<Team> list)
        {
            int x = 0;
            int half = list.Count / 2;
            List<Team> newList = new List<Team>();
            for (int i = 0; i < half; i++)
            {
                newList.Add(list[x]);
                list.RemoveAt(x);
            }
            return newList;
        }
    }
}
