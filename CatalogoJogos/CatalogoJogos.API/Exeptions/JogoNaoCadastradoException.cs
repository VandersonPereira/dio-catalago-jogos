using System;

namespace CatalogoJogos.API.Exeptions
{
    public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException() : base("Este jogo não está cadastrado") { }
    }
}
