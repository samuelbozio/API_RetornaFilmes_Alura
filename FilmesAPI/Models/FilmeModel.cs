using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class FilmeModel
    {


        [Required(ErrorMessage = "Necessário informar o título.")]
        [MaxLength(255)]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Necessário informar o gênero")]
        [MaxLength(255)]
        public string Genero { get; set; }1
        [Required(ErrorMessage = "Necessário informar a duração.")]
        public int Duracao { get; set; }
        
        public int Id { get; set; }




    }
}
