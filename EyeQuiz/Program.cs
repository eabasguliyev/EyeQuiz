using System;
using System.IO;
using System.Windows.Forms;
using EyeQuiz.Entities;
using EyeQuiz.HashAlgorithms;
using EyeQuiz.Helpers.FileHelpers;

namespace EyeQuiz
{
    static class Program
    {
        public static Database Database { get; private set; }

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

            if (Database == null)
            {
                var sha256 = new Sha256();
                Database = new Database();
                Database.Users.Add(new User()
                {
                    Fullname = "Elgun Abasquliyev",
                    Email = "elgun@gmail.com",
                    Password = sha256.GetHash("elgun1345"),

                });

                JsonHelper.Serialize(Database);
            }

            Application.Run(new Form1());

            //var form2 = new Form2() { User = Database.Users[0] };
            //Application.Run(form2);
        }
    }
}