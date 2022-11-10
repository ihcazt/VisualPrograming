namespace P11._1_TicTacToe
{
    public class TicTacToeRecord
    {
        public string Player { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }

        public int Score => Wins - Losses;
    }
}
