using System;
using System.Collections.Generic;

namespace oops_TaskDay1_CricketGame1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cricket team1 = new Cricket();
            team1.TeamName = "Team 1";
            Console.WriteLine();
        }
    }

    public class Cricket
    {
        public string TeamName { get; set; }

        public List<string> Score { get; set; }

        public Cricket()
        {
            Score = new List<string>();
        }
    }

    public class Runs
    {
        enum Boundary
        {
            Four = 4,
            Six = 6
        }
        enum RunsByRunning
        {
            One = 1,
            Two = 2,
            Three = 3
        }
        private class UmpireDecisions

        {
            enum Extras
            {
                wide , noBall , LB
            }
        }



    }




}


