using FilmDB.Controllers.Data;
using FilmDB.Models;

namespace FilmDB.Repositories
{
    public class FilmManager
    {
        private FilmContext _context;
        public FilmManager(FilmContext context)
        {
            _context = context;
        }
        public FilmManager AddFilm(FilmModel filmModel)
        {
            _context.Films.Add(filmModel);
            _context.SaveChanges();
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
