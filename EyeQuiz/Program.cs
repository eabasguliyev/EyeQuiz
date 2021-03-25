using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeQuiz
{
    static class Program
    {
        public static Database Database { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Database = new Database();

            Application.Run(new Form1());
            //Application.Run(new Form2());
        }
    }
}
