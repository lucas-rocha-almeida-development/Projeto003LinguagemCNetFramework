using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto003LinguagemCNetFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Programa para cadastrar varios usuarios
          * Ira conter opção C para cadastrar usuario e S para sair do programa
          * Soliçatações:
          * Gênero,Sendo M Masculino e F feminino
          * Data de nascimento no formato dd/mm/aaaa
          * Nome da rua
          * Numero da casa
          * ATENÇÃO: SERIA INTERESSANTE USAR A FUNCIONALIDADE DEPURAR, PARA PODER ACOMPANHAR CADA EXECUÇÃO E SEU RESPECTIVO VALOR
          * QUE SERA ATRIBUIDO NAS VARIAVEIS. 
          * BREAK POINTS
           */
            string opcao;
            do
            {
                Console.WriteLine("Pressione C para cadastrar ou S para sair!! ");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();//ira capturar opção digitada C ou S
                if (opcao == "c")//cadastrar usuario
                {// variaveis abaixo para preenchimento
                    Console.WriteLine("Digite seu nome completo: ");
                    string Nome = Console.ReadLine();
                    Console.WriteLine("Digite seu gênero: M para masculino ou F para feminino :");
                    char Genero = Console.ReadKey(true).KeyChar;
                    Console.WriteLine("Digite sua data de Nascimento no formato dd/mm/aaaa: ");
                    DateTime DataNascimento = Convert.ToDateTime(Console.ReadLine());//Digite a data e depois converta DATETIME
                    Console.WriteLine("Digite o nome da rua: ");
                    string NomeRua = Console.ReadLine();
                    Console.WriteLine("Digite o numero da sua casa: ");
                    int NumeroCasa = int.Parse(Console.ReadLine());
                    Console.Clear();//apos digitar dados, faça o limpeza para novo cadastro


                }else if(opcao == "s")
                {
                    //caso usuario digite s, o programa ira entrar nessa condição e ira ser encerrado....
                    Console.WriteLine("Programa sendo encerrado.....");
                }
                else
                {
                    //caso opção seja diferente de c ou s, ira cair nessa opção
                    Console.WriteLine("Opção desconhecida.");
                }
            } while (opcao != "s");
            Console.WriteLine("Pressione qualquer tecla para sair....");
            Console.ReadKey();
        }
    }
}
