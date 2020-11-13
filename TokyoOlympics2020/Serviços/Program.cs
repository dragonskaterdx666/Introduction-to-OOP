using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Collections;


namespace TokyoOlympics2020
{
    class Program
    {
        public static void Main()
        {
            //define o titulo da consola
            Console.Title = "Olímpiadas de Tóquio";
            //Altera as cores da consola
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            #region Adicionar atletas à competição
            //adicionar atletas à competição
            //instanciar os atletas do tipo Atleta
            Atleta alexisSantos = new Atleta(1,"Alexis Santos", "Lisboa", 27, 70, 1.85F, Genero.Masculino, "Desconhecido", "Sporting CP", EnumModalidades.Natacao, "Portugal");
            Atleta anaCabecinha = new Atleta(2,"Ana Cabecinha", "Santiago Maior", 38, 48, 1.64F, Genero.Feminino, "Desconhecido", "Clube Oriental de Pechão", EnumModalidades.Atletismo, "Portugal");
            Atleta anaMonteiro = new Atleta(3,"Ana Monteiro", "Vila do Conde", 26, 58, 1.64F, Genero.Feminino, "Desconhecido", "Clube Fluvial Vilacondense", EnumModalidades.Natacao, "Portugal");
            Atleta anriEgutidze = new Atleta(4,"Anri Egutidze", "Geórgia", 23, 77, 1.73F, Genero.Masculino, "Desconhecido", "SL Benfica", EnumModalidades.Judo, "Portugal");
            Atleta telmaMonteiro = new Atleta(5,"Telma Monteiro", "Lisboa", 29, 57, 1.63F, Genero.Feminino, "Desconhecido", "SL Benfica", EnumModalidades.Judo,"Portugal");
            Atleta ivoOliveira = new Atleta(6, "Ivo Oliveira", "Mafamude", 23, 67, 1.86F, Genero.Masculino, "Desconhecido", "UAE Team Emirates", EnumModalidades.Ciclismo, "Portugal");
            //adicionar os atletas à lista de atletas
            ListaAtletas.atletas.Add(alexisSantos);
            ListaAtletas.atletas.Add(anaCabecinha);
            ListaAtletas.atletas.Add(anaMonteiro);
            ListaAtletas.atletas.Add(anriEgutidze);
            ListaAtletas.atletas.Add(telmaMonteiro);
            ListaAtletas.atletas.Add(ivoOliveira);
            //instanciar o registo do atleta alexis Santos
            Registo alexisSantosRegisto = new Registo(1,2010, "Singapura", "50 metros costas Mas", "6ºlugar");
            Registo anaCabecinhaRegisto = new Registo(2,2016, "Rio", "20km Marcha", "6º lugar");
            Registo anaMonteiroRegisto = new Registo(3);
            Registo anriEgutidzeRegisto = new Registo(4,2019, "Minsk", "-81kg", "2ºronda");
            Registo telmaMonteiroRegisto = new Registo(5,2019, "Minsk", "-57kg", "3ºlugar");
            Registo telmaMonteiroRegisto1 = new Registo(6, 2019, "Minsk", "Equipas Mistas", "2ºlugar");
            Registo ivoOliveiraRegisto = new Registo(7);
            //adicionar à lista de registos
            ListaRegistos.ListaDeRegistos.Add(alexisSantosRegisto);            
            ListaRegistos.ListaDeRegistos.Add(anaCabecinhaRegisto);
            ListaRegistos.ListaDeRegistos.Add(anaMonteiroRegisto);
            ListaRegistos.ListaDeRegistos.Add(anriEgutidzeRegisto);
            ListaRegistos.ListaDeRegistos.Add(telmaMonteiroRegisto); 
            ListaRegistos.ListaDeRegistos.Add(telmaMonteiroRegisto1);
            ListaRegistos.ListaDeRegistos.Add(ivoOliveiraRegisto);
            telmaMonteiro.GetMedalhas.Add(EnumMedalhas.Bronze);
            #endregion

            //cria a variável do tipo char sem definição
            char option = ' ';
            //enquanto a variável opção for diferente de 0 a consola vai apresentar as seguintes linhas de código
            while (option != '0')
            {
                //escreve na consola o que está dentro das aspas
                Console.WriteLine("***************************************");
                Console.WriteLine("                 MENU");
                Console.WriteLine("***************************************");
                Console.WriteLine("Options:");
                Console.WriteLine("1.Atletas");
                Console.WriteLine("2.Modalidades");
                Console.WriteLine("3.Quadro de Honra");
                Console.WriteLine("4.Registo de Competições");
                Console.WriteLine("0.Sair");
                Console.WriteLine("***************************************");
                //converte a variavel opção para string para ser lida pelo compilador aquando recebe a resposta do user
                option = Convert.ToChar(Console.ReadLine());
                //switch case que organiza o menu de opções
                switch (option)
                {
                    //caso o user escreva o número 1, a função OPTNAtletas é chamada.
                    case '1':
                        Menus.Menu.OPTNAtletas();
                        break;
                    case '2':
                        //caso o user escreva o número 2, a função OPTNModalidades é chamada.
                        Menus.Menu.OPTNModalidades();
                        break;
                    case '3':
                        //caso o user escreva o número 4, a função OPTNQuadroDeHonra é chamada.
                        Menus.Menu.OPTNQuadroDeHonra();
                        break;
                    case '4':
                        //caso o user escreva o número 5, a função OPTNCompeticoesRecentes é chamada.
                        Menus.Menu.OPTNRegistoDeCompeticoes();
                        break;
                    case '0':
                        break;

                }
            }
            Console.ReadKey();
        }
    }
}
