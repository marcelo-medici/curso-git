using System.Globalization;

namespace Banco
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
            Saldo = 0;
        }

        public Conta(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
        public void Sacar(double valor)
        {
            this.Saldo -= valor + 5.00;
        }

        public override string ToString()
        {
            return "Conta " 
                + Numero.ToString()
                + ", Titular: "
                + Nome
                + ", Saldo: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
