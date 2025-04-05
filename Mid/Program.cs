using System;

namespace Mid
{
    public class Player
    {
        private string playerName;
        private string playerID;
        private string teamName;

        public string PlayerID
        {
            get { return playerID; }
            set { this.playerID = value; }
        }
        public string PlayerName
        {
            get { return playerName; }
            set { this.playerName = value; }
        }
        public string TeamName
        {
            get { return teamName; }
            set { this.teamName = value; }
        }

        public Player()
        {
            this.playerID = "p-1";
            this.playerName = "Unknown";
            this.teamName = "Ban";
        }

        public Player(string playerID, string playerName, string teamName)
        {
            this.playerID = playerID;
            this.playerName = playerName;
            this.teamName = teamName;
        }

        public static void PlayerPerformance(Player player, double a = 0.0, double b = 0.0)
        {
            if (player is Batsman batsman)
            {
                if (a >= 50)
                {
                    Console.WriteLine(batsman.PlayerName + " is a Batsman and gets an award for a batting average of " + a + "!");
                }
            }
            else if (player is Bowler bowler)
            {
                if (b >= 1000)
                {
                    Console.WriteLine(bowler.PlayerName + " is a Bowler and gets an award for taking " + b + " wickets!");
                }
            }
            else if (player is AllRounder allRounder)
            {
                if (a >= 1000 && b >= 100)
                {
                    Console.WriteLine(allRounder.PlayerName + " is an All-Rounder and gets an award for scoring " + a + " runs and taking " + b + " wickets!");
                }
            }
        }


        public virtual void ShowInfo()
        {
            Console.WriteLine("PlayerID: " + playerID);
            Console.WriteLine("PlayerName: " + playerName);
            Console.WriteLine("TeamName: " + teamName);
        }
    }

    public class Batsman : Player
    {
        private double totalRun;
        private double battingAvg;

        public double TotalRun
        {
            get { return totalRun; }
            set { this.totalRun = value; }
        }
        public double BattingAvg
        {
            get { return battingAvg; }
            set { this.battingAvg = value; }
        }

        public Batsman() : base()
        {
            this.totalRun = 0.0;
            this.battingAvg = 0.0;
        }

        public Batsman(string playerID, string playerName, string teamName, double totalRun, double battingAvg) : base(playerID, playerName, teamName)
        {
            this.totalRun = totalRun;
            this.battingAvg = battingAvg;
            PlayerPerformance(this, battingAvg);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Total Run: " + totalRun);
            Console.WriteLine("Batting Average: " + battingAvg);
        }
    }

    public class Bowler : Player
    {
        private double totalWickets;

        public double TotalWickets
        {
            get { return totalWickets; }
            set { this.totalWickets = value; }
        }

        public Bowler() : base()
        {
            this.totalWickets = 0.0;
        }

        public Bowler(string playerID, string playerName, string teamName, double totalWickets) : base(playerID, playerName, teamName)
        {
            this.totalWickets = totalWickets;
            PlayerPerformance(this, b: totalWickets);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Total Wickets: " + totalWickets);
        }
    }

    public class AllRounder : Player
    {
        private double totalRun;
        private double totalWickets;

        public double TotalRun
        {
            get { return totalRun; }
            set { this.totalRun = value; }
        }
        public double TotalWickets
        {
            get { return totalWickets; }
            set { this.totalWickets = value; }
        }

        public AllRounder() : base()
        {
            this.totalRun = 0.0;
            this.totalWickets = 0.0;
        }

        public AllRounder(string playerID, string playerName, string teamName, double totalRun, double totalWickets) : base(playerID, playerName, teamName)
        {
            this.totalRun = totalRun;
            this.totalWickets = totalWickets;
            PlayerPerformance(this, totalRun, totalWickets);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Total Run: " + totalRun);
            Console.WriteLine("Total Wickets: " + totalWickets);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[3];

            players[0] = new Batsman("p-1", "Numan", "Ban", 10000, 55);
            players[1] = new Bowler("p-2", "Rubel", "Ban", 1000);
            players[2] = new AllRounder("p-3", "Shakib", "Ban", 1000, 150);

            foreach (var player in players)
            {
                player.ShowInfo();
                Console.WriteLine();
            }
        }
    }
}
