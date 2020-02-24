using CondoBiometry.Formularios;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondoBiometry.Class
{
    class Backup_Develophers
    {
        const string db_version = "34";
        const string db_nome = "condo_biometry";
        public string db_caminhoBackup = Develophers.local_backup;//pega do formulario txt_localBAckup
        const string db_extension = ".sql";
        public static string Script_sql;

        public string GetBackupFileName()
        {
            DateTime strDataAtual = DateTime.Now; //Pega data atual
            string strBackupLocal, strBackupNome; //cria variaveis
            string[] strAddLetra = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" }; //cria vetor de variaveis para incrementar
            int letra;
            //converte datas para string
            string strDate = Convert.ToString(strDataAtual.Date);
            string strMes = Convert.ToString(strDataAtual.Month);
            string strDia = Convert.ToString(strDataAtual.Day);
            string strAno = Convert.ToString(strDataAtual.Year);

            strDia = (strDia.Length == 1) ? "0" + strDia : strDia;
            strMes = (strMes.Length == 1) ? "0" + strMes : strMes;

            string t = "-";

            strBackupLocal = db_caminhoBackup + db_nome + strDia + t + strMes + t + strAno; //cria o backup com nome e data atual do backup
            strBackupNome = strBackupLocal + db_extension; //cria o arquivo nome .sql
            if (File.Exists(strBackupNome))
            {
                // se ja exixte um backup realizado no mesmo dia  letra A. ex(varsoft20122015a)
                letra = 0;
                strBackupNome = strBackupLocal + strAddLetra[letra] + db_extension;
                while (File.Exists(strBackupNome))
                {
                    //enquanto for realizado novo backup diario adicionar nova letra no final
                    letra++;
                    strBackupNome = strBackupLocal + strAddLetra[letra] + db_extension;
                }
            }
            return strBackupNome;
        }

        public void Realizar_Backup()
        {
            try
            {
                string strBackup_Nome = GetBackupFileName();//pega o nome gerado no metodo
                StreamWriter sw = new StreamWriter(strBackup_Nome);

                ProcessStartInfo psinfo = new ProcessStartInfo();
                // psinfo.FileName = "C:\\Program Files (x86)\\MySQL\\MySQL Workbench 6.0 CE\\mysqldump";//caminho de instalação mysql
                psinfo.FileName = Develophers.caminho_instalacao_Mysql + "\\mysqldump";
                psinfo.RedirectStandardInput = false;
                psinfo.RedirectStandardOutput = true;
                psinfo.Arguments = ("--host=localhost --user=root --password=34362377rr condo_biometry");//Acesso ao banco                
                psinfo.UseShellExecute = false;
                Process Iniciar_Backup = Process.Start(psinfo);
                string stdout;
                stdout = Iniciar_Backup.StandardOutput.ReadToEnd();
                sw.WriteLine(stdout);
                Iniciar_Backup.WaitForExit();
                sw.Close();
                Iniciar_Backup.Close();

                MessageBox.Show("O BACKUP FOI REALIZADO COM SUCESSO!" + "\n" + "LOCAL DO ARQUIVO: " + strBackup_Nome, "SUCESSO",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Não foi possível realzar o backup." + "\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Realizar_Restore()
        {
            Develophers frm = new Develophers();
            Script_sql = frm.Arquivo_sql;

            // string strRestoreNome = db_caminhoBackup + Script_sql;
            string strRestoreNome = Script_sql;
            try
            {
                StreamReader sr = new StreamReader(strRestoreNome);
                string stdin = sr.ReadToEnd();
                sr.Close();

                ProcessStartInfo psinfo = new ProcessStartInfo();
                psinfo.FileName = Develophers.caminho_instalacao_Mysql + "\\mysql";
                psinfo.RedirectStandardInput = true;
                psinfo.RedirectStandardOutput = false;
                psinfo.Arguments = ("--host=localhost --user=root --password=34362377rr condo_biometry");//Acesso ao banco  
                psinfo.UseShellExecute = false;

                Process Iniciar_Restore = Process.Start(psinfo);
                Iniciar_Restore.StandardInput.WriteLine(stdin);
                Iniciar_Restore.StandardInput.Close();
                Iniciar_Restore.WaitForExit();
                Iniciar_Restore.Close();

                MessageBox.Show("RESTAURAÇÃO REALIZADA COM SUCESSO!" + "\n" + "ORIGEM DE ARQUIVO:  " + strRestoreNome, "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Não foi possível restaurar base de dados! " + "\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Instalar_BancoDados()
        {
            Develophers frm = new Develophers();
            Script_sql = frm.Arquivo_sql;

            // string strRestoreNome = db_caminhoBackup + Script_sql;
            string strRestoreNome = Script_sql;
            try
            {
                 StreamReader sr = new StreamReader(strRestoreNome);
                string stdin = sr.ReadToEnd();
                sr.Close();
                ProcessStartInfo psinfo = new ProcessStartInfo();
                // psinfo.FileName = "C:\\Program Files (x86)\\MySQL\\MySQL Workbench 6.0 CE\\mysql";//caminho de instalação mysql
                psinfo.FileName = Develophers.caminho_instalacao_Mysql + "\\mysql";
                psinfo.RedirectStandardInput = true;
                psinfo.RedirectStandardOutput = false;
                psinfo.Arguments = ("--host=localhost --user=root --password=34362377rr");//Acesso ao banco      
                //"SERVER=127.0.0.1;DATABASE=condo_biometry;UID=root;PASSWORD=34362377rr;";
                psinfo.UseShellExecute = false;
                Process Iniciar_Restore = Process.Start(psinfo);
                Iniciar_Restore.StandardInput.WriteLine(stdin);
                Iniciar_Restore.StandardInput.Close();
                Iniciar_Restore.WaitForExit();
                Iniciar_Restore.Close();

                MessageBox.Show("BANCO DE DADOS FOI CRIADO COM SUCESSO!" + "\n" + "ORIGEM DE ARQUIVO:  " + strRestoreNome, "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Não foi possível criar a base de dados! " + "\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
