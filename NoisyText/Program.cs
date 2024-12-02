using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NoisyText
{
    static class Program
    {

        [STAThreadAttribute]
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Controller());
        }
    }
}
