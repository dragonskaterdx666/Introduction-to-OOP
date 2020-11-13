using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TokyoOlympics2020
{
    class Modalidades
    {
        //variável de estado publica
        public static string ficheiro = "paises.txt";
        /// <summary>
        /// Este método permite mostrar cada atleta por país
        /// </summary>
        public static void MostrarAtletaPorPais()
        {
            Console.Clear();
            //variavel string que não tem atribuição de valor
            string linha = " ";
            //utilizando a classe reservada
            StreamReader leitor = new StreamReader(ficheiro);
            //se a linha do ficheiro for diferente de null (ou seja esteja escrita) o programa lê
            while ((linha = leitor.ReadLine()) != null)
            {
                //escreve a linha lida
                Console.WriteLine(linha);
            }
            //Escreve na consola
            Console.WriteLine("Escolha um país para visualizar os seus atletas");
            //le a opção do utilizador
            string optn = Console.ReadLine();

            //para cada atleta do tipo Atleta verifica-se se o pais deste é igual ao posto pelo utilizador
            foreach (Atleta atleta in ListaAtletas.atletas.Where(a => a.Pais.Equals(optn)))
            {
                //imprime o atleta que corresponde a essa verificação
                Console.WriteLine($"{atleta}\n");
            }

            Console.ReadKey();
            //Retorna à função principal
            Program.Main();
        }
        /// <summary>
        /// Este método permite ao utilizador ver as modalidades
        /// </summary>
        public static void VerModalidades()
        {
            //variavel contadora
            int count = 1;
            //para cada string no enumerador Enummodalidades
            foreach (string EModalidade in Enum.GetNames(typeof(EnumModalidades)))
            {
                //é escrita a modalidade que passe na condição
                Console.WriteLine("[{0}] {1}", count, EModalidade);
                //incrementa um valor e o contador aumenta pelo que, afeta a variavel de cima incrementado o seu valor na consola de modo crescente
                count++;
            }
        }
        /// <summary>
        /// Método que permite mostrar os atletas que se encaixam em cada modalidade
        /// </summary>
        public static void MostrarAtletaPorModalidade()
        {
            //escreve na consola
            Console.WriteLine("Escolha uma modalidade para ver os seus atletas:");
            //Invoca o método que imprime as modalidades
            VerModalidades();

            //recebe o valor do utilizador
            string optionModalidade = Console.ReadLine();
            EnumModalidades enumModalidades;

            #region Validar as modalidades          
            switch (optionModalidade)
            {
                case "1":
                    enumModalidades = EnumModalidades.Andebol;
                    break;
                case "2":
                    enumModalidades = EnumModalidades.Atletismo;
                    break;
                case "3":
                    enumModalidades = EnumModalidades.Badminton;
                    break;
                case "4":
                    enumModalidades = EnumModalidades.Basquetebol;
                    break;
                case "5":
                    enumModalidades = EnumModalidades.Boxe;
                    break;
                case "6":
                    enumModalidades = EnumModalidades.Canoagem;
                    break;
                case "7":
                    enumModalidades = EnumModalidades.Ciclismo;
                    break;
                case "8":
                    enumModalidades = EnumModalidades.Equestre;
                    break;
                case "9":
                    enumModalidades = EnumModalidades.Esgrima;
                    break;
                case "10":
                    enumModalidades = EnumModalidades.Futebol;
                    break;
                case "11":
                    enumModalidades = EnumModalidades.Ginastica;
                    break;
                case "12":
                    enumModalidades = EnumModalidades.Golfe;
                    break;
                case "13":
                    enumModalidades = EnumModalidades.Halterofilismo;
                    break;
                case "14":
                    enumModalidades = EnumModalidades.Hoquei;
                    break;
                case "15":
                    enumModalidades = EnumModalidades.Judo;
                    break;
                case "16":
                    enumModalidades = EnumModalidades.Karate;
                    break;
                case "17":
                    enumModalidades = EnumModalidades.LutasAmadoras;
                    break;
                case "18":
                    enumModalidades = EnumModalidades.Natacao;
                    break;
                case "19":
                    enumModalidades = EnumModalidades.PentatloModerno;
                    break;
                case "20":
                    enumModalidades = EnumModalidades.Remo;
                    break;
                case "21":
                    enumModalidades = EnumModalidades.Rugby;
                    break;
                case "22":
                    enumModalidades = EnumModalidades.Taekwondo;
                    break;
                case "23":
                    enumModalidades = EnumModalidades.Tenis;
                    break;
                case "24":
                    enumModalidades = EnumModalidades.TenisDeMesa;
                    break;
                case "25":
                    enumModalidades = EnumModalidades.Tiro;
                    break;
                case "26":
                    enumModalidades = EnumModalidades.TiroComArco;
                    break;
                case "27":
                    enumModalidades = EnumModalidades.TiroComArmasDeCaca;
                    break;
                case "28":
                    enumModalidades = EnumModalidades.Triatlo;
                    break;
                case "29":
                    enumModalidades = EnumModalidades.Vela;
                    break;
                case "30":
                    enumModalidades = EnumModalidades.Voleibol;
                    break;
                default:
                    throw new Exception("Modalidade inexistente");
            }
            #endregion

            Console.WriteLine("Atletas:");
            foreach(Atleta atleta in ListaAtletas.atletas.Where(a => a.enumModalidades.Equals(enumModalidades)))
            {
                Console.WriteLine($"{atleta}\n");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
