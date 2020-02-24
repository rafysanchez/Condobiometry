using CondoBiometry.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondoBiometry.Formularios
{
    public partial class Develophers : Form
    {
        Conexao ObjCon = new Conexao(DadosConexao.StringConection);
        Modelo mod = new Modelo();

        public static string port_Com;
        public string Data,readSerial;
        public string user_login;
        public string id_login;
        public string abrir_ebox;
        String[] comandSerial = { "Ç", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "X", "W", "Y", "Z" };

        public static string script_backup;//passa  valor para class
        public static string local_backup;
        public static string local_restore;
        public static string caminho_instalacao_Mysql;


        public string Caminho_backup
        {
            get { return local_backup; }
        }
        public string Caminho_restore
        {
            get { return local_restore; }
        }
        public string Arquivo_sql
        {
            get { return script_backup; }
        }
        public string local_instalacao
        {
            get { return caminho_instalacao_Mysql; }
        }
        public Develophers()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            port_Com = txt_listsPort.SelectedItem.ToString();
        }

        private void Develophers_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("REALMENTE DESEJA SAIR DO SISTEMA ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_principal frm = new frm_principal();
            this.Hide();
            frm.Show();
        }

        private void btn_principal_Click(object sender, EventArgs e)
        {
            frm_principal frm = new frm_principal();
            frm.Show();
        }

        private void btn_setup_Click(object sender, EventArgs e)
        {
            frm_Setup frm = new frm_Setup();
            frm.Show();
        }

        private void btn_retirar_Click(object sender, EventArgs e)
        {
            frm_Retirar frm = new frm_Retirar();
            frm.Show();
        }

        private void btn_entregar_Click(object sender, EventArgs e)
        {
            frm_Entregar frm = new frm_Entregar();
            frm.Show();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            frm_Cadastro frm = new frm_Cadastro();
            frm.Show();
        }

        private void btn_P_compartimentos_Click(object sender, EventArgs e)
        {
            frm_PainelComparimentos frm = new frm_PainelComparimentos();
            frm.Show();
        }

        private void btn_encomendas_Click(object sender, EventArgs e)
        {
            frm_ConsultaEncomendas frm = new frm_ConsultaEncomendas();
            frm.Show();
        }

        private void btn_compartimentos_Click(object sender, EventArgs e)
        {
            frm_Compartimentos frm = new frm_Compartimentos();
            frm.Show();
        }

        private void btn_manutencao_Click(object sender, EventArgs e)
        {
            frm_Manutencao frm = new frm_Manutencao();
            frm.Show();
        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            frm_Relatorio frm = new frm_Relatorio();
            frm.Show();
        }

        private void btn_local1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "CAMINHO DA INSTALAÇÃO DO BANCO DE DADOS.";
            //abre caixa de diálogo para a busca de uma pasta para se salvar os arquivos
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_local_instalacaoMysql.Text = folderBrowserDialog1.SelectedPath;
                caminho_instalacao_Mysql = txt_local_instalacaoMysql.Text;

            }
        }

        private void btn_local3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "LOCAL PARA FAZER O BACKUP.";
            //abre caixa de diálogo para a busca de uma pasta para se salvar os arquivos
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_local_Backup.Text = folderBrowserDialog1.SelectedPath;
                local_backup = txt_local_Backup.Text;

            }
        }

        private void btn_local2_Click(object sender, EventArgs e)
        {
            txt_localArquivoSql.Text = "";
            //define as propriedades do controle 
            //OpenFileDialog
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "SELECIONE ARQUIVO DE RECUPERAÇAO";
            openFileDialog1.InitialDirectory = "C:\\";
            //filtra para exibir somente arquivos .sql    
            openFileDialog1.Filter = "Arquivo SQL(*.sql)|*.sql";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in openFileDialog1.FileNames)
                {
                    txt_localArquivoSql.Text += arquivo;
                    script_backup = txt_localArquivoSql.Text;
                    caminho_instalacao_Mysql = txt_local_instalacaoMysql.Text;
                    // script_backup = System.IO.Path.GetFileName(openFileDialog1.FileName);
                }
            }
        }

        private void btn_InstalarMysql_Click(object sender, EventArgs e)
        {
            if (txt_localArquivoEXE.Text == "")
            {
                MessageBox.Show("SELECIONE O ARQUIVO EXECUTÁVEL MYSQL.EXE. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.Diagnostics.Process.Start(txt_localArquivoEXE.Text);
            }
        }

        private void btn_instalarPlugin_Click(object sender, EventArgs e)
        {
            if (txt_localArquivoEXE.Text == "")
            {
                MessageBox.Show("SELECIONE O ARQUIVO EXECUTÁVEL PLUGIN.EXE. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.Diagnostics.Process.Start(txt_localArquivoEXE.Text);
            }
        }

        private void btn_InstalarDotNEt_Click(object sender, EventArgs e)
        {
            if (txt_localArquivoEXE.Text == "")
            {
                MessageBox.Show("SELECIONE O ARQUIVO EXECUTÁVEL CONECTOR_NET.EXE. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.Diagnostics.Process.Start(txt_localArquivoEXE.Text);
            }
        }

        private void btn_local4_Click(object sender, EventArgs e)
        {
             txt_localArquivoEXE.Text = "";
            //define as propriedades do controle 
            //OpenFileDialog
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "SELECIONE ARQUIVO DE RECUPERAÇAO";
            openFileDialog1.InitialDirectory = "C:\\";
            //filtra para exibir somente arquivos .sql    
            openFileDialog1.Filter = "Arquivo EXE(*.exe)|*.exe";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in openFileDialog1.FileNames)
                {
                    txt_localArquivoEXE.Text += arquivo;
                    // script_backup = txt_localArquivoSql.Text;
                    // caminho_instalacao_Mysql = txt_local_instalacaoMysql.Text;
                    // script_backup = System.IO.Path.GetFileName(openFileDialog1.FileName);
                }
            }
        }

        private void btn_criarBD_Click(object sender, EventArgs e)
        {
            Backup_Develophers develophers = new Backup_Develophers();
            develophers.Instalar_BancoDados();
        }

        private void btn_RestaurarBD_Click(object sender, EventArgs e)
        {
            if (script_backup == null)
            {
                MessageBox.Show("SELECIONE O ARQUIVO PARA RESTAURAÇÃO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Backup_Develophers develophers = new Backup_Develophers();
                develophers.Realizar_Restore();
            }
            
        }

        private void btn_RealizarBackup_Click(object sender, EventArgs e)
        {
            Backup_Develophers develophers = new Backup_Develophers();
            develophers.Realizar_Backup();
        }

        private void btn_trucateBD_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void txt_listsPort_Click(object sender, EventArgs e)
        {
            txt_listsPort.Items.Clear();
            txt_listsPort.Text =  "";
            foreach (string s in SerialPort.GetPortNames())
            {
                txt_listsPort.Items.Add(s);
            }
        }

        private void btn_conectarArduino_Click(object sender, EventArgs e)
        {
            if (btn_conectarArduino.Text == "Conectar")
            {
                if (txt_listsPort.Text == "")
                {
                    MessageBox.Show("PRIMEIRO SELECIONA A PORTA PARA CONEXÃO COM O ARDUINO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    try
                    {
                        if (port_Com != null)
                        {
                            serialPort1.PortName = port_Com;
                        }

                        if (serialPort1.IsOpen != true)
                        {
                            serialPort1.Open();
                            if (serialPort1.IsOpen)
                            {
                                txt_StatusPort.Text = "Conectado:  " + port_Com;
                                txt_statusPorta.Text = "Conectado:  " + port_Com;
                                btn_conectarArduino.Text = "Desconectar";
                            }
                        }

                    }
                    catch
                    {
                        MessageBox.Show("ERRO DE CONEXÃO COM O ARDUINO." + "\n" + "VERIFIQUE SE O CABO USB ESTA CONECTADO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else if (btn_conectarArduino.Text == "Desconectar")
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                        if (serialPort1.IsOpen != true)
                        {
                            txt_StatusPort.Text = "Não conectado: ****";
                            txt_statusPorta.Text = "Não conectado: ****";
                            btn_conectarArduino.Text = "Conectar";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("ERRO DE CONEXÃO COM O ARDUINO." + "\n" + "VERIFIQUE SE O CABO USB ESTA CONECTADO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btn_AbrirTodos_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("b");
            }
        }

        private void btn_AbrirUm_Click(object sender, EventArgs e)
        {
            abrir_ebox = comandSerial[int.Parse(numericUpDown1.Text)];
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(abrir_ebox);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(Read_serial));   //chama outra thread para escrever o dado no text box 
        }
        private void Read_serial(object sender, EventArgs e)
        {
            txt_msgPort.Text = "";
            try
            {
              readSerial = serialPort1.ReadLine();
              txt_msgPort.Text = readSerial;           
                if ((readSerial.IndexOf("@") > 0))
                {
                    txt_biometriaRemovida.Text = readSerial.Substring(0,( readSerial.IndexOf("@")));
                   
                }
                /*
                txt_msgBox.Text = Serial_read;
                if (Serial_read.IndexOf("#") > 0)
                {
                    msg_portCom = Serial_read.Substring(0, (Serial_read.IndexOf("#")));

                    rtn_Arduino_Ebox = int.Parse(msg_portCom);

                    if (rtn_Arduino_Ebox == 1)
                    {
                        btn_Porta.Text = "COMPARTIMENTO ABERTO";
                        btn_Porta.BackColor = Color.Lime;
                        btn_Porta.ForeColor = Color.Red;
                        btn_ConfirmarPage5.Enabled = true;
                    }

                    else if (rtn_Arduino_Ebox == 2)
                    {
                        btn_Porta.Text = "COMPARTIMENTO FECHADO";
                        btn_Porta.BackColor = Color.MidnightBlue;
                        btn_Porta.ForeColor = Color.Gold;
                    }

                    else if (rtn_Arduino_Ebox == 3)
                    {
                        btn_Porta.Text = "COMPARTIMENTO ERROR";
                        btn_Porta.BackColor = Color.Red;
                        btn_Porta.ForeColor = Color.Gold;
                    }
                }*/
            }
            catch
            {
                MessageBox.Show("A CONEXÃO COM O ARDUINO FOI PERDIDA. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RemoverBiometrias_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("e");
            }
        }

        private void btn_TesteLeitor_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("f");
            }
        }
        private void txt_local_instalacaoMysql_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            btn_AbrirUm.Text = "Abrir o " + numericUpDown1.Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
                       
       
    }
}
