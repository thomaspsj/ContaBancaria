using System.Globalization;
using ContaBancaria.Entidades;
using ContaBancaria.Entidades.Excecoes;

namespace ContaBancaria
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite os dados da conta: ");
            Console.Write("Número: ");
             int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do Titular: ");
            string titular = Console.ReadLine();
            Console.Write("Saldo Inicial: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Limite de Saque: ");
            double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ContaCorrente cc = new(numero, titular, saldo, limiteSaque);

            Console.WriteLine();
            Console.WriteLine("Conta criada com sucesso!");
            Console.Write("Informe o valor do saque desejado: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                cc.Saque(valor);
                Console.WriteLine($"Saldo atual: {cc.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (DominioDeExcecoes ex)
            {
                Console.WriteLine($"Erro no saque: {ex.Message}");
            }
        }
    }
}