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
                case "5";
                    VisualizarPet();
                    break;
                case "C";
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
            Console.WriteLine("#ID {0}: {1}", adocao.retornaId());// adocao.retornaTitulo());
        }
    }

    private static string ObterOpcaoUsuario()
    {

    Console.WriteLine();
    Console.WriteLine("dotNET Adoção a seu dispor =) ");
    Console.WriteLine("Informe a opção desejda: ");

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
