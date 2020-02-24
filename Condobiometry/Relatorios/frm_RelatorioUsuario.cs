using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondoBiometry.DataSet_Report
{
    public partial class frm_RelatorioUsuario : Form
    {
        Conexao ObjCon = new Conexao(DadosConexao.StringConection);
        Modelo mod = new Modelo();
        MySqlCommand ObjCmd;
        MySqlDataReader ObjDr;
        public string Condominio,Cidade,Estado,NomeRelatorio,Data,InstrucaoSql;
        public frm_RelatorioUsuario()
        {
            InitializeComponent();
        }
        
        private void frm_RelatorioUsuario_Load(object sender, EventArgs e)
        {
            frm_Relatorio frm = new frm_Relatorio();
            NomeRelatorio = frm.NomeRelatorio;
            InstrucaoSql = frm.InstrucaoSql;
            ConexaoDao ObjDAo = new ConexaoDao(ObjCon);
            DataTable DataTable_Report = new DataTable();

            string sql = " SELECT Nome,cidade,estado FROM tbl_condominio WHERE id_condo =(select max(id_condo) from tbl_condominio)";
            try
            {
                //mod.sql
                ObjCon.Abrir();
                ObjCmd = new MySqlCommand(sql, ObjCon.Conection);
                ObjDr = ObjCmd.ExecuteReader();

                while (ObjDr.Read())
                {                
                    Condominio = ObjDr["Nome"].ToString();
                    Cidade = ObjDr["cidade"].ToString();
                    Estado = ObjDr["estado"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi possivel se conectar base de dados" + "ERROS DE COMANDOS:" + ex.Message);
            }
            this.reportViewer1.RefreshReport();      
            DataTable_Report = (DataTable)dataGridView1.DataSource;
            string data = DateTime.Now.ToLongDateString();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", DataTable_Report));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Condominio", Condominio));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cidade", Cidade + " - "+ Estado));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("NomeRelatorio", NomeRelatorio));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Data",data));
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

         
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
