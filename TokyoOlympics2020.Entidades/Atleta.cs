using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TokyoOlimpics2020
{
    public enum EnumModalidades { Andebol, Atletismo, Badminton, Basquetebol, Boxe, Canoagem, Ciclismo, Equestre, Esgrima, Futebol, Ginastica, Golfe, Halterofilismo, Hoquei, Judo, Karate, LutasAmadoras, Natacao, PentatloModerno, Remo, Rugby, Taekwondo, Tenis, TenisDeMesa, Tiro, TiroComArco, TiroComArmasDeCaca, Triatlo, Vela, Voleibol };
    class Atleta : Pessoa
    {
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
        public Atleta(string naturalidade, string nome, int idade, float peso, float altura, Genero genero, string escolaridade, string clube, EnumModalidades modalidade)
        {
            this.Naturalidade = naturalidade;
            this.Nome = nome;
            this.Idade = idade;
            this.Peso = peso;
            this.Altura = altura;
            this.generoDefinido = genero;
            this.Escolaridade = escolaridade;
            this.Clube = clube;
            this.enumModalidades = modalidade;
        }

        public Atleta()
        {

        }
        #endregion

        #region Propriedades
        public string Clube { get; set; }
        public string Naturalidade { get; set; }
        public EnumModalidades enumModalidades;
        #endregion

        public static void ShowModalidades(string Emodalidades)
        {
            foreach (EnumModalidades enumModalidades in Emodalidades)
            {
                Console.WriteLine(enumModalidades);
            }
        }
    }
}
