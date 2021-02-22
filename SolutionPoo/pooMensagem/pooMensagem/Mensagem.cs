using System;
using System.Collections.Generic;
using System.Text;

namespace pooMensagem
{
    public class Mensagem
    {
        private string TextoMensagem;

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }
        //Get serve para pegar o valor da propriedade
        public String getTextoMensagem()
        {
            return this.TextoMensagem;
        }
        //Set definir um valor para uma propriedade que esta protegida, que esta(...)
        //(...)encapsulada usando o private
        public void setTextoMensagem(string valor)
        {
            // "ToUpper" Retorna uma cópia desta string convertida em maiúsculas.
            this.TextoMensagem = valor.ToUpper();
        }
    }
}
