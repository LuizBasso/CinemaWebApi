using System.ComponentModel.DataAnnotations;

namespace Cinema.WebApi.Models
{
    public class NovoFilmeInputModel
    {
        [Required]
        public string Titulo { get; set; }
        [Required]
        public int Duracao { get; set; }
        [Required]
        public string Sinopse { get; set; }
    }
}
