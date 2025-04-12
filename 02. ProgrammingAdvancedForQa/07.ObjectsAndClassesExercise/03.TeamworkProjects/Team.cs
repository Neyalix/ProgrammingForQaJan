﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TeamworkProjects
{
    public class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }

        //This a team name
        public string Name { get; set; }
        //This property is creator of a team.
        public string Creator { get; set; }
        //This property collects members of a team.
        public List<string> Members { get; set; }
    }
}
