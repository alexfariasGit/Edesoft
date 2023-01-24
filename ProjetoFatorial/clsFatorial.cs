using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFatorial
{
    public static class clsFatorial
    {
        private static Int32 fatorial(Int32 num)
        {
            if (num == 1)
            {
                return 1;
            }
            // Poderia colocar um else, porem como eh usado o return, ele nao eh mais necessario
            return num * fatorial(num - 1);
        }

        public static void IniciandoProjeto()
        {
            Int32 num;
            String entrada;

            Console.Write("Insira um numero inteiro: ");
            entrada = Console.ReadLine();

            Int32.TryParse(entrada, out num);
            if (num == 0)
            {
                Console.Write("O valor digitado precisa ser inteiro!");
                Console.WriteLine(Environment.NewLine);
                IniciandoProjeto();
            }

            Console.WriteLine("Fatorial de " + num + " eh: " + fatorial(num));
            Console.ReadKey();

        }
    }
    
}
