namespace Exercicio3
{
    public class Program
    {
        public static void Main()
        {
            ContaPoupanca cP = new ContaPoupanca();
            cP.Saldo = 500;
            cP.Depositar(300);
            cP.Sacar(150);
            Console.WriteLine("Conta poupança = "+ cP.ObterSaldo());

            ContaCorrente cC = new ContaCorrente();
            cC.Saldo = -100;
            cC.Depositar(1000);
            cC.Sacar(475);
            Console.WriteLine("Conta Corrente = "+ cC.ObterSaldo());
            Console.WriteLine("Conta Corrente Tributo = " + cC.calculaTributos());

            SeguroDeVida s = new SeguroDeVida();
            Console.WriteLine("Seguro de Vida = "+ s.calculaTributos());

        }
    }
}
