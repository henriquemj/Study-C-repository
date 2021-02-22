using System;

namespace pooMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
           Mensagem msg1;
            msg1 = new Mensagem();
            msg1.setTextoMensagem("Alô Mundo");
            Console.WriteLine(msg1.getTextoMensagem());

            Console.ReadKey();

        }
    }
}
