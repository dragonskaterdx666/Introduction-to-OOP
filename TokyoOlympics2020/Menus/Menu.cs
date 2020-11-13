using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokyoOlympics2020.Menus
{
    //Classe que contém os menus do programa
    public class Menu
    {
        /// <summary>
        /// Esta função orienta o menu referente às ações do atleta
        /// </summary>
        public static void OPTNAtletas()
        {
            //limpa o menu anterior da consola
            Console.Clear();
            char option = ' ';
            //Enquanto a opção não for 0
            while (option != '0')
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("                 MENU");
                Console.WriteLine("***************************************");
                Console.WriteLine("Options:");
                Console.WriteLine("1.Adicionar atletas");
                Console.WriteLine("2.Ver atletas");
                Console.WriteLine("3.Ver atletas por país");
                Console.WriteLine("4.Adicionar medalha a um atleta");
                Console.WriteLine("5.Adicionar Staff a um atleta");
                Console.WriteLine("6.Ver Staff de um atleta");
                Console.WriteLine("0.Retornar Menu");
                Console.WriteLine("***************************************");
                option = Convert.ToChar(Console.ReadLine());
                switch (option)
                {
                    case '1':
                        ListaAtletas.AddAtleta();
                        break;
                    case '2':
                        ListaAtletas.Show(ListaAtletas.atletas);
                        break;
                    case '3':
                        Modalidades.MostrarAtletaPorPais();
                        break;
                    case '4':
                        COP.AtribuirMedalha();
                        break;
                    case '5':
                        Atleta.EspecificarStaff();
                        break;
                    case '6':
                        Staff.ShowStaff();
                        break;
                    case '0':
                        Program.Main();
                        break;

                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Esta função imprime o Menu de opções associadas às modalidades OPTN = options
        /// </summary>
        public static void OPTNModalidades()
        {
            Console.Clear();
            char option = ' ';
            while (option != '0')
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("                 MENU");
                Console.WriteLine("***************************************");
                Console.WriteLine("Options:");
                Console.WriteLine("1.Ver modalidades");
                Console.WriteLine("2.Ver Atletas inscritos por modalidade");
                Console.WriteLine("0.Retornar Menu");
                Console.WriteLine("***************************************");
                option = Convert.ToChar(Console.ReadLine());
                switch (option)
                {
                    case '1':
                        Modalidades.VerModalidades();
                        break;
                    case '2':
                        Modalidades.MostrarAtletaPorModalidade();
                        break;
                    case '0':
                        Program.Main();
                        break;

                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Esta função imprime o Menu atletas escolhidos para o quadro de honra via seleção de medalhas, pelo método da classe COP
        /// </summary>
        public static void OPTNQuadroDeHonra()
        {
            Console.Clear();
            char option = ' ';
            while (option != '0')
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("                 MENU");
                Console.WriteLine("***************************************");
                Console.WriteLine("Options:");
                Console.WriteLine("1.Visualizar Quadro de Honra");
                Console.WriteLine("0.Retornar ao Menu");
                Console.WriteLine("***************************************");
                option = Convert.ToChar(Console.ReadLine());
                switch (option)
                {
                    case '1':
                        COP.ElaborarQuadroDeHonra();
                        break;
                    case '0':
                        Program.Main();
                        break;

                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Esta função imprime o Menu de escolhas relativas ao registo de competições
        /// </summary>
        public static void OPTNRegistoDeCompeticoes()
        {
            Console.Clear();
            char option = ' ';
            while (option != '0')
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("                 MENU");
                Console.WriteLine("***************************************");
                Console.WriteLine("Options:");
                Console.WriteLine("1.Registos de atletas");
                Console.WriteLine("2.Adicionar Registos");
                Console.WriteLine("3.Cronograma");
                Console.WriteLine("0.Retornar ao Menu");
                Console.WriteLine("***************************************");
                option = Convert.ToChar(Console.ReadLine());
                switch (option)
                {
                    case '1':
                        ListaRegistos.ShowRegistos(ListaRegistos.ListaDeRegistos);
                        break;
                    case '2':
                        //redireciona para o método de adicionar registo na classes
                        ListaRegistos.AddRegisto(); ;
                        break; 
                    case '3':
                        //redireciona para o método de adicionar registo na classes
                        ListaAtletas.atletas[1].MostrarDataProva();
                        break;
                    case '0':
                        Program.Main();
                        break;

                }
            }
            Console.ReadKey();
        }

    }
}
