using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBiometry.Class
{
    public class Entrega
    {
        // data_inclusao,bloco,apto,data_retirada,status_retirada
        public string id_login { get; internal set; }
        public int id_ebox { get; internal set; }
        public string num_encomenda { get; internal set; }
        public string Apartamento { get; internal set; }
        public string Bloco { get; internal set; }
        public string data_inclusao { get; internal set; }
        public string data_retirada { get; internal set; }
        public string id_morador { get; internal set; }
        public string nome_morador { get; internal set; }
        public string status_retirada { get; internal set; }
        public string processo { get; set; }

    }
}
