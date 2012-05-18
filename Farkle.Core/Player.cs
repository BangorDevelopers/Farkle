namespace Farkle.Core
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
            Score = 0;
        }
        public string Name { get; set; }
        private int Score { get; set; }
    }
}