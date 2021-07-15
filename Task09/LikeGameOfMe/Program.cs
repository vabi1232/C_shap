using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace LikeGameAndFilmOfMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Danh sách game và film yêu thích của tôi =))***********");
            Console.WriteLine("Bạn muốn xem danh sach Game hay Film của tôi?:\n 1.Game Love: \n 2.Film Love: \n Press....:");
      
            GameCollection();
            Console.WriteLine("----------------------");
            GenericListGame();
            Console.WriteLine();
            FilmCollection();
            Console.WriteLine("----------------------");
            GenericListFilm();
            Console.WriteLine();
        }
        static void GameCollection()
        {
            Console.WriteLine("********Danh sach Game yeu thich cua toi*******");
            GameCollections myGame = new GameCollections();
            myGame.AddGame(new Game("PUBG Mobile", "VNG Game", "4.0", 2002));
            myGame.AddGame(new Game("Lien Quan Mobile", "Garena", "5.0", 2003));
            myGame.AddGame(new Game("Free Fire", "Garena", "6.0", 2009));
            myGame.AddGame(new Game("Fifa Online 4", "Garena", "2.0", 2002));
            myGame.AddGame(new Game("Tốc chiến", "VNG Game", "2.3", 2002));
            foreach (Game g in myGame)
                Console.WriteLine(g);
        }
        static void GenericListGame()
        {
            Console.WriteLine("----Danh sach game tao bang generic----------");
            List<Game> moreGame = new List<Game>();
            moreGame.Add(new Game("PUBG Mobile", "VNG Game", "4.0", 2002));
            moreGame.Add(new Game("PUBG Mobile", "VNG Game", "4.0", 2002));
            Console.WriteLine(moreGame[0]);
            Console.WriteLine(moreGame[1]);
        }
        static void FilmCollection()
        {
            Console.WriteLine("********Danh sach Film yeu thich cua toi*******");
            FilmCollections myFilm = new FilmCollections();
            myFilm.AddFilm(new Film("SuperMan", "Dc comic", "Science Fiction", "22-11-2002"));
            myFilm.AddFilm(new Film("SipderMan", "Dc comic", "Science Fiction", "22-11-2002"));
            myFilm.AddFilm(new Film("WonderWoman", "Dc comic", "Science Fiction", "22-11-2002"));
            myFilm.AddFilm(new Film("Loki", "Dc comic", "Science Fiction", "22-11-2002"));
            myFilm.AddFilm(new Film("Joker", "Dc comic", "Science Fiction", "22-11-2002"));

            foreach (Film f in myFilm)
                Console.WriteLine(f);
        }
        static void GenericListFilm()
        {
            Console.WriteLine("----Danh sach game tao bang generic----------");
            List<Film> moreFilm = new List<Film>();
            moreFilm.Add(new Film("SuperMan", "Dc comic", "Science Fiction", "22-11-2002"));
            moreFilm.Add(new Film("SpiderMan", "Dc comic", "Science Fiction", "22-11-2002"));
            Console.WriteLine(moreFilm[0]);
            Console.WriteLine(moreFilm[1]);
        }
    }
}
