

namespace Exercicio3
{
    public class Conta
    {
        public double Saldo {  get; set; }

        public void Sacar(double valor)
        {
            this.Saldo -= valor;

        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public double ObterSaldo()
        {
            return this.Saldo;
        }
    }
}
