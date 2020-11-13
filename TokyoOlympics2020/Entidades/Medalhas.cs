using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokyoOlympics2020
{
    public enum EnumMedalhas { Ouro, Prata, Bronze, Nenhuma };
    public class Medalhas
    {
        /// <summary>
        /// Propriedade que recebe o nome da medalha
        /// </summary>
        public string NomeMedalha { get; set; }
        public EnumMedalhas enumMedalhas { get; set; }
        #region Métodos
        public override string ToString()
        {
            //ao invocar o método ToString() é retornado este output
            return ($" Id Registo:{this.NomeMedalha}\n ");
        }
        #endregion

    }
}
