using ContaBancaria.Entidades.Excecoes;

namespace ContaBancaria.Entidades
{
    class ContaCorrente
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public ContaCorrente()
        {
        }

        public ContaCorrente(int numero, string titular, double saldo, double limiteSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if (valor > LimiteSaque)
            {
                throw new DominioDeExcecoes("O valor excedeu o limite de saque");
            }
            if (valor > Saldo)
            {
                throw new DominioDeExcecoes("Saldo insuficiênte");
            }

            Saldo -= valor;
        }
    }
}
