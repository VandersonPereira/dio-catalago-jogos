using System;

namespace CatalogoJogos.API.Exeptions
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException() : base("Este jogo já está cadastrado") { }
    }
}
