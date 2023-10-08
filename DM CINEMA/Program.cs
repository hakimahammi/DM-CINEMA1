using DM_CINEMA;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace dmcinema
{
    class Program
    {

        static void Main(string[] args)
        {
            film monfilm;
            monfilm = new film(1982, ",Science-Fiction,", 01, "L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).", "Blade Runner,");
            Console.WriteLine(monfilm.ToString());

            Acteur MonActeur;
            MonActeur = new Acteur("13/06/1942", 02, "Ford", "Harisson");
            Console.WriteLine(MonActeur.ToString());

            Cinema monCinema;
            monCinema = new Cinema();
            monCinema.SetFilm(monfilm);
            monCinema.SetActeur(MonActeur);
           





        }
    }
}

