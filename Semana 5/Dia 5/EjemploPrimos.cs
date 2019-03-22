using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListas
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadorPrimos=0;
            int cantidadPrimos;
            List<int> listaPrimos = new List<int>();
            cantidadPrimos= int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10000; i++ )
            {
                int c = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c<2)
                {
                    contadorPrimos++;
                    listaPrimos.Add(i);
                }
                if (contadorPrimos == cantidadPrimos)
                    break;
                
            }
            Console.WriteLine();
            foreach (var item in listaPrimos)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();

        }
    }
}
