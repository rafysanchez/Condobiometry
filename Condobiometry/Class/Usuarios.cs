using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBiometry.Class
{
    public class Usuarios
    {
        public int id_user { get; set; }

        public int id_login { get; set; }

        public string Perfil { get; set; }

        public string nome { get; set; }

        public string Apartamento { get; set; }

        public string Bloco { get; set; }

        public string Funcao { get; set; }

        public string Empresa { get; set; }

        public string Senha { get; set; }

        public string id_biometria { get; set; }

        public string Status { get; set; }

        public DateTime Data_cad { get; set; }

        public string Codigo { get; set; }

        public string Cadastro { get; set; }
        public string Operador { get; internal set; }
    }
}
