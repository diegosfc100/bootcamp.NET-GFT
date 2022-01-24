class Program
{
    static void Main(string[] args)
    {
        
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
