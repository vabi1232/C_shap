using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeGameAndFilmOfMe
{
    public class Game
    {
        public int idGame { get; set; }
        public string nameGame { get; set; }
        public string authorGame { get; set; }
        public string versionGame { get; set; }
        public Game() { }
        public Game(string name, string author, string version,int id)
        {
            idGame = id;
            nameGame = name;
            authorGame = author;
            versionGame = version;
        }
        public override string ToString()
        {
            return "ID Game: " +idGame+ "Name Game: " +nameGame+ "Author: " +authorGame+ "Version: "+versionGame;
        }
    }
}
