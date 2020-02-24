using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBiometry
{
    class DadosConexao
    {

        //Metodo contrutor devolve string de conexao com banco de dados
        public static string StringConection
        {
            get
            {
                return "SERVER=127.0.0.1;DATABASE=condo_biometry;UID=root;PASSWORD=34362377rr;";
            }
        }

        public static string StringConectionSqLite
        {
            get
            {
                
                string caminho = string.Format(@"{0}\{1}\{2}", Environment.CurrentDirectory, "Data", "condo_biometry.db");
               
                return caminho;
            }
        }



    }
}
