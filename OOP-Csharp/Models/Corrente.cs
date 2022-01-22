namespace OOP_Csharp.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor) // atalho: ctrl + . + (opção: implementar classe abstrata)
        {
            base.saldo = valor;  // this tbm funciona no lugar de base
        }
    }
}


// em todo método abstrato vc é obrigado a sobscrever caso deseje herda-lo