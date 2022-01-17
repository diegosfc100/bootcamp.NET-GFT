using System;

namespace revisao {

    class Program{

        static void Main(string[] args){

        string opcaoUsuario;
        Aluno[] alunos = new Aluno[5];
        int posicaoArr = 0;
        

        do
        {
            opcaoUsuario = obeterOpcaoUsuario();


            switch (opcaoUsuario)
            {
                case "1":
                    Console.WriteLine("Informe o nome do aluno: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe a nota do aluno: ");
                            
                    if(decimal.TryParse(Console.ReadLine(), out decimal nota)){

                        alunos[posicaoArr] = new Aluno(nome, nota);
                        posicaoArr++;
                        
                    }else{
                        throw new AggregateException("Valor da nota deve ser decimal");
                    }

                    break;

                case "2":

                    foreach(Aluno a in alunos){

                        if(!string.IsNullOrEmpty(a.nome))  
                        Console.WriteLine($"Nome : {a.nome} , Nota {a.nota}");
                    }

                        break;

                case "3":

                    decimal mediaGeral = 0;
                    int tamanho = 0 ; 

                    foreach(Aluno aluno in alunos){

                        if(!string.IsNullOrEmpty(aluno.nome)) {
                            mediaGeral += aluno.nota;
                            tamanho++;
                        }
                    }
                    mediaGeral /= tamanho;

                    Conceito conceitoGeral;

                    if(mediaGeral < 2){
                        conceitoGeral = Conceito.E;
                    }else if(mediaGeral < 4){
                        conceitoGeral = Conceito.D;
                    }else if(mediaGeral < 6){
                        conceitoGeral = Conceito.C;
                    }else if(mediaGeral < 8){
                        conceitoGeral = Conceito.B;
                    }else {
                        conceitoGeral = Conceito.A;
                    }

                    Console.WriteLine($" A média geral da turma é: {mediaGeral}, Conceito geral : {conceitoGeral}");

                    break;

                case "X":

                    Console.WriteLine("Saindo do aplicativo!");
                    break;

                default:
                    throw new ArgumentOutOfRangeException("Opção inválida!");
            }
                
        }while (opcaoUsuario != "X" );

    }

        private static string obeterOpcaoUsuario()
        {
            string opcaoUsuario;

            Console.WriteLine("===================================");

            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno \n" +
                            "2 - listar alunos \n" +
                            "3 - calcular a média geral \n" +
                            "X - Sair");

            Console.WriteLine("===================================");

            opcaoUsuario = Console.ReadLine();

            return opcaoUsuario.ToUpper();
        }
    
    }
}