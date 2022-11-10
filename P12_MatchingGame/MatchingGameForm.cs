using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace P12_MatchingGame
{
    public partial class MatchingGameForm : Form
    {
        private readonly Timer ticTacTimer = new Timer();
        private const int WAITING = 750; // milliseconds

        public MatchingGameForm()
        {
            InitializeComponent();

            // set the timer interval
            ticTacTimer.Interval = WAITING;

            // set the timer Tick event handler
            ticTacTimer.Tick += TicTacTimer_Tick;
        }

        // some constants
        private const int N = 4;
        private const int CARD_SIZE = 110;
        private const int PADDING = 5;
        private const int UP_PADDING = 5;
        private readonly Color FORGROUND_COLOR = Color.BlueViolet;
        private readonly Color BACKGROUND_COLOR = Color.CornflowerBlue;
        private const string WINNING_MESSAGE = "Wow - you are a genius!";

        // The symbols to display. should be of size NxN.
        private static readonly List<string> icons = new List<string>
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        /// <summary>
        /// Initiates the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MatchingGameForm_Load(object sender, EventArgs e)
        {
            // set the auto size
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoSize = true;

            // the title of the form
            Text = "Matching Game";

            // the board initialization
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    var card = new Label
                    {
                        Name = "card" + i + j,
                        Size = new Size(CARD_SIZE, CARD_SIZE),
                        Location = new Point(
                            (PADDING + CARD_SIZE) * i + PADDING,
                            UP_PADDING + (CARD_SIZE + PADDING) * j + PADDING),
                        Margin = new Padding(PADDING),
                        BackColor = BACKGROUND_COLOR,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Webdings", 60, FontStyle.Bold),
                        //ForeColor = FORGROUND_COLOR,
                    };
                    Controls.Add(card);
                    card.Click += Card_Click;
                }
            }

            // assign icons to the cards
            AssignIconsToCards();
        }

        /// <summary>
        /// Assign symbols to cards
        /// </summary>
        private void AssignIconsToCards()
        {
            Random random = new Random();
            foreach (Control control in Controls)
            {
                Label label = control as Label;
                int rnd = random.Next(icons.Count);
                label.Text = icons[rnd];
                // hide the symbol
                label.ForeColor = label.BackColor;
                icons.RemoveAt(rnd);
            }
        }

        private Label firstCard;
        private Label secondCard;

        private void Card_Click(object sender, EventArgs e)
        {
            // The timer is running - skip
            if (ticTacTimer.Enabled)
            {
                return;
            }

            Label label = sender as Label;

            // If the card already flipped - skip
            if (label.ForeColor != label.BackColor)
            {
                return;
            }

            // If the click on the first card - register and continue
            if (firstCard == null)
            {
                firstCard = label;
                firstCard.ForeColor = FORGROUND_COLOR;
                return;
            }

            // The click was on the second card
            secondCard = label;
            secondCard.ForeColor = FORGROUND_COLOR;

            // If the cards are identical -
            if (firstCard.Text == secondCard.Text)
            {
                // clear cards
                firstCard = null;
                secondCard = null;

                // check to see if the player won
                if (IsWinning())
                {
                    MessageBox.Show(WINNING_MESSAGE);
                }
            }
            else // the cards aren't identical
            {
                ticTacTimer.Start();
            }
        }

        private bool IsWinning()
        {
            foreach (Control control in Controls)
            {
                Label label = control as Label;
                if (label.ForeColor == label.BackColor)
                    return false;
            }
            return true;
        }

        private void TicTacTimer_Tick(object sender, EventArgs e)
        {
            ticTacTimer.Stop();
            firstCard.ForeColor = firstCard.BackColor;
            secondCard.ForeColor = secondCard.BackColor;
            firstCard = null;
            secondCard = null;
        }
    }
}
