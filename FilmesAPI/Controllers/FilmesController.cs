using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{

    [ApiController]
    [Route("{controller}")]
    public class FilmesController : ControllerBase
    {

        private static List<FilmeModel> Filmes = new List<FilmeModel>();
        private static int Id = 0;


        [HttpPost]
        public List<FilmeModel> AddLivros(FilmeModel filme)
        {
            filme.Id = Id++;
            Filmes.Add(filme);
            return Filmes;
        }

        [HttpGet]
        public IEnumerable<FilmeModel> ShowFilmes(int skip = 0, int take = 0)
        {
            return Filmes.Skip(skip).Take(take);
        }

        [HttpGet("{id}")]
        public IActionResult FilmePorId(int Id)
        {
            var filme = Filmes.FirstOrDefault(x => x.Id == Id);
            if (filme == null)
                return NotFound();
            else
                return Ok();
        }

        [HttpDelete]
        public void DeletaFilmes()
        {
            Filmes.Clear();
        }



    }
}
