using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {

       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int x1 = 1;
            int x2 = 2;
            int x3 = 3;
            int x4 = 4;
             string B = "It will work!!";
            string Y = "5";
            string name = "MMMMMMMMMMMMMMMMMMMMMMMM";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
   
}
