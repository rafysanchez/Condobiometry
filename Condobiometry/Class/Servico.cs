using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBiometry.Class
{
    public class Servico
    {
        public string id_login { get; internal set; }
        public string resp_abertura { get; internal set; }
        public string id_ebox { get; internal set; }
        public string motivo { get; internal set; }
        public string data_ocorrencia { get; internal set; }
        public string data_conclusao { get; internal set; }
        public string resp_conclusao { get; internal set; }
        public string observacao { get; internal set; }
        public string status_os { get; internal set; }
    }
}
