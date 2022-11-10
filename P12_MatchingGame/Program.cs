using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P12_MatchingGame
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
            Application.Run(new MatchingGameForm());
        }
    }
}

// Exercises
// Add a counter to the number of tries and calculate the success percentages and display them continuously in the title of the form.
//    Also move the final note "Wow - you are a genius!" to the title of the form.

