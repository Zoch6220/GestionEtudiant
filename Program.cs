namespace ProjetFinalJonathan
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        ///
        static public List<ProgrammeEtude> listeProgramme = new List<ProgrammeEtude>();
        static public List<Etudiant> listeEtudiant = new List<Etudiant>();
        static private List<User> lst_user=new List<User>();
        [STAThread]
        static void Main()
        {
            lst_user.Add(new User("admin",1234));
            lst_user.Add(new User("test",5678));
            //listeProgramme.Add(new ProgrammeEtude(1, "Technique de l'informatique","Technique Interface", 105));
            //listeProgramme.Add(new ProgrammeEtude(2, "Technique de l'informatique", "Technique Programmation", 30));
            //listeEtudiant.Add(new Etudiant("Richard","Jonathan",new DateTime(1989,10,19),"jon@ggg.com",1));
            //listeEtudiant.Add(new Etudiant("Grenier", "Alex", new DateTime(1999, 06, 29), "alll@ggg.com",2));
            //listeEtudiant.Add(new Etudiant("Therrien", "Bianca", new DateTime(1980, 01, 29), "bbbb@ggg.com", 2));
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new form_Auth());
        }

        static  public int SearchProgramme(int p_code)
        {
            int idx = 0;
            
            foreach(ProgrammeEtude item in listeProgramme)
            {
                if (item.Code == p_code)
                {
            
                    idx  =listeProgramme.IndexOf(item);
                    return idx;
                }
               
            }
            return -1;
        }

        static public int SearchEtudiant(string p_code)
        {
            int idx = 0;

            foreach (Etudiant item in listeEtudiant)
            {
                
                if (item.Code.Equals(p_code)) 
                {

                    idx = listeEtudiant.IndexOf(item);
                    return idx;
                }
               
            }
            return -1;
        }
        static public bool SearchUser(string p_username, int p_code)
        {
            foreach (User item in lst_user)
            {
                if (item.Username.Equals(p_username) && item.Code==p_code)
                {
                    return true;
                }
            }
            return false;
        }
        struct User
        {
            private string username;
            private int code;

            public User(string username, int code)
            {
                this.username = username;
                this.code = code;
            }

            public string Username { get => username; set => username = value; }
            public int Code { get => code; set => code = value; }
        }
    }
}