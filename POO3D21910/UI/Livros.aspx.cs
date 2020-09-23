using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using POO3D21910.BLL;
using POO3D21910.DTO;

namespace POO3D21910.UI
{
    public partial class Livros : System.Web.UI.Page
    {

        // Instanciar Blls e DTOs
        BLLPOO1910cs bllLivros = new BLLPOO1910cs();
        DTOLIVROS1910 dtoLivros = new DTOLIVROS1910();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                this.PreencheIdAutor();
                this.PreencheIdEditora();
                this.ExibirGridLivros();
            }
           
        }


        protected void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                // inserir os dados da UI no DTO
                dtoLivros.IdAutor = int.Parse(drpIdAutor.SelectedValue);
                dtoLivros.IdEditora = int.Parse(drpIdEditora.SelectedValue);
                dtoLivros.Titulo = txtTitulo.Text;                
                dtoLivros.Valor = double.Parse(txtValor.Text);
                dtoLivros.DataCadastro = txtData.Text;
                dtoLivros.NumPags = int.Parse(txtNumPag.Text);
                

                // Inserir na tabela de clientes
                bllLivros.InserirLivros(dtoLivros);
                msgerro.Visible = true;
                msgerro.Text = "Livro Inserido com Sucesso";
                this.LimparCampos();
                this.ExibirGridLivros();


            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }

        // Metodo para Exibir Dados no Grid
        public void ExibirGridLivros()
        {
            GridClientes.DataSource = bllLivros.ListarLivros();
            GridClientes.DataBind();
        }

        //Deleta Dodos da tabela pelo Grid
        protected void GridClientes_RowDeleting(object sender, GridViewDeleteEventArgs Registro)
        {
            try
            {
                dtoLivros.IdLivro = Convert.ToInt32(Registro.Values[0]);
                bllLivros.ExcluirLivro(dtoLivros);
                this.ExibirGridLivros();
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }


        // Metodo para Edição de Dados no Grid
        protected void GridClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridClientes.EditIndex = e.NewEditIndex;
            this.ExibirGridLivros();
        }
        // Metodo Utilizado para Salvar a Edição dos dados do grid
        protected void GridClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                dtoLivros.IdLivro = int.Parse(e.NewValues[1].ToString());
                dtoLivros.IdAutor = int.Parse(e.NewValues[2].ToString());
                dtoLivros.IdEditora = int.Parse(e.NewValues[3].ToString());
                dtoLivros.Titulo = e.NewValues[4].ToString();
                dtoLivros.DataCadastro = e.NewValues[5].ToString();
                dtoLivros.NumPags = int.Parse(e.NewValues[6].ToString());
                dtoLivros.Valor = double.Parse(e.NewValues[7].ToString());
                bllLivros.AlterarLivro(dtoLivros);
                GridClientes.EditIndex = -1;
                this.ExibirGridLivros();
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
        // Metodo para Cancelar Edição no Grid
        protected void GridClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridClientes.EditIndex = -1;
            this.ExibirGridLivros();
        }



        //Preencher
        public void PreencheIdAutor()
        {
            drpIdAutor.DataSource = bllLivros.ListarIdAutor();
            drpIdAutor.DataTextField = "nome";
            drpIdAutor.DataValueField = "idAutor";
            drpIdAutor.DataBind();
        }

        public void PreencheIdEditora()
        {
            drpIdEditora.DataSource = bllLivros.ListarIdEditora();
            drpIdEditora.DataTextField = "nome";
            drpIdEditora.DataValueField = "idEditora";
            drpIdEditora.DataBind();
        }


        //Limpar
        public void LimparCampos()
        {
            txtData.Text = "";
            txtNumPag.Text = "";
            txtTitulo.Text = "";
            txtValor.Text = "";
        }
    }
}