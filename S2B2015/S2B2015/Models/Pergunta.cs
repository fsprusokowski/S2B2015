using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2B2015.Models
{
    public class Pergunta
    {
        public int PerguntaId { get; set; }
        public int UsuarioId { get; set; }

        public virtual Usuario oUsuario { get; set; }

        private string strPergunta;

        DateTime dtPergunta;

        public string strRespostas;

        DateTime dtResposta;

    }
}
