using System;
using System.IO;
using System.Windows.Forms;
using EyeQuiz.Entities;
using EyeQuiz.Helpers.FileHelpers;

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

            JsonHelper.FileName = "Database.json";

            if (File.Exists(JsonHelper.FileName))
            {
                Database = JsonHelper.Deserialize();
            }
            else
            {
                Database = new Database();
                Database.Users.Add(new User()
                {
                    Fullname = "Elgun Abasquliyev",
                    Email = "elgun@gmail.com",
                    Password = "elgun1345",

                });
            }

            var form2 = new Form2(){User = Database.Users[0]};
            
            //Application.Run(new Form1());
            
            Application.Run(form2);
        }
    }
}
