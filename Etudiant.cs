using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalJonathan
{
    internal class Etudiant
    {
        private string code;
        private string nom;
        private string prenom;
        private DateTime dateNaiss;
        private string courriel;
        private int codeProg;

        public Etudiant( string nom, string prenom, DateTime dateNaiss, string courriel, int codeProg)
        {
            
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaiss = dateNaiss;
            this.courriel = courriel;
            this.codeProg = codeProg;
            this.code = createCode();
        }

        public string Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNaiss { get => dateNaiss; set => dateNaiss = value; }
        public string Courriel { get => courriel; set => courriel = value; }
        public int CodeProg { get => codeProg; set => codeProg = value; }


        public string datetoString()
        {
            return dateNaiss.ToString("yyyy-MM-dd");
        }
        public string createCode()
        {
            string code = "";
            code = this.nom.Substring(0, 3);
            code += this.prenom[0];
            code=code.ToUpper();
            return code;
        }

    }
}
