﻿// MÓDULOS ou PACOTES
// C# é uma linguagem muito grande, que pode criar diversas coisas, devido a isso, os arquitetos diviram ela em MÓDULOS.
// Com os módulos vc só importa aquele q irá usar, deixando assim o programa mais leve.
// Os Módulos abaixo são usados para construir aplicativo de CONSOLE.
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld 
{ 
    
    class Program 
    {
        
        static void Main(string[] args) // Função principal - Qdo um usuário cria um .exe e executa ele, o primeiro cod q irá rodar é oq estiver dentro dessa função principal
        {
                /* C O N S O L E */

            // Console.Write(""); 
            // Escreve o texto na mesma linha, por exemplo:
            Console.Write("Olá ");
            Console.Write("Mundo");
            // Olá Mundo

            // Console.WriteLine("");
            // Escreve o texto e logo a seguir quebra para a linha seguinte, por exemplo:
            Console.WriteLine();
            Console.WriteLine("Olá ");
            Console.WriteLine("Mundo");
            // Olá 
            // Mundo


            // Capturando entrada do usuário com CONSOLE.READLINE();
            string profissao;
            Console.WriteLine("Escreva sua profissão: ");
            profissao = Console.ReadLine();
            Console.WriteLine($"Sua profissão é: {profissao}");


            // No C# tudo que é digitado no console é tratado como texto
            // Nesse caso usamos o int.Parse para converter a string em Inteiro
            int primo;
            Console.WriteLine("Digite um número primo: ");
            primo = int.Parse(Console.ReadLine()); 
            Console.WriteLine($"Você digitou o número: {primo}");

           

                /* V A R I A V E I S */

            // No C# as variáveis são declaradas com o tipo.
            // int 
            // float 
            // bool 
            // string 
            // char('a') caracter

            // tipo nome = valor;
            // A-Z / Não pode iniciar com número / não pode conter caracter especias( @ $ .) 

            int nascimento = 1990;
            string sobreNome = "Rodrigues";
            float peso = 79.500f; // tipo float devem conter o 'f' no final do valor
            bool magro = true;

            
            // Declarando variaveis omitindo seu tipo
            var nomeCompleto = "Diego Rodrigues";
            var idadeAdulto = 30;
            // uma vez declarada uma variavel com um certo tipo, ela permanece com o msm tipo pra sempre, não podendo ser alterado.


            //Forma mais avançada de declarar variáveis - Forma Dinamica
            dynamic corFavorita = "Azul";

            // Variáveis Dinamicas podem armazenar varores de tipos diferentes. Porém, não é recomendado.
            corFavorita = 2022; 


            // CONSTANTES -  parecidos com var porém uma vez declarada não possível alterar seu valor
            const float PI = 3.14f; // Exemplo com valor de PI q não pode ser alterado.

 
                  
                /* C O N D I C I O N A I S + OPERADORES LÓGICOS */
                                         
            // && (E / AND) 
            // || (OU / OR)


            int idade;
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            
            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Vc é uma Criança!");
            }
            else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Vc é um Adolescente!");
            }
            else if (idade >= 10 && idade <= 60)
            {
                Console.WriteLine("Vc é um Adulto!");
            }
            else
            {
                Console.WriteLine("Vc é um Idoso!");
            }
            
            

                /*   A R R A Y   */
            
            // string[] ~> array do tipo string
            // int[]    ~> array do tipo inteiro
            /* 2 formas de declarar um ARRAY: */
            // int[] idades = new int[3] {20, 33, 51}; 
            // int[] anos = {1990, 2002, 2010};
            
            string[] frutas = new string[5] {
                "Laranja",
                "Uva",
                "Mamão",
                "Melancia",
                "Abacate"
            };

            Console.WriteLine(frutas[0]);
            Console.WriteLine(frutas[4]);


            //Sobrescrevendo valores
            frutas[0] = "Lichia";
            frutas[4] = "Banana";
            Console.WriteLine(frutas[0]);
            Console.WriteLine(frutas[4]);



                /*   F U N Ç Õ E S   */

            static void FuncaoExibirMsg(){ // void = vazia = não retorna nada.
                Console.WriteLine("Exemplo Função part I");
                Console.WriteLine("Exemplo Função part II");
                Console.WriteLine("Exemplo Função part III");
            }
            // Chamando Função
            FuncaoExibirMsg();


                // Função COM PARAMETRO
            // Parametros sao semelhantes a variaveis
            // int = tipo / idade = nome do parametro
            // string = tipo / nome = nome do parametro

            static void ComParametro(string sobrenome,int idade ) 
            {
                Console.WriteLine(sobrenome + idade);
            }

            ComParametro("Rodrigues", 20 );

         
                // Função COM RETORNO   
            // Console.ReadLine() é um exemplo de função com retorno.
            // Qdo a função houver retorno, antes do nome dela deve vir o tipo de retorno, string/bool/int...

            static int Somar(int a, int b, int c) 
            {
                int result = a + b + c;
                return result;
            }
                          
            Somar(10, 20, 30); // a função retornara o resultado mas não exibirá nada na tela.

            // Uma forma de ver esse retorno é colocar a dunção no console.
            int resultFuncao = Somar(10, 20, 70);
            Console.WriteLine($"O resultado da função SOMAR é: {resultFuncao}"); 


          
            

        }

        

              
        

        


        

      }
    //Fim do programa.
    
    
}