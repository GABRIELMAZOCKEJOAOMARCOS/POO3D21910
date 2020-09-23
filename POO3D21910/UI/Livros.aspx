<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Livros.aspx.cs" Inherits="POO3D21910.UI.Livros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Books</title>
    <link href="../Contents/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
            <div class="jumbotron">
           
           <h1 class="h3 mb-3 font-weight-normal">Clientes</h1>

            <br />
            <asp:Label ID="msgerro" runat="server" ForeColor="Red" Text="." Visible="false"></asp:Label>
                <br />
             <asp:Label ID="lblTitulo" runat="server" Text="Titulo "></asp:Label>
             <asp:TextBox ID="txtTitulo" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblValor" runat="server" Text="Valor "></asp:Label>
             <asp:TextBox ID="txtValor" type="number" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblNumPag" runat="server" Text="Numero de Paginas "></asp:Label>
             <asp:TextBox ID="txtNumPag" type="number" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblData" runat="server" Text="Data de Cadastro "></asp:Label>
             <asp:TextBox ID="txtData" type="date" runat="server" CssClass="form-control" ></asp:TextBox>

              <asp:Label ID="lblIDEditora" runat="server" Text="Editora"></asp:Label>
              <asp:DropDownList ID="drpIdEditora" runat="server" CssClass="form-control"></asp:DropDownList>

              <asp:Label ID="lblIdAutor" runat="server" Text="Autor"></asp:Label>
              <asp:DropDownList ID="drpIdAutor" runat="server" CssClass="form-control"></asp:DropDownList>

  
           
            <asp:Button ID="btnInserir" class="btn btn-lg btn-primary" runat="server" Text="Gravar" OnClick="btnInserir_Click"  />
                <br />
                <asp:GridView ID="GridClientes"  CssClass="table table-striped" runat="server" OnRowDeleting="GridClientes_RowDeleting" OnRowCancelingEdit="GridClientes_RowCancelingEdit" OnRowEditing="GridClientes_RowEditing" OnRowUpdating="GridClientes_RowUpdating">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
                        <asp:CommandField ButtonType="Button" ShowEditButton="True" UpdateText="Gravar" />
                    </Columns>
                </asp:GridView>
      
        </div>
    </form>
</body>
</html>
