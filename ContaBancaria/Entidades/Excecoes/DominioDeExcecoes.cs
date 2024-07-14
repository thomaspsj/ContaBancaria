using System;

namespace ContaBancaria.Entidades.Excecoes
{
    class DominioDeExcecoes(string message) : ApplicationException(message)
    {
    }
}
