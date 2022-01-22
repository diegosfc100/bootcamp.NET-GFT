namespace OOP_Csharp.Models
{
    public class Retangulo
    {
        private double comprimento; // Propriedade privada
        private double largura; // Propriedade privada
        
        private bool valido; // Propriedade privada

        public void DefinirMedidas( double comprimento, double largura) // Método público para alterar medidas
        {
            if ( comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            }
            else
            {
                Console.WriteLine("Valores Inválidos");
            }
        }

        public double ObterArea()
        {
            if (valido)
            {
                return comprimento * largura;
            }
            else
            {
                Console.WriteLine("Preencha valores válidos");
                return 0;
            }
            
        }
    }
}