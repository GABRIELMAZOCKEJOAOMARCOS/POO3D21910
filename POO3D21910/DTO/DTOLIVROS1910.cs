using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3D21910.DTO
{
    public class DTOLIVROS1910
    {
        private int idLivro, idAutor, idEditora, numPags;
        private double valor;
        private string titulo, dataCadastro;
        

        public int IdLivro { get => idLivro; set => idLivro = value; }

        public string Titulo
        {
            set
            {
                if (value != string.Empty)
                {
                    this.titulo = value;
                }
                else
                {
                    throw new Exception("O campo Titulo é obrigatório");
                }

            }
            get { return this.titulo; }

        }

        public int IdAutor
        {
            set
            {
                if(value != 0)
                {
                    this.idAutor = value;
                }
                else
                {
                    throw new Exception("O campo Autor é obrigatório");
                }
            }
            get { return this.idAutor; }
        }
        public int IdEditora
        {
            set
            {
                if (value != 0)
                {
                    this.idEditora = value;
                }
                else
                {
                    throw new Exception("O campo Editora é obrigatório");
                }
            }
            get { return this.idEditora; }
        }
        public double Valor
        {
            set
            {
                if (value != 0)
                {
                    this.valor = value;
                }
                else
                {
                    throw new Exception("O campo Valor é obrigatório");
                }
            }
            get { return this.valor; }
        }
        public int NumPags
        {
            set
            {
                if (value != 0)
                {
                    this.numPags = value;
                }
                else
                {
                    throw new Exception("O campo Autor é obrigatório");
                }
            }
            get { return this.numPags; }
        }
        public string DataCadastro
        {
            set
            {
                if (value != String.Empty)
                {
                    this.dataCadastro = value;
                }
                else
                {
                    throw new Exception("O campo Data é obrigatório");
                }
            }
            get { return this.dataCadastro; }
        }

    }
}