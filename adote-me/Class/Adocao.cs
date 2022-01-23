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
}
