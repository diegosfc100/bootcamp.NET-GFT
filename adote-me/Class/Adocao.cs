public class Adocao : EntidadeBase
{
    // Atributos
    
    private Animal Animal {get; set;}
    private string Raça {get; set;}
    private int Idade {get; set;}
    private string Sexo {get; set;}
    private string Cor {get; set;}
    private bool Castrado {get; set;}
    private bool Vacinado {get; set;}
    private string Porte {get; set;}
    
    // Métodos

    public Adocao(int id, Animal animal, string raça, int idade, string cor, bool castrado, bool vacinado, string porte)
    {
        this.Id = id;
        this.Animal = animal;
        this.Raça = raça;
        this.Cor = cor;
        this.Castrado = castrado;
        this.Vacinado = vacinado;
        this.Porte = porte;
    }

    // Implementação do ToString()

    public override string ToString()
    {
        // Environment.NewLine = /r /n https://docs.microsoft.com/pt-br/dotnet/api/system.environment.newline?view=net-6.0
        string retorno = "";
        retorno += "Animal: " + this.Animal + Environment.NewLine;
        retorno += "Raça: " + this.Raça + Environment.NewLine;
        retorno += "Cor: " + this.Cor + Environment.NewLine;
        retorno += "Castrado: " + this.Castrado + Environment.NewLine;
        retorno += "Vacinado: " + this.Vacinado + Environment.NewLine;
        retorno += "Porte: " + this.Porte;               
        return retorno;
    }
    
    // Encapsulamento
    public string retornaAnimal()
    {
        return this.Animal;
    }

    public int retornaId()
    {
        return this.Id;
    }

}
