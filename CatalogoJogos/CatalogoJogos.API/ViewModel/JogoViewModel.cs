using System;

namespace CatalogoJogos.API.ViewModel
{
    public class JogoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public decimal Preco { get; set; }
    }
}
