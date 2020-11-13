using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace TokyoOlympics2020
{
    //classe listaAtletas que herda da lista de atletas
    public class ListaAtletas : List<Atleta>
    {
        //variavel estatica publica que é visivel em todos os metodos da classe e fora dela
        public static string pais;
        //criação da lista de atletas
        public static List<Atleta> atletas = new List<Atleta>();
        //array de medalhas
        public static string[] medalhas = { "Ouro", "Prata", "Bronze", "Nenhuma" };
        /// <summary>
        /// Método que permite adicionar um atleta à lista de atletas
        /// </summary>
        public static void AddAtleta()
        {
            //limpa a consola
            Console.Clear();

            Console.WriteLine("-Adicione um atleta-");
            //recolhe o nome inserido pelo utilizador
            Console.WriteLine("> Insira o nome:");
            string nome = Console.ReadLine();
            //recolhe a naturalidade inserido pelo utilizador
            Console.WriteLine("> Insira a naturalidade:");
            string naturalidade = Console.ReadLine();
            //recolhe a idade inserido pelo utilizador
            Console.WriteLine("> Insira a idade:");
            int idade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("> Insira o peso:");
            float peso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("> Insira a altura:");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("> Insira o género: Feminimo (F), Masculino (M) , Nenhum (N) ou Outro (O)");
            string genero = Console.ReadLine();
            //criar a variavel genero que vai receber o valor de acordo com a opção do utilizador
            Genero generoDefinido;

            #region Validar Género
            if (genero == "Feminino" || genero == "feminino" || genero == "F" || genero == "f")
                //define a variavel género como o valor do género do enumerador
                generoDefinido = Genero.Feminino;

            else if (genero == "Masculino" || genero == "masculino" || genero == "M" || genero == "n")
                //define a variavel género como o valor do género do enumerador
                generoDefinido = Genero.Masculino;

            else if (genero == "Nenhum" || genero == "nenhum" || genero == "N" || genero == "n")
                //define a variavel género como o valor do género do enumerador
                generoDefinido = Genero.Nenhum;

            else

                generoDefinido = Genero.Outro;
            #endregion

            Console.WriteLine("> Insira a escolaridade");
            string escolaridade = Console.ReadLine();

            Console.WriteLine("> Insira o clube");
            string clube = Console.ReadLine();

            Console.WriteLine("> Insira o país:");
            pais = Console.ReadLine();

            Console.WriteLine("> Insira a medalha: Ouro (O), Bronze (B) , Prata (P) ou Nenhuma (N)");
            string medalha = Console.ReadLine();
            EnumMedalhas enumMedalhas;
            //método equivalente ao de validar o género
            #region Validar Medalhas
            if (medalha == "Ouro" || medalha == "ouro" || medalha == "O" || medalha == "o")
                //faz set na variavel do utilizador ao valor fixo do enumerador
                enumMedalhas = EnumMedalhas.Ouro;

            else if (medalha == "Prata" || medalha == "prata" || medalha == "P" || medalha == "p")

                enumMedalhas = EnumMedalhas.Prata;

            else if (medalha == "Nenhuma" || medalha == "nenhuma" || medalha == "N" || medalha == "n")

                enumMedalhas = EnumMedalhas.Nenhuma;

            else

                enumMedalhas = EnumMedalhas.Bronze;
            #endregion

            Modalidades.VerModalidades();
            string optn = Console.ReadLine();           
            Console.Clear();
            //gera automaticamente uma identificação para o novo atleta, sendo que incrementa apartir do valor da posição do ultimo atleta instanciado
            int idAtleta = (atletas.Count) + 1;
            EnumModalidades enumModalidades;

            #region Validar as modalidades          
            switch (optn)
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
            //após receber os valores instancia-se o objeto atleta com os argumentos dados
            Atleta novoAtleta = new Atleta(idAtleta, nome, naturalidade, idade, peso, altura, generoDefinido, escolaridade, clube, enumModalidades, pais);
            //adiciona-se à lista de atletas chamada atletas o novo atleta
            atletas.Add(novoAtleta);
            novoAtleta.GetMedalhas.Add(enumMedalhas);
            novoAtleta.DataCompeticao.ToList();
            Console.WriteLine("-Atleta adicionado:-");
            //mostra o novo atleta adicionado
            Console.WriteLine(novoAtleta.ToString());
            #region 
            DateTime dataDecompeticaotemp = new DateTime();
            DateTime dataDecompeticaotemp1 = new DateTime();
            DateTime dataDecompeticaotemp2 = new DateTime();
            DateTime dataDecompeticaotemp3 = new DateTime();
            DateTime dataDecompeticaotemp4 = new DateTime();
            DateTime dataDecompeticaotemp5 = new DateTime();
            DateTime dataDecompeticaotemp6 = new DateTime();
            DateTime dataDecompeticaotemp7 = new DateTime();
            DateTime dataDecompeticaotemp8 = new DateTime();
            DateTime dataDecompeticaotemp9 = new DateTime();
            DateTime dataDecompeticaotemp10 = new DateTime();
            DateTime dataDecompeticaotemp11 = new DateTime();
            DateTime dataDecompeticaotemp12 = new DateTime();
            DateTime dataDecompeticaotemp13 = new DateTime();
            dataDecompeticaotemp.ToString("25-07-2020");
            dataDecompeticaotemp1.ToString("26-07-2020");
            dataDecompeticaotemp2.ToString("27-07-2020");
            dataDecompeticaotemp3.ToString("28-07-2020");
            dataDecompeticaotemp4.ToString("29-07-2020");
            dataDecompeticaotemp5.ToString("30-07-2020");
            dataDecompeticaotemp6.ToString("31-07-2020");
            dataDecompeticaotemp7.ToString("01-08-2020");
            dataDecompeticaotemp8.ToString("02-08-2020");
            dataDecompeticaotemp9.ToString("03-08-2020");
            dataDecompeticaotemp10.ToString("04-08-2020");
            dataDecompeticaotemp11.ToString("05-08-2020");
            dataDecompeticaotemp12.ToString("06-08-2020");
            dataDecompeticaotemp13.ToString("07-08-2020");

            if ( novoAtleta.enumModalidades == EnumModalidades.Andebol || novoAtleta.enumModalidades == EnumModalidades.Basquetebol || novoAtleta.enumModalidades == EnumModalidades.Voleibol )
            {              
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp1);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp2);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp3);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp4);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp5);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp6);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp7);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp8);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp9);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp10);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp11);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp12);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp13);
            }
            else if(novoAtleta.enumModalidades == EnumModalidades.Badminton)
            {
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp5);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp6);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp7);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp8);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp9);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp10);
            }
            else if(novoAtleta.enumModalidades == EnumModalidades.Boxe)
            {
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp1);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp2);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp3);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp4);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp5);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp6);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp7);
            }
            else if(novoAtleta.enumModalidades == EnumModalidades.Canoagem)
            {
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp1);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp2);
            }
            else if(novoAtleta.enumModalidades == EnumModalidades.Ciclismo)
            {
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp12);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp13);
            }
            else if(novoAtleta.enumModalidades == EnumModalidades.Futebol)
            {
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp1);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp3);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp4);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp6);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp7);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp11);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp12);
            }
            else if (novoAtleta.enumModalidades == EnumModalidades.Hoquei)
            {
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp1);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp2);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp3);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp4);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp5);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp6);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp7);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp8);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp9);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp10);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp11);
            }
            else
            {
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp1);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp2);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp3);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp4);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp5);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp6);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp7);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp8);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp9);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp10);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp11);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp12);
                novoAtleta.DataCompeticao.Add(dataDecompeticaotemp13);
            }
            #endregion
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Método que permite mostrar os elementos da lista de atletas
        /// </summary>
        /// <param name="atletas"></param>
        public static void Show(List<Atleta> atletas)
        {
            //limpa a consola
            Console.Clear();
            Console.WriteLine("-------------------Atletas:--------------------");
            //para cada atleta na lista de atletas
            foreach (Atleta atleta in atletas)
            {
                //imprime-se esse atleta
                Console.WriteLine($"{atleta}\n");
                Console.WriteLine("------------------------------------------------------------------");
            }
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Método que confirma se o atleta tem uma medalha, caso tenha, é posto no quadro de honra
        /// </summary>
        public static bool ConfirmarMedalhado(int id)
        {
            //interligar o array de medalhas ao enumerador de medalhas
            medalhas[0] = EnumMedalhas.Ouro.ToString();
            medalhas[1] = EnumMedalhas.Prata.ToString();
            medalhas[2] = EnumMedalhas.Bronze.ToString();
            medalhas[3] = EnumMedalhas.Nenhuma.ToString();
            bool verificarMedalha = false;
            //ciclo do tamanho da quantidade de atletas na lista
            for (int i = 0; i < atletas.Count; i++)
            {
                if (atletas[i].Id == id)
                {
                    //se a lista estiver preenchida:
                    if (atletas[i].GetMedalhas != null && atletas[i].GetMedalhas.Any())
                    {
                        //se o atleta na posição i tiver uma medalha igual à da posição 0,1,2 significa que é medalhado e é colocado no quadro de honra
                        if (atletas[i].GetMedalhas[0].ToString() == medalhas[0] || atletas[i].GetMedalhas[0].ToString() == medalhas[1] || atletas[i].GetMedalhas[0].ToString() == medalhas[2])
                        {
                            verificarMedalha = true;
                        }
                    }
                }
            }
            return verificarMedalha;
        }

    }
}
