using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Linq
{
   class Program
   {
      static void Main(string[] args)
      {
         using (var context = new DBLINQConexion())
         {
            Console.WriteLine("Clientes: ");
            foreach (var c in context.Customers)
            {
               //Console.WriteLine("{0} - {1}",c.CustomerId, c.Name);
            }
            var clientesConJ = from p in context.Customers
                               where p.Name.Contains("J")
                               select p;
            Console.WriteLine("Clientes con J: ");
            foreach (var cliente in clientesConJ)
            {
               //Console.WriteLine("{0} - {1}", cliente.CustomerId, cliente.Name);
            }
            var soloClientesConJ = from p in context.Customers
                               where p.Name.Contains("J")
                               select new { Nombre = p.Name };
            foreach (var cliente in soloClientesConJ)
            {
               // Console.WriteLine("Cliente {0}", cliente);
            }

            var ordenarClientes = from c in context.Customers
                                  orderby c.Name descending
                                  select c.Name;
            Console.WriteLine("Lista descendente de clientes");
            foreach (var cliente in ordenarClientes)
            {
                Console.WriteLine("Cliente {0}", cliente);
            }

            var agruparFacturas = from f in context.Invoices
                                  group f by f.CustomerId into grupoFacturas
                                  select grupoFacturas;






         }
      }
   }
}
