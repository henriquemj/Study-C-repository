using System;
using System.Collections.Generic;
using System.Text;

namespace pooMensagem
{
    public class Mensagem
    {
        private string textoMensagem;

        public String TextoMensagem
        {
            get
             {
                return this.textoMensagem;
             }

            set
            {
                this.textoMensagem = value.ToUpper();
            }
        }

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }
    }
}
