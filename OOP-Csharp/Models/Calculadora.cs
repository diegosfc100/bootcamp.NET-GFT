using OOP_Csharp.Interfaces;

namespace OOP_Csharp.Models
{
    public class Calculadora : iCalc // Calculadora implementa  interface iCalc
    {
        
        public int Somar(int num1, int num2) // 2 parametros
        {
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3) // 3 parametros
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}