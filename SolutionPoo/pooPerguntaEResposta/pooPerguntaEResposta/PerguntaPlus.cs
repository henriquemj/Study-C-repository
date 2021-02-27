using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaEResposta
{

    public class PerguntaPlus:Pergunta
    {
        public PerguntaPlus():base()
        {
            this.Dica = "";
        }

        public PerguntaPlus(String texto, String resposta):base(texto, resposta)
        {
            this.Dica = "";
        }
        public String Dica { get; set; }

    }
}
