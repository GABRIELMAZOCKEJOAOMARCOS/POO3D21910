
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3D21910.DAL
{
    public class DALPOO1910
    {
        private MySqlConnection Conexao;

        private string string_de_conexao = "Persist security info = false;" +
                                        "server = localhost;" +
                                        "database=bd_Livraria;" +
                                        "user=root; pwd=01121973j;";

        public void conectar()
        {
            try
            {
                Conexao = new MySqlConnection(string_de_conexao);
                Conexao.Open();
            }
            catch(MySqlException e)
            {
                throw new Exception("Problemas ao conectar com seu Banco de Dados. Erro: " + e.Message);
            }
        }

        public void executarComando(string sql)
        {
            try
            {
                conectar();
                MySqlCommand command = new MySqlCommand(sql, Conexao);
                command.ExecuteNonQuery();
            }
            catch(MySqlException e)
            {
                throw new Exception("Problemas ao realizar comandos no Banco de Dados. Erro: " + e.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                conectar();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, Conexao);
                DataTable dt = new DataTable();
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possivel realizar a consulta no Banco de Dados. Erro: " + e.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}