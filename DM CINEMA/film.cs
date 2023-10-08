using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_CINEMA
{
    public class film
    {
        private int annee;
        private string genre;
        private int idFilm;
        private string resume;
        private string titre;
        private Acteur ActeurPrincipal;


        public film(int annee, string genre, int idFilm, string resume, string titre)
        {
            this.annee = annee;
            this.genre = genre;
            this.idFilm = idFilm;
            this.resume = resume;
            this.titre = titre;
            
        }
        public int GetAnnee()
        {
            return annee;
        }
        public string GetGenre()
        {
            return genre;
        }
        public int GetIdFilm()
        {
            return idFilm;
        }
        public string Getresume()
        {
            return resume;
        }
        public string GetTitre()
        {
            return titre;
        }
        
        public string ToString()
        {
            return titre + " " + annee + " " + genre+ " " + idFilm+ " " + resume;

        }
        public Acteur GetActeurPrincipal()
        {
            return ActeurPrincipal;
        }
     
       
            
        

       

    }
}
