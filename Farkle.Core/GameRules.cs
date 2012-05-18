namespace Farkle.Core
{
    public class GameRules
    {
        public GameRules()
        {
            // default rules
            WinningScore = 10000;
            ThresholdStartingScore = 500;
        }

        public int WinningScore { get; set; }
        public int ThresholdStartingScore { get; set; }
    }
}