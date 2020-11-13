using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokyoOlympics2020
{
    //opções limitadas
    public enum EspecificacaoStaff { Treinador, Medico, Outro };
    public class Staff
    {
        #region Construtor
        public Staff(EspecificacaoStaff especificacaoStaff)
        {
            this.especificacaoStaff = especificacaoStaff;
        }
        #endregion

        #region Propriedades
        public EspecificacaoStaff especificacaoStaff { get; set; }
        #endregion

        #region Métodos
        /// <summary>
        /// Método que mostra as opções de staff existentes no enumerador
        /// </summary>
        public static void VerOptnStaff()
        {
            int count = 1;
            foreach (string EStaff in Enum.GetNames(typeof(EspecificacaoStaff)))
            {
                Console.WriteLine("[{0}] {1}", count, EStaff);
                count++;
            }
        }
        /// <summary>
        /// Método que permite mostrar os staffs dos atletas
        /// </summary>
        public static void ShowStaff()
        {
            foreach(Atleta atleta in ListaAtletas.atletas)
            {
                if(atleta.PropStaff != null)
                {
                    Console.WriteLine(atleta);
                }
            }
            Console.Clear();
        }
        #endregion
    }
}
