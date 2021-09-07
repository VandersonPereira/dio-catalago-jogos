using System;

namespace CatalogoJogos.API.Entities
{
    public class Jogo
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public decimal Preco { get; set; }
    }
}
