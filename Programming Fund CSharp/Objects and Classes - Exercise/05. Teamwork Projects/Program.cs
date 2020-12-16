using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                string[] teamWithCreator = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Team team = new Team(teamWithCreator[1], teamWithCreator[0]);

                if ((teams.FirstOrDefault(x => x.TeamName.ToString() == teamWithCreator[1])) != null)
                {
                    Console.WriteLine($"Team {teamWithCreator[1]} was already created!");
                    continue;
                }
                if ((teams.FirstOrDefault(x => x.Creator.ToString() == teamWithCreator[0])) != null)
                {
                    Console.WriteLine($"{teamWithCreator[0]} cannot create another team!");
                    continue;
                }
               
                    teams.Add(team);
                    Console.WriteLine($"Team {teamWithCreator[1]} has been created by {teamWithCreator[0]}!");
               
            }

            string command = Console.ReadLine();
            while (command!= "end of assignment")
            {
                string[] info = command.Split("->",StringSplitOptions.RemoveEmptyEntries).ToArray();

                string newUser = info[0];
                string teamName = info[1];


                bool isTeamExist = teams.Select(x => x.TeamName).Contains(teamName);
                bool isCreatorExist = teams.Select(x => x.Creator).Contains(newUser);
                bool isMemberExist = teams.Select(x => x.Members)
                    .Any(x=>x.Contains(newUser));


                if (!isTeamExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (isCreatorExist ||isMemberExist)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == teamName);
                    teams[index].Members.Add(newUser);
                }
                command = Console.ReadLine();
            }

            Team[] teamsToDisband = teams.OrderBy(x => x.TeamName)
                .Where(x => x.Members.Count == 0).ToArray();
            Team[] fullTeam = teams.OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .Where(x=>x.Members.Count>0)
                .ToArray();


            StringBuilder strb = new StringBuilder();
            foreach (Team item in fullTeam)
            {


                strb.AppendLine($"{item.TeamName}");
                strb.AppendLine($"- {item.Creator}");

                foreach (var something in item.Members.OrderBy(x=>x))
                {
                    strb.AppendLine($"-- {something}");
                }

            }

            strb.AppendLine("Teams to disband:");

            foreach (var item in teamsToDisband)
            {
                strb.AppendLine(item.TeamName);
            }
            Console.WriteLine(strb);
        }

        class Team
        {
            public string TeamName { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }

            public Team(string teamName, string creator)
            {
                this.TeamName = teamName;
                this.Creator = creator;
                Members = new List<string>();
            }


        }
    }
}
