namespace OOP_Csharp.Models
{
    public abstract class Conta // Classe abstrata
    {
        protected double saldo; // protected: somente a própria classe e as classes filha conseguem acessar.

        public abstract void Creditar(double valor); // Método abstrato NÃO permite implementação.

        public void ExibirSaldo() // Método não abstrato COM implementação
        {
            Console.WriteLine("Seu saldo é: $" + saldo);
        }
    }
}