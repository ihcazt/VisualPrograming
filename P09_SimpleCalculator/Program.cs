using System;
using System.Windows.Forms;

namespace P09_SimpleCalculator
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
            Application.Run(new SimpleCalculatorForm());
        }
    }
}

// Exercises
// Make the calculator to work with real numbers.
// Add to the calculator the operation of power (use the symbol '^').

