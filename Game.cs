using System;

// This line added in Step 7.

namespace Lab_Solution
{
    public class Game
    {
        public string Team1 { get; set; }
        public int Team1score { get; set; }
        public string Team2 { get; set; }
        public int Team2score { get; set; }

        public Game() {  }

        public Game(string Team1, int Team1score, 
            string Team2, int Team2score)
        {
            this.Team1 = Team1;
            this.Team1score = Team1score;
            this.Team2 = Team2;
            this.Team2score = Team2score;
        }

        public override String ToString()
        {
            return String.Format("{0) ({1} -- {2} ({3})", 
                Team1, Team1score, Team2, Team2score);
        }
    }
}
