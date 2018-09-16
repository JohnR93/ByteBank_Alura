using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class ExtratorURL
    {
        private readonly string argumentos;
        public string URL { get; }

        public ExtratorURL(string url)
        {
            if(String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }

            URL = url;
            int indiceInterrogação = url.IndexOf('?');
            argumentos = url.Substring(indiceInterrogação + 1);
        }

        public string GetValor(string nomeParametro)
        {
            int indice = argumentos.IndexOf(nomeParametro);
            int parametroTamanho = nomeParametro.Length;
            return argumentos.Substring(indice + parametroTamanho + 1);
        }
    }
}
