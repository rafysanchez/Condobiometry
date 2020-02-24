using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondoBiometry.Class
{
    public class BackupRestore
    {
        public string local_backup { get; internal set; }
        public TextBox local_bd { get; internal set; }
        public string freq_backup { get; internal set; }
        public string local_restore { get; internal set; }
        public string data_cad { get; internal set; }
        public string id_login { get; internal set; }
        public string hora { get; internal set; }
        public string execucao { get; internal set; }
    }
}
