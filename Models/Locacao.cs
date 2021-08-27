using System;

namespace LocadoraFilmes.Models
{
    public class Locacao
    {
        public int LocacaoId { get; set; }
        public Cliente Cliente { get; set; }
        public Filme Filme { get; set; }
        public DateTime DtLocacao { get; set; }
        public DateTime DtDevolucao { get; set; }

    }
}