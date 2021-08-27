using System.ComponentModel.DataAnnotations;

namespace LocadoraFilmes.Models {

    public class Cliente {
        [Key]
        public int ClienteId { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }

    }
}