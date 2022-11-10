using System.Collections.Generic;

namespace P11._1_TicTacToe
{
    public class TicTacToeRepository
    {

        private readonly Dictionary<string, TicTacToeRecord> repository = new Dictionary<string, TicTacToeRecord>();

        /// <summary>
        /// Adds new result. 1 - win, -1 loss, 0 - draw.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="result">win: 1, draw: 0, loss: -1</param>
        public void AddResult(string player, int result)
        {
            if (!repository.ContainsKey(player))
            {
                var newRecord = new TicTacToeRecord
                {
                    Player = player
                };

                repository.Add(player, newRecord);
            }

            var playerRecord = repository[player];

            switch (result)
            {
                case -1:
                    ++playerRecord.Losses;
                    break;
                case 0:
                    ++playerRecord.Draws;
                    break;
                case 1:
                    ++playerRecord.Wins;
                    break;
            }
        }

        /// <summary>
        /// Returns a list of the records of the repository ordered by their score.
        /// </summary>
        /// <returns></returns>
        public List<TicTacToeRecord> Bests()
        {
            var bests = new List<TicTacToeRecord>(repository.Values);

            bests.Sort((x, y) => x.Score - y.Score);
            bests.Reverse();

            return bests;
        }
    }
}
