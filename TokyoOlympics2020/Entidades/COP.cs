using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokyoOlympics2020
{
    class COP
    {
        #region Métodos
        /// <summary>
        /// Método que permite ao COP elaborar o quadro de honra
        /// </summary>
        public static void ElaborarQuadroDeHonra()
        {
            //cria-se uma nova lista reservada somente para os atletas medalhados diferentes de nenhuma medalha.
            List<Atleta> atletasMedalhados = new List<Atleta>();
            //ciclo que permite verificar atleta a atleta cada um dos requerimentos do if
            for (int i = 0; i < ListaAtletas.atletas.Count; i++)
            {
                //se a função confirmar que estao medalhados de acordo com as condições impostas
                if (ListaAtletas.ConfirmarMedalhado(ListaAtletas.atletas[i].Id))
                    //um atleta é adicionado à lista de medalhados
                    atletasMedalhados.Add(ListaAtletas.atletas[i]);
            }
            Console.WriteLine("-Atletas medalhados-");
            foreach (Atleta atleta in atletasMedalhados)
            {
                Console.WriteLine($"{atleta.ToString()}\n");
            }
            Console.ReadKey();

            Console.Clear();
            Program.Main();
        }
        /// <summary>
        /// Método que permite ao COP atribuir medalhas aos atletas
        /// </summary>
        public static void AtribuirMedalha()
        {

            Console.WriteLine("Escolha o atleta a atribuir a medalha:");
            //mostra os atletas existentes na lista
            ListaAtletas.Show(ListaAtletas.atletas);
            int optn = int.Parse(Console.ReadLine());
            for (int i = 0; i < ListaAtletas.atletas.Count; i++)
            {
                if (ListaAtletas.atletas[i].Id == optn)
                {
                    Console.WriteLine("Adicione uma medalha: Ouro (O), Bronze (B) , Prata (P) ou Nenhuma (N)");
                    string medalha = Console.ReadLine();
                    EnumMedalhas enumMedalhas;

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

                    ListaAtletas.atletas[i].GetMedalhas.Add(enumMedalhas);

                }
            }
        }
        #endregion
    }
}

