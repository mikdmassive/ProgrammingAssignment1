using System.Diagnostics;
using System.Text.Json;

namespace ProgrammingAssignment1Windform
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        static void CheckFile(string file)
        {
            if (!File.Exists(file))
            {
                File.Create(file).Close();
            }
        }
        static void CheckOrCreateFiles()
        {
            CheckFile(userdatafile);
            CheckFile(matchesfile);
        }

        static string userdatafile = "userdata.json";
        static string matchesfile = "matches.json";
        static List<User> Users = new List<User>();
        static List<Match> Matches = new List<Match>();

        static void Initialise()
        {
            Users.Clear();
            Matches.Clear();
            //user
            if (File.Exists(userdatafile))
            {
                List<string> data = File.ReadAllLines(userdatafile).ToList();
                foreach (string potentialuser in data)
                {
                    if (potentialuser.Length > 0)
                    {
                        Users.Add(JsonSerializer.Deserialize<User>(potentialuser));
                    }
                }
            }
            //matches
            if (File.Exists(matchesfile))
            {
                List<string> data = File.ReadAllLines(matchesfile).ToList();
                foreach (string potentialmatch in data)
                {
                    Debug.WriteLine(potentialmatch);
                    if (potentialmatch.Length > 0)
                    {
                        Matches.Add(JsonSerializer.Deserialize<Match>(potentialmatch));
                    }
                }
            }
        }
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            CheckOrCreateFiles();
            Initialise();
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginScreen(Users));
        }
        public static void Login(User user)
        {
            Debug.WriteLine(Matches.Count);
            Form mainMenu = new MainMenu(user,Matches);//(user, Users, Matches));
            mainMenu.Show();
            
        }
    }
}