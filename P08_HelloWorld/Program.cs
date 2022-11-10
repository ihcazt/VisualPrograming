using System;
using System.Windows.Forms;

namespace P08_HelloWorld
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
            Application.Run(new HelloWorrldForm());
        }
    }
}

// Exercises
// Write a form that display your name. Make it as nice as you can using styles options like colors and font style and size.
