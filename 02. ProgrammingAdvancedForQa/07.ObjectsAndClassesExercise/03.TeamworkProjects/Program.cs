namespace _03.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Team> teams = new List<Team>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] creatorAndTeam = Console.ReadLine()
                                              .Split('-');
                string creator = creatorAndTeam[0];
                string teamName = creatorAndTeam[1];

                //We check if there is another team with the same nane
                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                } //We check if the given user has created another team
                else if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                } //At last, we create a new team
                else
                {
                    Team currentTeam = new Team(teamName, creator);
                    teams.Add(currentTeam);

                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }

            }


            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] userAndTeam = input.Split("->");
                string user = userAndTeam[0];
                string teamName = userAndTeam[1];

                //check if the team with the same name is on the list (false negative)
                if (!teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(u => u.Members.Contains(user) || teams.Any(t => t.Creator == user )))
                { //check if the user is part of another team
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {

                    Team team = teams.First(t => t.Name == teamName);
                    team.Members.Add(user);
                }

                input = Console.ReadLine();
            }

            List<Team> teamsWithMembers = teams.Where(t => t.Members.Count > 0)
                                               .OrderByDescending(t => t.Members.Count)
                                               .ThenBy(t => t.Name)
                                               .ToList();
            List<Team> disbandTeam = teams.Where(t => t.Members.Count == 0)
                                          .OrderBy(t => t.Name)
                                          .ToList();

            foreach (var team in teamsWithMembers)
            {
                Console.WriteLine(team.Name);                            
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in disbandTeam)
            {
                Console.WriteLine(team.Name);
            }

        }
    }
}
