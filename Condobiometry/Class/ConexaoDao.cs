using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBiometry
{
    class ConexaoDao
    {

        //Objetos para representar e instanciar a classe de conexao

        private Conexao ObjCon;        //instancia classe de conexao
        private MySqlCommand ObjCmd;     //intancia classe de comandos mysql
        private MySqlDataReader ObjDr;   // instancia classe de leitura mysql
       
        private DataTable ObjDt;         //instancia classe de dados e tabelas

        public ConexaoDao(Conexao StrConn) //Metodo construtor.
        {
            this.ObjCon = StrConn;
        }
        public ConexaoDao()
        {
            // TODO: Complete member initialization
        }

        // Metodos verificacao e login no sistema  e retorna todos dados do acesso  
        public void Verifica_Login(Modelo mod)
        {
            try
            {
                //mod.sql
                ObjCon.Abrir();
                ObjCmd = new MySqlCommand(mod.sql, ObjCon.Conection);
                ObjDr = ObjCmd.ExecuteReader();

                while (ObjDr.Read())
                {
                    mod.user_logado = ObjDr["id_login"].ToString();
                    mod.nome = ObjDr["nome"].ToString();
                    mod.senha = ObjDr["senha"].ToString();
                }   
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi possivel se conectar base de dados" + "ERROS DE COMANDOS:" + ex.Message);
            }
            ObjCon.Fechar();
        }
        //Metodo responsavel por preencher todos datagreedview
        public DataTable ListarTabela_DGV(Modelo mod)
        {
            ObjDt = new DataTable();//obtem o numero linhas e colunas da tabela
            ObjCmd = new MySqlCommand(mod.sql, ObjCon.Conection);
            {
                ObjCon.Abrir();
                ObjDt.Load(ObjCmd.ExecuteReader());
                ObjCon.Fechar();
            }

            return ObjDt;
        }
        //metodo responsavel por listar todos usuarios logados
        public DataTable ListarDados(Modelo mod)
        {

            ObjDt = new DataTable(mod.nome);//pego somente coluna 
            string sql = mod.sql;// query de conexao
            MySqlCommand comandos = new MySqlCommand(sql, ObjCon.Conection);
            {
                ObjCon.Abrir();
                ObjDt.Load(comandos.ExecuteReader());
                ObjCon.Fechar();
            }

            return ObjDt;
        }
        //Metodo para inclusao de dados no mysql em todas tabelas
        public void InclusaoDados(Modelo mod)
        {
            try
            {
                ObjCon.Abrir();
                ObjCmd = new MySqlCommand(mod.sql, ObjCon.Conection);
                ObjCmd.ExecuteNonQuery();//executa os comandos sql
                ObjCon.Fechar();
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi possivel se conectar base de dados" + "ERROS DE COMANDOS:" + ex.Message);
            }
            finally
            {
            }
        }//fecha metodo 
        public void Select_Dados(Modelo mod)
        {
            try
            {
                //mod.sql
                ObjCon.Abrir();
                ObjCmd = new MySqlCommand(mod.sql, ObjCon.Conection);
                ObjDr = ObjCmd.ExecuteReader();

                while (ObjDr.Read())
                {
                    //  mod.qtde = ObjDr["renda_bruta"].ToString();
                    //  mod.qtde_parcela = ObjDr["renda_extra"].ToString();
                    //  mod.parcela_pagas = ObjDr["mais_renda"].ToString();
                    //  mod.parcela_restante = ObjDr["desc_fgts"].ToString();
                    //  mod.produto = ObjDr["desc_convenio"].ToString();
                    //  mod.str[15] = ObjDr[mod.str[5]].ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi possivel se conectar base de dados" + "ERROS DE COMANDOS:" + ex.Message);
            }
            ObjCon.Fechar();
        }
        //metodo para inserir ID quando clicar no nome dentro combobox
        public void Retorna_String1(Modelo mod)
        {
            ObjCon.Fechar();
            try
            {
                ObjCon.Abrir();
                string retorno = mod.string_1; //recebe o nome da coluna ID chave primaria  partir do formulario
                string sql = mod.sql; //recebe query

                ObjCmd = new MySqlCommand(sql, ObjCon.Conection);
                ObjDr = ObjCmd.ExecuteReader();

                while (ObjDr.Read())
                {
                    mod.string_1 = ObjDr[retorno].ToString(); //retorna o select e devolve para o formulario
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi possivel se conectar base de dados" + "ERROS DE COMANDOS:" + ex.Message);
            }
            ObjCon.Fechar();
        }
        //Metodo responsavel para fazer alteração e exclusão no mysql em todas tabelas
        public void Modifica_Dados(Modelo mod)
        {

            try  //tenta execultar o código
            {
                ObjCon.Abrir(); //abre conexão                   
                string sql = mod.sql; //quer passa pelo formulario
                ObjCmd = new MySqlCommand(sql, ObjCon.Conection); //cria objetos para executar os comandos
                int affectedRows = ObjCmd.ExecuteNonQuery(); //retorna valores
                if (affectedRows > 0)
                {
                    //console = "Alteração realizada com sucesso.";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi possivel se conectar base de dados" + "ERROS DE COMANDOS:" + ex.Message);
            }
            finally
            {
            }
            ObjCon.Fechar();

        }
        public void Retorna_String3(Modelo mod)
        {
            ObjCon.Fechar();
            try
            {
                ObjCon.Abrir();

                string retorno = mod.string_1; //recebe o nome da coluna ID chave primaria  partir do formulario
                string retorno2 = mod.string_2;
                string retorno3 = mod.string_3;
                string sql = mod.sql; //recebe query

                ObjCmd = new MySqlCommand(sql, ObjCon.Conection);
                ObjDr = ObjCmd.ExecuteReader();

                while (ObjDr.Read())
                {
                    mod.string_1 = ObjDr[retorno].ToString(); //retorna o select e devolve para o formulario
                    mod.string_2 = ObjDr[retorno2].ToString();
                    mod.string_3 = ObjDr[retorno3].ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi possivel se conectar base de dados" + "ERROS DE COMANDOS:" + ex.Message);
            }
            ObjCon.Fechar();
        }
        //public void key_changed( Modelo mod)
        // {

        //     string key = "AAAAAAAAAA";
        //     try
        //     {
        //         ConexaoDao ObjDAo = new ConexaoDao(ObjCon);
        //         mod.sql = "Select data_cad from tbl_usuario where id_user = 5";
        //         mod.string_1 = "data_cad";
        //         ObjDAo.Retorna_String1(mod);

        //         DateTime data_inicio = Convert.ToDateTime(mod.string_1);
        //        // MessageBox.Show(data_inicio.ToString());
        //        DateTime fim = DateTime.Now;
        //        int totalDias = fim.Subtract(data_inicio).Days;
        //        mod.string_2 = totalDias.ToString();              
        //       int dias = int.Parse(mod.string_2);

        //       string arquivo = "key_changed.txt";

        //       if (File.Exists(arquivo))
        //       {
        //           try
        //           {
        //               using (StreamReader sr = new StreamReader(arquivo))
        //               {
        //                   String linha;
        //                   // Lê linha por linha
        //                   linha = sr.ReadLine();
        //                   if (linha == key)
        //                   {
        //                       mod.string_3 = "10";
        //                   }
        //               }
        //           }
        //           catch (Exception ex)
        //           {
        //               MessageBox.Show(ex.Message);
        //           }
        //       }

        //       Backup bk = new Backup();
        //       bk.Retorna_keyChanged(mod);
        //       int key = int.Parse(mod.string_3);
        //       if (dias > 90)
        //       {
        //           if (key == 10)
        //           {
        //               MessageBox.Show("Ativado.");
        //           }
        //           else
        //           {
        //               MessageBox.Show("experiencia venceu.");
        //           }
        //       }

        //     }
        //     catch
        //     {

        //     }            

        // } 
    }
}
