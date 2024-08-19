using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalJonathan
{
    internal class ProgrammeEtude
    {
        private int code;
        private string domaine;
        private string nom_Programme;
        private int nb_Heure;

        public ProgrammeEtude(int code, string domaine, string nom_Programme, int nb_Heure)
        {
            this.code = code;
            this.domaine = domaine;
            this.nom_Programme = nom_Programme;
            this.nb_Heure = nb_Heure;
        }

        public int Code { get => code; set => code = value; }
        public string Domaine { get => domaine; set => domaine = value; }
        public string Nom_Programme { get => nom_Programme; set => nom_Programme = value; }
        public int Nb_Heure { get => nb_Heure; set => nb_Heure = value; }
    }
}
