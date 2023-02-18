using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Crie uma variável que pode receber nomes de pessoas e atribua um valor à ela.
            // Aqui o tipo e atributo para text foi criados 
            string nome = "Edilson";

           

                               //2) Crie uma variável que pode receber a operação soma e atribua um valor  à ela.
                               // Aqui o tipo e atributo para digitos numericos número de ponto flutuante de precisão dupla foi criados 
            double soma = 0.0;
             
                           //3) Crie uma variável que só pode receber números sem vírgula e atribua  um valor à ela.
                           // Aqui o tipo e atributo para numeors inteiros sem virgulas foi criados 
            int numero = 0;


            double n1 = 0.0;   //Relacionado com o exercício 5
            double n2 = 0.0;
             
            
            double valor;     //Relacionado com o exercício 6


                                 //4) Crie um novo projeto no Visual Studio e peça para o usuário digitar um
                                 // nome.Por exemplo, Astolfo. Após digitar o nome, a mensagem “O nome
                                 // Astolfo é legal” deve aparecer.
                              // Aqui fi criado uma entrada de dados pelo usúario, gerando uma sai informativa.

            Console.WriteLine(" Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine(" O nome " + nome + " foi digitado\n");


                                /* 5) Crie um novo projeto no Visual Studio e peça para o usuário digitar dois
                                 números.Após digitar os dois números, verifique se o primeiro valor
                                 digitado é maior que o segundo valor digitado.Se for maior, a
                                 mensagem “O primeiro valor digitado é maior” deve aparecer.Se for
                                 menor, a mensagem “O segundo valor digitado é maior”. Se forem
                                 iguais, a mensagem “Os valores são iguais” deve aparecer.
                                Aqui temos o formato de SE e SE NÂO, o usuario infor um valor e ele pode ser 
                                 maior ou menor, e támbem se nem um dos dois pode ser igual. 
                                */



            Console.WriteLine(" Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(" O primeiro valore é maior\n");
            }
            else if (n1 < n2)
            {

                Console.WriteLine(" O seundo valor é maior\n");
            }
            else
                Console.WriteLine(" Os valores são iguais\n");

            

                              /*6) Crie um novo projeto no Visual Studio e peça para o usuário digitar um
                                  número. Após digitar, o dobro e a metade deste valor devem aparecer
                                  na tela. Exemplo:
                                  Número digitado foi 5, então:
                                  O dobro de 5 é 10.
                                  A metade de 5 é 2.5.
                                 Aqui vemos uma unidade de divisão com os valores digitados pelo o usúario
                               */


            Console.WriteLine(" Digite um número: ");
            valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("  O dobro do valor é: " + valor * 2);
            Console.WriteLine("  A metade do valor é: " + valor / 2);



        }
    }
}
