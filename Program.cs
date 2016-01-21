///////////////////////////////
// Created by: Markus Lidrot //
// Date: 2016-01-02          //
// Program.cs                //
///////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlayTheMonster
{
    /// <summary>
    /// The program was created by Markus Lidrot as the final projekt in the Course MAH-58053 at Malmö Högskola.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
