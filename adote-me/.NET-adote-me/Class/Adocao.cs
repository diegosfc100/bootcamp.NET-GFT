public class Adocao : EntidadeBase
{
    // Atributos
    
    private Animal Animal {get; set;}
    private string Raça {get; set;}
    private string Idade {get; set;}
    private string Sexo {get; set;}
    private string Cor {get; set;}
    private string Castrado {get; set;}
    private string Vacinado {get; set;}
    private string Porte {get; set;}
    private bool Excluido {get; set;}
    
    // Métodos

    public Adocao(int id,
                  Animal animal,
                  string raça,
                  string idade,
                  string cor,
                  string castrado,
                  string vacinado,
                  string porte)
    {
        this.Id = id;
        this.Animal = animal;
        this.Raça = raça;
        this.Cor = cor;
        this.Castrado = castrado;
        this.Vacinado = vacinado;
        this.Porte = porte;
        this.Excluido = false;
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
        retorno += "Porte: " + this.Porte + Environment.NewLine;   
        retorno += "Adotado: " + this.Excluido;            
        return retorno;
    }
    
    // Encapsulamento
     public string retornaRaça()
     {
         return this.Raça;
     }

    public int retornaId()
    {
        return this.Id;
    }

     public bool retornaExcluido()
    {
        return this.Excluido;
    }
    
    public void Excluir()
    {
        this.Excluido = true;
    }
}
