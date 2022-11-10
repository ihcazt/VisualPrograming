using System;
using System.Windows.Forms;

namespace P10_ExMixDrix
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TicTacToeForm());
        }
    }
}

// Exercises
// Add a auto player (the computer) to the game.
// Create a 4X4 version to TicTacToe. Winning is still accomplish with a sequence of 3 symbols like the 3X3 TicTacToe version.
