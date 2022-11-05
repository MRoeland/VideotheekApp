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

    }
}
