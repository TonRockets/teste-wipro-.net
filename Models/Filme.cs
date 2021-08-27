using System;
using System.ComponentModel.DataAnnotations;

namespace LocadoraFilmes.Models
{
    public class Filme
    {
        [Key]
        public int FilmeId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!!")]
        public string Nome { get; set; }
        public string Status { get; set; }
        public int Ano { get; set; }
    
    }
}