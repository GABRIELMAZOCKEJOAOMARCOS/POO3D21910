using POO3D21910.DAL;
using POO3D21910.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;

namespace POO3D21910.BLL
{
    public class BLLPOO1910cs
    {

        private DALPOO1910 daoBanco = new DALPOO1910();

        //Recupera o Id do autor e da Empresa
        public DataTable ListarIdAutor()
        {
            string consulta = string.Format($@"select * from TBL_Autor;");
            return daoBanco.ExecutarConsulta(consulta);
        }

        public DataTable ListarIdEditora()
        {
            string consulta = string.Format($@"select * from TBL_Editora;");
            return daoBanco.ExecutarConsulta(consulta);
        }


        // Metodo para Consultar os dados do Cliente

        public DataTable ListarLivros()
        {
            string sql = string.Format($@"select * from TBL_Livro");
            return daoBanco.ExecutarConsulta(sql);
        }


        // Metodo utilizado para Update na tabela Cliente
        public void AlterarLivro(DTOLIVROS1910 dtolivros)
        {
            string sql = string.Format($@"UPDATE TBL_Livro set 
                                                                idAutor = '{dtolivros.IdAutor}',
                                                                idEditora = '{dtolivros.IdEditora}',
                                                                titulo = '{dtolivros.Titulo}',
                                                                 dataCadastro = '{dtolivros.DataCadastro}',
                                                                 numPaginas = '{dtolivros.NumPags}',
                                                                 valor = '{dtolivros.Valor}',
                                                where idLivro = '{dtolivros.IdLivro}';");
            daoBanco.executarComando(sql);

        }
        // Metodo para Pesquisar Clientes no banco de dados de acordo com a condicao


        // Metodo para Inserir Clientes
        public void InserirLivros(DTOLIVROS1910 dtolivros)
        {
            string sql = string.Format($@"INSERT INTO TBL_Livro VALUES (NULL,'{dtolivros.IdAutor}',
                                                                               '{dtolivros.IdEditora}',   
                                                                               '{dtolivros.Titulo}',
                                                                               '{dtolivros.DataCadastro}',
                                                                               '{dtolivros.NumPags}',
                                                                               '{dtolivros.Valor}');");
            daoBanco.executarComando(sql);

        }
        // Metodo para Excluir Cliente
        public void ExcluirLivro(DTOLIVROS1910 dtoLivro)
        {
            string sql = string.Format($@"DELETE FROM TBL_Livro where idLivro = {dtoLivro.IdLivro};");
            daoBanco.executarComando(sql);
        }
    }
}