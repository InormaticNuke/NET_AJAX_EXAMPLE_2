<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="WebService.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="txtBuscarId" runat="server" />
            <asp:Button ID="btnBuscar" runat0="server" Text="Buscar" OnClick="btnBuscar_Click" />

            <asp:GridView ID="Gridview1" runat="server" AutoGenerateColumns="false" CssClass="table table-striped">

                <Columns>

                    <asp:BoundField DataField="IdPelicula" HeaderText="ID Pelicula" ItemStyle-CssClass="col-md-4" />
                    <asp:BoundField DataField="NombrePelicula" HeaderText="Nombre Pelicula" ItemStyle-CssClass="col-md-4" />
                    <asp:BoundField DataField="CategoriaPelicula" HeaderText="Categoria Pelicula" ItemStyle-CssClass="col-md-4" />
                    <asp:BoundField DataField="ClaseEntradas.CantidadEntradas" HeaderText="ID Pelicula" ItemStyle-CssClass="col-md-4" />
                    <asp:BoundField DataField="ClaseEntradas.ValorEntradas" HeaderText="Precio Entradas" ItemStyle-CssClass="col-md-4" />

                </Columns>

            </asp:GridView>

        </div>
    </form>
</body>
</html>
