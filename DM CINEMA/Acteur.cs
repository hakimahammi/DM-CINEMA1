using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_CINEMA
{
    public class Acteur
    {
        private string anneeNaissance;
        private int id;
        private string nom;
        private string prenom;

        public Acteur(string anneeNaissance, int id, string nom, string prenom)
        {
            this.anneeNaissance = anneeNaissance;
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;

    }
        public string GetNom()
        {
            return nom;
        }
        public int GetId()
        {
            return id;
        }
        public string GetAnneeNaissance()
        {
            return anneeNaissance;
        }
        public string GetPrenom()
        {
            return prenom;
        }
        public string ToString()
        {
            return nom + " " + prenom + " " + anneeNaissance;

        }



    }






}
