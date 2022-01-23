namespace OOP_Csharp.Interfaces
{
    public interface iCalc // Nome da interface sempre deve ter a letra 'i' antes.
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}