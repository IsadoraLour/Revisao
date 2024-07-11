using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Automovel
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public string placa { get; set; }

        public Automovel(string Placa)
        {
                placa= Placa;
        }

    }
}
