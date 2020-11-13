using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace TokyoOlympics2020
{
    //enumerador de modalidades utilizados com intuito de definirem um conjunto finito de opções 
    public enum EnumModalidades { Andebol, Atletismo, Badminton, Basquetebol, Boxe, Canoagem, Ciclismo, Equestre, Esgrima, Futebol, Ginastica, Golfe, Halterofilismo, Hoquei, Judo, Karate, LutasAmadoras, Natacao, PentatloModerno, Remo, Rugby, Taekwondo, Tenis, TenisDeMesa, Tiro, TiroComArco, TiroComArmasDeCaca, Triatlo, Vela, Voleibol };
    public class Atleta : Pessoa
    {
        public static ArrayList atletasComStaff = new ArrayList();

        #region Construtores
        //quando um atleta é instanciado este tem parametros de preenchimento obrigatórios, tais como:
        /// <summary>
        /// Paramêtros necessários para instanciar um atleta
        /// </summary>
        /// <param name="naturalidade"></param>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        /// <param name="peso"></param>
        /// <param name="altura"></param>
        /// <param name="genero"></param>
        /// <param name="escolaridade"></param>
        /// <param name="clube"></param>
        /// <param name="modalidade"></param>
        /// <param name="pais"></param>
        public Atleta(int id, string nome, string naturalidade, int idade, float peso, float altura, Genero genero, string escolaridade, string clube, EnumModalidades modalidade, string pais)
        {
            this.Id = id;
            this.Nome = nome;
            this.Naturalidade = naturalidade;
            this.Idade = idade;
            this.Peso = peso;
            this.Altura = altura;
            this.generoDefinido = genero;
            this.Escolaridade = escolaridade;
            this.Clube = clube;
            this.enumModalidades = modalidade;
            this.Pais = pais;
            //guarda as medalhas dos utilizadores numa lista
            GetMedalhas = new List<EnumMedalhas>();
            DataCompeticao = new List<DateTime>();
        }
        //permite instanciar atletas sem medalhas
        public Atleta(string nome, string naturalidade, int idade, float peso, float altura, Genero genero, string escolaridade, string clube, EnumModalidades modalidade, string pais)
        {
            this.Nome = nome;
            this.Naturalidade = naturalidade;
            this.Idade = idade;
            this.Peso = peso;
            this.Altura = altura;
            this.generoDefinido = genero;
            this.Escolaridade = escolaridade;
            this.Clube = clube;
            this.enumModalidades = modalidade;
            this.Pais = pais;
            GetMedalhas = new List<EnumMedalhas>();
            DataCompeticao = new List<DateTime>();
        }
        #endregion

        #region Propriedades

        public int Id { get; set; }
        /// <summary>
        /// Esta propriedade permite receber o clube de um atleta
        /// </summary>
        public string Clube { get; set; }
        /// <summary>
        /// Esta propriedade permite receber aquando da instanciação de uma atleta o seu país
        /// </summary>
        public string Pais { get; set; }
        /// <summary>
        /// Esta propriedade recebe a naturalidade de um atleta
        /// </summary>
        public string Naturalidade { get; set; }
        /// <summary>
        /// Propriedade que recebe os registos
        /// </summary>
        public Registo PropRegisto { get; set; }
        /// <summary>
        /// Propriedade que recebe os staffs
        /// </summary>
        public Staff PropStaff { get; set; }
        /// <summary>
        /// Propriedade que recebe as medalhas
        /// </summary>
        public List<EnumMedalhas> GetMedalhas { get; set; }
        /// <summary>
        /// Propriedade que mostra o dia das provas do atleta
        /// </summary>
        public List<DateTime> DataCompeticao { get; set; }

        #region Enumeradores
        //propriedade de especificação do enumerador
        public EnumModalidades enumModalidades { get; set; }

        #endregion

        #endregion

        #region Métodos
        //método ShowModalidades que utiliza o método foreach para correr o enumerador
        /// <summary>
        /// Este método permite o utilizador visualizar as modalidades existentes nas olimpiadas
        /// </summary>
        /// <param name="Emodalidades"></param>
        public static void ShowModalidades(string Emodalidades)
        {
            //para cada modalidade no enumerador modalidades
            foreach (EnumModalidades enumModalidades in Emodalidades)
            {
                // imprime as modalidades uma a uma
                Console.WriteLine(enumModalidades);
            }
        }
        //o c# converte para string mas o ToString() vai reescrever e mudar o comportamento da função
        public override string ToString()
        {
            string medalhas = "";
            for (int i = 0; i < GetMedalhas.Count; i++)
            {
                medalhas += GetMedalhas[i] + ";";
            }
            return ($" Id:{this.Id}\n Nome: {this.Nome}\n Naturalidade:{this.Naturalidade}\n Idade:{this.Idade}\n Peso:{this.Peso}\n Altura:{this.Altura}\n Género:{this.generoDefinido}\n Escolaridade:{this.Escolaridade}\n Clube:{this.Clube}\n Modalidade:{this.enumModalidades}\n Medalhas:{medalhas}\n País:{this.Pais}");
        }
        /// <summary>
        /// Método que adiciona um registo a um Atleta
        /// </summary>
        public static void RegistoDeCompeticoes()
        {
            Console.WriteLine("------------------Adicione o Registo-------------------");
            Console.WriteLine("Ano de Competição:");
            int anoDeCompeticao = int.Parse(Console.ReadLine());

            Console.WriteLine("Cidade:");
            string cidade = Console.ReadLine();

            Console.WriteLine("Prova:");
            string prova = Console.ReadLine();

            Console.WriteLine("Resultado:");
            string resultado = Console.ReadLine();

            DateTime data = DateTime.Now;
            //id de competição gerado automaticamente indo buscar o numero de registo e acrescentar mais 1
            int idCompeticao = (ListaRegistos.ListaDeRegistos.Count) + 1;
            Console.WriteLine("---------------------------Registo----------------------------");
            //mostra ao utilizador o registo que acabou de efetuar no sistema
            Console.WriteLine($"[{data.ToString("dd-mm-yyyy")}] Id Registo:{idCompeticao}\n Ano de Competição: {anoDeCompeticao}\n Modalidade: {ListaAtletas.atletas[ListaRegistos.optnUtilizador].enumModalidades}Cidade:{cidade}\n Prova:{prova}\n Resultado:{resultado}");
            //cria o novo registo na classe registo com os argumentos provindos do user input
            Registo registo = new Registo(data, idCompeticao, anoDeCompeticao, cidade, prova, resultado);
            //adiciona este registo à lista de registos
            ListaRegistos.ListaDeRegistos.Add(registo);
            Console.ReadKey();
        }

        /// <summary>
        /// Método que permite especificar o atleta ao qual vai ocorrer a mudança de staff
        /// </summary>
        public static void EspecificarStaff()
        {
            //limpa a consola
            Console.Clear();
            Console.WriteLine("Escolha um atleta para especificar o staff(utilize a numeração):");
            //ciclo que itera até ao numero de quantidade de atletas na lista
            for (int i = 0; i < ListaAtletas.atletas.Count; i++)
            {
                //imprime o id dos atletas e o seu respetivo nome
                Console.WriteLine($"[{ListaAtletas.atletas[i].Id}] {ListaAtletas.atletas[i].Nome}");
            }
            //recebe a opção do utilizador como inteiro e converte-o para string para o processador compilar
            int optnUtilizador = int.Parse(Console.ReadLine());
            for (int i = 0; i < ListaAtletas.atletas.Count; i++)
            {
                //Se o input do utilizador for igual ao id do atleta na lista de atletas na posição i então
                if (optnUtilizador.Equals(ListaAtletas.atletas[i].Id))
                {
                    //adiciona o nome do atleta cujo staff foi adiciona à lista atletasComStaff
                    atletasComStaff.Add(ListaAtletas.atletas[i].Nome);
                    //o utilizador pode escolher um staff para o atleta no membro elemento escolhido pelo user -1, que equivale à posição desejada, da lista 
                    ListaAtletas.atletas[optnUtilizador - 1].EscolherStaff();
                }
            }
            Console.Clear();
        }

        /// <summary>
        /// Método que permite escolher um membro de Staff para adicionar ao Atleta
        /// </summary>
        public void EscolherStaff()
        {
            //metodo acionado pelo anterior
            Console.WriteLine("Especifique o Staff");
            Console.WriteLine("Options:");
            //chama a função que permite mostrar as opções existentes de staff
            Staff.VerOptnStaff();
            //recebe o input do user
            string staff = Console.ReadLine();
            EspecificacaoStaff Estaff;
            //compara o input do user em relação ao que poderia ser semelhante ao existente
            if (staff == "Treinador" || staff == "2")
            {
                Estaff = EspecificacaoStaff.Medico;
            }
            else if (staff == "Medico" || staff == "1")
            {
                Estaff = EspecificacaoStaff.Treinador;
            }
            else
            {
                Estaff = EspecificacaoStaff.Outro;
            }
            //cria um novo staff do tipo staff no qual encarrega o cargo escolhido pelo utilizador
            Staff novoStaff = new Staff(Estaff);
            //a propriedade é set para o membro do novo staff 
            PropStaff = novoStaff;
            atletasComStaff.Add(novoStaff);
            Console.WriteLine("-Staff Adicionado-");
            Console.WriteLine(Estaff);
            Console.ReadKey();
        }
        

        public void MostrarDataProva()
        {

            Console.WriteLine("Escolha uma modalidade para ver as suas provas:");
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
            Console.WriteLine($"{DataCompeticao}");
         

        }

        #endregion

    }
}
