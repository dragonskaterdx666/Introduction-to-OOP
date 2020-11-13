using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TokyoOlympics2020
{
    //enumerador que permite escolher o género
    public enum Genero { Feminino, Masculino, Nenhum, Outro }
    public abstract class Pessoa
    {
        #region Propriedades

        /// <summary>
        /// Esta propriedade recebe o nome da pessoa
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Propriedade que recebe a idade de cada pessoa
        /// </summary>
        public int Idade { get; set; }
        /// <summary>
        /// Propriedade que recebe o peso da pessoa
        /// </summary>
        public float Peso { get; set; }
        /// <summary>
        /// Propriedade que recebe a altura da pessoa
        /// </summary>
        public float Altura { get; set; }
        /// <summary>
        /// Propriedade que recebe a escolaridade de uma nova pessoa
        /// </summary>
        public string Escolaridade { get; set; }
        /// <summary>
        /// Propriedade que recebe o género do enumerador de pessoa
        /// </summary>
        public Genero generoDefinido { get; set; }
        #endregion

    }
}
