using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeGameAndFilmOfMe
{
    public class Film
    {
        public string nameFilm { get; set; }
        public string authorFilm { get; set; }
        public string categoryFilm { get; set; }
        public string dateFilm { get; set; }
        public Film() { }
        public Film(string name,string author,string category,string date)
        {
            nameFilm = name;
            authorFilm = author;
            categoryFilm = category;
            dateFilm = date;
        }
        public override string ToString()
        {
            return "Name Film: " + nameFilm + "Author: " + authorFilm + "Category: " + categoryFilm + "Date Film: " + dateFilm;
        }
    }
}
