using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeGameAndFilmOfMe
{
    public class FilmCollections:IEnumerable
    {
        private ArrayList fFilm = new ArrayList();
        public Film GetFilm(int pos) => (Film)fFilm[pos];
        public void AddFilm(Film f)
        {
            fFilm.Add(f);
        }
        public void ClearFilm(Film f)
        {
            fFilm.Clear();
        }
        public int Count => fFilm.Count;
        IEnumerator IEnumerable.GetEnumerator() => fFilm.GetEnumerator();
    }
}
