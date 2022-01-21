// MÓDULOS ou PACOTES
// C# é uma linguagem muito grande, que pode criar diversas coisas, devido a isso, os arquitetos diviram ela em MÓDULOS.
// Com os módulos vc só importa aquele q irá usar, deixando assim o programa mais leve.
// Os Módulos abaixo são usados para construir aplicativo de CONSOLE.
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld // **Explicação na Aula de Orientação a Objetos
{ 
    // Início do programa.
    class Program // **Explicação na Aula de Orientação a Objetos
    {
        
        static void Main(string[] args) // Função principal - Qdo um usuário cria um .exe e executa ele, o primeiro cod q irá rodar é oq estiver dentro dessa função principal
        {
            Console.Write("Hello World!"); // Comando para escrever
            Console.WriteLine("Rumo à GFT"); // WriteLine faz o mesmo q o Write porém tem a quebra de linha no final do texto.
                        
            // No C# as variáveis são declaradas com o tipo.
            // Int (inteiro) ; Float (flutuante) ; Bool (true ou false) ; String ("Texto") ;  Char('a') caracter
            // Regras de nomes de variáveis: tipo nome = valor;
            /* A-Z ; não pode iniciar com número ; não pode conter caracter especias( @ $ .) ;  não pode conter palavras reservadas ex: class */

            int nascimento = 1990;
            string sobreNome = "Rodrigues";
            float peso = 79.500f; // variáveis do tipo float devem conter o 'f' no final do valor.
            bool pesoPena = true;

            Console.WriteLine("Meu peso atual é " + peso);

            //atualizando um valor
            peso = 80.00f;
            Console.WriteLine("Meu peso atual é " + peso);

            // Declarando variaveis omitindo seu tipo
            var nomeCompleto = "Diego Rodrigues";
            var idadeAdulto = 30;
            // uma vez declarada uma variavel com um certo tipo, ela permanece com o msm tipo pra sempre, não podendo ser alterado.

            //Forma mais avançada de declarar variáveis - Forma Dinamica
            dynamic corFavorita = "Azul";

            // Variáveis Dinamicas podem armazenar varores de tipos diferentes. Porém, não é recomendado.
            corFavorita = 2022; 


            // Constantes -  parecidos com var porém uma vez declarada não possível alterar seu valor
            const float PI = 3.14f;

 
            /* Capturando entrada do usuário */
            string profissao = "";
            Console.WriteLine("Escreva sua profissão: ");
            profissao = Console.ReadLine();
            Console.WriteLine("Sua profissão é: " + profissao);

            // No C# tudo que é digitado no console é tratado como texto.
            int maiorIdade = int.Parse(Console.ReadLine()); // Nesse caso usamos o int.Parse para converter a string em Inteiro.


            /* Operadores Aritiméticos */
            int numeroQualquer = 20 + 20;
            int numeroMult = 10 + 10 - 10 * 5; // multiplicação e divisão são feitos primeiro.
            int numeroDiv = 5 / 2; // A divisão de números int, a variavel sempre vai armazenar o resultado int, no caso 2.
            // para concertar isso, devemos definir pelo menos um dos valores como float 


            /* Condicionais */
            if(50 >= 15) // SE
            {
                Console.WriteLine("Sim");
            }
            else if ( 20 == 20) // SE NÂO SE
            {
                Console.WriteLine("É verdade");
            }
            else // SE NÃO
            {
                Console.WriteLine("Não");
            }


            /* Operadores Lógicos */
            // && (E / AND) 
            // || (OU / OR)


            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Vc é uma criança!");
            }
            else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Vc é um adolescente!");
            }
            else if (idade >= 10 && idade <= 60)
            {
                Console.WriteLine("Vc é um adulto!");
            }
            else
            {
                Console.WriteLine("Vc é um idoso!");
            }
            

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int resultadoDiferenca = A * B - C * D;
         
            //Declare suas variáveis nos espaços em branco
            Console.WriteLine("DIFERENCA = " + resultadoDiferenca);
            Console.ReadKey();
                 

            

            Console.ReadLine(); // Comando para ler, esse comando vai ficar esperando vc digitar enter para fechar.
        }


         /* Funçoes */
        



        






    }
    //Fim do programa.
    

}