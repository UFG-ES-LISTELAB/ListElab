using listelab_dominio.Abstrato;
using listelab_dominio.Enumeradores;
using System;
using System.Collections.Generic;
using System.Text;

namespace listelab_dominio.Conceitos
{
    /// <summary>
    /// Representa uma questão genérica.
    /// </summary>
    public class Questao : ObjetoComId
    {
        /// <summary>
        /// Representa o enunciado de uma questão.
        /// </summary>
        public string Enunciado { get; set; }

        /// <summary>
        /// Representa as áreas de conhecimento disponíveis.
        /// </summary>
        public EnumAreaDeConhecimento AreaDeConhecimento { get; set; }

        /// <summary>
        /// Representa o nível de dificuldade, indo de 1 à 5.
        /// </summary>
        public EnumNivelDificuldade NivelDificuldade { get; set; }

        /// <summary>
        /// Representa o tempo máximo para responder a questão em minutos.
        /// </summary>
        public int TempoMaximoDeResposta { get; set; }
    }
}
