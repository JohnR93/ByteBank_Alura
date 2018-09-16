using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string URL = "bytebankl.com/moeda?moedaOrigem=real&moedaDestino=dolar";
            ExtratorURL extratorURl = new ExtratorURL(URL);
            Console.WriteLine(extratorURl.GetValor("moedaDestino"));
            Console.ReadLine();
        }
    }
}
