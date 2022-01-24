class Program
{

    static AdocaoRepositorio repositorio = new AdocaoRepositorio();
    static void Main(string[] args)
    {
        string opcaoUsuario = ObterOpcaoUsuario();

        while (opcaoUsuario.ToUpper() != "X")
        {
            switch (opcaoUsuario)
            {
                case "1":
                    ListarPets();
                    break;
                case "2":
                    InserirPet();
                    break;
                case "3":
                    AtualizarPets();
                    break;
                case "4":
                    ExcluirPet();
                    break;
                case "5":
                    VisualizarPet();
                    break;
                 case "C":
                    Console.Clear();
                     break;
            
                default:
                    throw new ArgumentOutOfRangeException();
            }
            opcaoUsuario = ObterOpcaoUsuario();
        }
        
        Console.WriteLine("Obrigado por utilizar nossos serviços.");
        Console.ReadLine();
    }

    private static void ExcluirPet()
    {
        Console.Write("Digite o id do animal: ");
        int indiceAnimal = int.Parse(Console.ReadLine());

        repositorio.Exclui(indiceAnimal);
    }

    private static void VisualizarPet()
    {
        Console.Write("Digite o id do animal: ");
        int indiceAnimal = int.Parse(Console.ReadLine());

        var adocao = repositorio.RetornaPorId(indiceAnimal);

        Console.WriteLine(adocao);
    }

     private static void AtualizarPets()
     {
         Console.Write("Digite o id do animal: ");
         int indiceAnimal = int.Parse(Console.ReadLine());

         foreach (int i in Enum.GetValues(typeof(Animal)))
        {
            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Animal), i));
        }
        Console.Write("Selecione o animal entre as opções acima: ");
        int entradaAnimal = int.Parse(Console.ReadLine());

        Console.Write("Digite a raça do animal: ");
        string entradaRaça = Console.ReadLine();

        Console.Write("Digite a idade do animal: ");
        string entradaIdade = Console.ReadLine();
      
        Console.Write("Digite a cor do animal: ");
        string entradaCor = Console.ReadLine();

        Console.Write("O animal é castrado? ");
        string entradaCastrado = Console.ReadLine();

        Console.Write("O animal já foi vacinado? Se sim, quais vacinas já tomou? ");
        string entradaVacina = Console.ReadLine();

        Console.Write("Qual porte do animal? ");
        string entradaPorte = Console.ReadLine();

        Adocao AtualizarPets =  new Adocao(id: indiceAnimal,
                                        animal: (Animal) entradaAnimal,
                                        raça: entradaRaça,
                                        idade: entradaIdade,
                                        cor: entradaCor,
                                        castrado: entradaCastrado,
                                        vacinado: entradaVacina,
                                        porte: entradaPorte);

        repositorio.Atualiza(indiceAnimal, AtualizarPets);
     }

    private static void ListarPets()
    {
        Console.WriteLine("Listar Pets");
        
        var lista = repositorio.Lista();

        if (lista.Count == 0)
        {
            Console.WriteLine("Nenhum Pet cadastrado.");
            return;
        }
        foreach (var adocao in lista)
        {
            var excluido = adocao.retornaExcluido();
            Console.WriteLine("#ID {0}: - {1} {2}", adocao.retornaId(), adocao.retornaRaça(), (excluido ? "*Adotado*" : ""));
        }
    }

    private static void InserirPet()
    {
        Console.WriteLine("Inserir novo Pet para adoção");

        //getvalue https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=net-6.0#system-enum-getvalues(system-type)

        //getname https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getnames?view=net-6.0#system-enum-getnames(system-type)

        foreach (int i in Enum.GetValues(typeof(Animal)))
        {
            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Animal), i));
        }
        Console.Write("Selecione o animal entre as opções acima: ");
        int entradaAnimal = int.Parse(Console.ReadLine());

        Console.Write("Digite a raça do animal: ");
        string entradaRaça = Console.ReadLine();

        Console.Write("Digite a idade do animal: ");
        string entradaIdade = Console.ReadLine();
      
        Console.Write("Digite a cor do animal: ");
        string entradaCor = Console.ReadLine();

        Console.Write("O animal é castrado? ");
        string entradaCastrado = Console.ReadLine();

        Console.Write("O animal já foi vacinado? Se sim, quais vacinas já tomou? ");
        string entradaVacina = Console.ReadLine();

        Console.Write("Qual porte do animal? ");
        string entradaPorte = Console.ReadLine();

        Adocao novaAdocao =  new Adocao(id: repositorio.ProximoId(),
                                        animal: (Animal) entradaAnimal,
                                        raça: entradaRaça,
                                        idade: entradaIdade,
                                        cor: entradaCor,
                                        castrado: entradaCastrado,
                                        vacinado: entradaVacina,
                                        porte: entradaPorte);

        repositorio.Insere(novaAdocao);
        
    }

    private static string ObterOpcaoUsuario()
    {

    Console.WriteLine();
    Console.WriteLine("dotNET Adoção a seu dispor =) ");
    Console.WriteLine("Informe a opção desejada: "); 
    Console.WriteLine("");

    Console.WriteLine("1- Listar Pets");
    Console.WriteLine("2- Inserir Pet para doação");
    Console.WriteLine("3- Atualizar lista de Pets");
    Console.WriteLine("4- Excluir Pet adotado");
    Console.WriteLine("5- Visualizar Pet");
    Console.WriteLine("C- Limpar tela");
    Console.WriteLine("X- Sair");
    Console.WriteLine();
   
    string opcaoUsuario = Console.ReadLine().ToUpper();
    Console.WriteLine();
    return opcaoUsuario;
    }
    
}




