using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeGameAndFilmOfMe
{
    public class GameCollections :IEnumerable
    {
        private ArrayList grGame = new ArrayList();
        public Game GetGame(int pos) => (Game)grGame[pos];
        public void AddGame(Game g)
        {
            grGame.Add(g);
        }
        public void ClearGame(Game g) { grGame.Clear(); }
        public int Count => grGame.Count;
        IEnumerator IEnumerable.GetEnumerator() => grGame.GetEnumerator();
    }
}
