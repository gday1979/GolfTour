namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GolfRanking
    {
        public string Player { get; set; }

        public int Points { get; set; }

        public int MoneyPrize { get; set; }

        public int TournamentsPlayed { get; set; }

        public int Wins { get; set; }

        public int Top10 { get; set; }

        public int Top25 { get; set; }

        public int CutsMade { get; set; }

        public int ScoringAverage { get; set; }

        public int DrivingDistance { get; set; }

        public int DrivingAccuracy { get; set; }

        public int GreensInRegulation { get; set; }

        public int PuttingAverage { get; set; }

        public int SandSaves { get; set; }

        public int Scrambling { get; set; }

        public int AllAroundRanking { get; set; }

        public int MoneyRanking { get; set; }

        public int ScoringRanking { get; set; }
    }
}
