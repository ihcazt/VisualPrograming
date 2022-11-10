using P11._1_TicTacToe;
using System.Collections.Generic;
using System.Windows.Forms;

namespace P14_MultiForms
{
    public partial class TicTacToeHallOfFameFrame : Form
    {
        public TicTacToeHallOfFameFrame()
        {
            InitializeComponent();
        }

        public void Add(List<TicTacToeRecord> records)
        {
            //HallOfFamesDataGridView.AutoResizeColumns();
            foreach (var record in records)
            {
                string[] row = { record.Player, record.Wins.ToString(), record.Draws.ToString(), record.Losses.ToString(), record.Score.ToString() };
                HallOfFamesDataGridView.Rows.Add(row);
            }
        }
    }
}
