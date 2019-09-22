using listelab_dominio.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace listelab_dominio.Conceitos
{
    /// <summary>
    /// Representa uma questão discursiva.
    /// </summary>
    [Colecao(Nome = "questoesDiscursivas")]
    public class QuestaoDiscursiva : Questao
    {
        /// <summary>
        /// Representa os insumos para resposta.
        /// </summary>
        public RespostaDiscursiva InsumoResposta { get; set; }
    }
}
