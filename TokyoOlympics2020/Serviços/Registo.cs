using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokyoOlympics2020
{
    public class Registo
    {
        //variavel de estado publica
        public bool Estreia = true;
        #region Construtor
        //construtor
        public Registo(DateTime data ,int id, int anoDeCompeticao, string cidade, string prova, string resultado)
        {
            this.DataResultados = data;
            this.IdCompeticao = id;
            this.AnoDeCompeticao = anoDeCompeticao;
            this.Cidade = cidade;
            this.Prova = prova;
            this.Resultado = resultado;
            Estreia = false;
        }
        public Registo(int id, int anoDeCompeticao, string cidade, string prova, string resultado)
        {

            this.IdCompeticao = id;
            this.AnoDeCompeticao = anoDeCompeticao;
            this.Cidade = cidade;
            this.Prova = prova;
            this.Resultado = resultado;
            Estreia = false;
        }
        public Registo(int id)
        {
            this.IdCompeticao = id;
            Estreia = true;
        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Atribui a cada competição uma identificação unica
        /// </summary>
        public int IdCompeticao { get; set; }
        /// <summary>
        /// Propriedade que recebe a o ano de competição de cada atleta
        /// </summary>
        public int AnoDeCompeticao { get; set; }
        /// <summary>
        /// Propriedade que recebe a cidade de competição de cada atleta
        /// </summary>
        public string Cidade { get; set; }
        /// <summary>
        /// Propriedade que recebe o tipo de prova de competição de cada atleta
        /// </summary>
        public string Prova { get; set; }
        /// <summary>
        /// Propriedade que recebe o resultado de competição de cada atleta
        /// </summary>
        public string Resultado { get; set; }
        /// <summary>
        /// Propriedade que recebe a data da prova
        /// </summary>
        public DateTime DataResultados { get; set; }
        #endregion

        #region Métodos

        //altera o output 
        public override string ToString()
        {
            //ao invocar o método ToString() é retornado este output
            return ($" [{this.DataResultados.ToString("dd-mm-yyyy")}] Id Registo:{this.IdCompeticao}\n Ano de Competição:{this.AnoDeCompeticao}\n Cidade:{this.Cidade}\n Prova:{this.Prova}\n Resultado:{this.Resultado}");
        }
        #endregion
    }
}
