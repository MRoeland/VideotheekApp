using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideotheekApp
{
    public class Film
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Regiseur { get; set; }
        public String Acteurs { get; set; }
        public String Genre { get; set; }
        public float Prijs { get; set; }
        public String Review { get; set; }
        public bool AdultRating { get; set; }
        public String Poster { get; set; }
        public string Rated { get; set; }
        public string Runtime { get; set; }
        public string Plot { get; set; }


        public Film()
        {

        }

        public Film(FilmApiSearchResult f)
        {
            Title = f.Title;
            Regiseur = f.Director;
            Genre = f.Genre;
            Acteurs = f.Actors;
            Prijs = 5;
            Review = "";
            if(f.Rated == "pg-18")
            {
                AdultRating = true;
            }
            else
            {
                AdultRating = false;
            }
            Poster = f.Poster;
            Rated = f.Rated;
            Runtime = f.Runtime;
            Plot = f.Plot;
        }
    }
}
