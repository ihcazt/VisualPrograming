using System.Windows.Forms;

namespace Othello
{
    public partial class HallOfFameForm : Form
    {
        public HallOfFameForm()
        {
            InitializeComponent();
        }

        public void SetNote(string note)
        {
            HallOfFameLabel.Text = note;
        }
    }
}
