using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaEResposta
{
    class Program
    {
        static void Main(string[] args)
        {
            PerguntaPlus p = new PerguntaPlus();
            p.Texto = "Qual o doce 'mais doce' que existe? ";
            p.Resposta = "batata doce";
            p.Dica = "Doce mais doce que o doce de bata(...)";

            Console.WriteLine("Tente adivinhar a pergunta");
            Console.WriteLine("Pergunta: " + p.Texto);
            Console.WriteLine("Dica: " + p.Dica);
            Console.Write("Resposta: ");
            String resposta = Console.ReadLine();

            if (p.Resposta.ToUpper() == resposta.ToUpper())
            {
                Console.WriteLine("Parabéns!!!! Você acertou.");
            }
            else
            {
                Console.WriteLine("Que pena!!!! Você acertou.");
                Console.WriteLine("A resposta correta é: " + p.Resposta);
            }
            Console.ReadKey();
        }
    }
}
