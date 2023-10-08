using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_CINEMA
{
    public class Cinema
    {
        private Cinema cine;
        private List<Acteur>LesActeur;
        private List<film> Lesfilm;
        private film lesFilm;
        private Acteur lesActeurs;
        

        public Cinema() {

            this.LesActeur = new List<Acteur>();
                int count = LesActeur.Count(); ;
            this.Lesfilm = new List<film>();
            int count2 = Lesfilm.Count();
            
            
        }
        public int GetActeur(int id)
        {
            return id;
        }
        public int GetFilm(int idFilm)
        {
            return idFilm;
        }

       public List<Acteur> nbActeur()
        {

            return LesActeur;

        }
        public void SetFilm(film film)
        {
            film = film;
            Lesfilm.Add(film);

        }
       
        public void SetActeur(Acteur acteur)
        {

            acteur = acteur;
            LesActeur.Add(acteur);


        }
        public film GetlesFilm() 
        {
            return lesFilm;
        
        }
        public Acteur GetlesActeurs()
        {

            return lesActeurs;

        }
            
        
        

            

        

        
        



    }
    
}
