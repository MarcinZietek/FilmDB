using FilmDB.Models;

namespace FilmDB.Repositories
{
    public class FilmManager
    {
        public FilmManager AddFilm(FilmModel filmModel)
        {
            return this;
        }

        public FilmManager RemoveFilm(int id)
        {
            return this;
        }

        public FilmManager UpdateFilm(FilmModel filmModel)
        {
            return this;
        }

        public FilmManager ChangeTitle(int id, string newTitle)
        {
            return this;
        }

        public FilmManager GetFilm(int id)
        {
            return null;
        }

        public List<FilmModel> GetFilms()
        {
            return null;
        }
    }
}
