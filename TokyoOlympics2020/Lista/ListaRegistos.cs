using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokyoOlympics2020
{
    public class ListaRegistos: List<Registo>
    {
        public static int optnUtilizador;
        //cria a lista estática pública de registos
        public static List<Registo> ListaDeRegistos = new List<Registo>();
        /// <summary>
        /// Método que permite mostrar os Registos existentes de um atleta
        /// </summary>
        /// <param name="registoAtleta"></param>
        public static void ShowRegistos(List<Registo> registoAtleta)
        {
            //limpa a consola
            Console.Clear();
            Console.WriteLine("Registo de Atletas:");
            //para cada atleta com registo 
            foreach (Registo atleta in registoAtleta)
            {
                //escreve-se o atleta que corresponda a esse requisito
                Console.WriteLine(atleta.ToString());
                Console.WriteLine("---------------------------------------");               
            }
            Console.ReadKey();
            //retorna à função main que gera o menu principal
            Console.WriteLine("0.Retornar à main");
            Program.Main();
        }
        /// <summary>
        /// Método que permite adicionar um Registo de um atleta
        /// </summary>
        public static void AddRegisto()
        {
            //escreve na consola
            Console.WriteLine("Escolha um atleta para adicionar um registo (utilize a numeração):");
            //ciclo que itera o número de vezes equivalente ao tamanho da lista de atletas (quantidade de atletas na lista)
            for (int i = 0; i < ListaAtletas.atletas.Count; i++)
            {
                //escreve na consola os atletas que existem na lista, o nome e a identificação, não se pode adicionar registo de um utilizador que não existe
                Console.WriteLine($"[{ListaAtletas.atletas[i].Id}] {ListaAtletas.atletas[i].Nome}");
            }
            //convert o inteiro que o utilizador introduziu para string para a máquina poder processar
            optnUtilizador = int.Parse(Console.ReadLine());
            //ciclo do tamanho da quantidade de atletas na lista
            for (int i = 0; i < ListaAtletas.atletas.Count; i++)
            {
                //Se o valor inserido pelo utilizador foi igual à identificação do utilizador então
                if (optnUtilizador.Equals(ListaAtletas.atletas[i].Id))
                {
                    //a função de criar registo é aberta
                    Atleta.RegistoDeCompeticoes();
                }
                else
                {
                    //erro de criação de registo
                    throw new Exception("Não pode criar o registo de um utilizador que não existe!");
                }
            }
        }
        public override string ToString()
        {
            return ($"Registos:\n {ListaDeRegistos}");
        }

    }
}
