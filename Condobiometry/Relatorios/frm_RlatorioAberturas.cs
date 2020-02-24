using CondoBiometry.Class;
using CondoBiometry.sqLite.Repositorio;
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

namespace CondoBiometry.Relatorios
{
    public partial class frm_RlatorioAberturas : Form
    {
        CondoRepositorio repo = new CondoRepositorio();
        Modelo mod = new Modelo();
        //MySqlCommand ObjCmd;
        //MySqlDataReader ObjDr;
        public string Condominio, Cidade, Estado, NomeRelatorio, Data, InstrucaoSql;
        public frm_RlatorioAberturas()
        {
            InitializeComponent();
        }

        private void frm_RlatorioAberturas_Load(object sender, EventArgs e)
        {

            frm_Relatorio frm = new frm_Relatorio();
            NomeRelatorio = frm.NomeRelatorio;
            InstrucaoSql = frm.InstrucaoSql;
            //ConexaoDao ObjDAo = new ConexaoDao(ObjCon);
            DataTable DataTable_Report = new DataTable();

            //string sql = " SELECT Nome,cidade,estado FROM tbl_condominio WHERE id_condo =(select max(id_condo) from tbl_condominio)";


            try
            {
                //mod.sql
                //ObjCon.Abrir();
                //ObjCmd = new MySqlCommand(sql, ObjCon.Conection);
                //ObjDr = ObjCmd.ExecuteReader();

                //while (ObjDr.Read())
                //{

                Condominio condominio = repo.GetCondominio();

                Condominio = condominio.Nome;
                Cidade = condominio.cidade;
                Estado = condominio.estado;
                //}
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi possivel se conectar base de dados" + "ERROS DE COMANDOS:" + ex.Message);
            }
            this.reportViewer1.RefreshReport();
            DataTable_Report = (DataTable)dataGridView1.DataSource;
            string data = DateTime.Now.ToLongDateString();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet5", DataTable_Report));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Condominio", Condominio));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cidade", Cidade + " - " + Estado));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("NomeRelatorio", NomeRelatorio));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Data", data));
            this.reportViewer1.RefreshReport();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
