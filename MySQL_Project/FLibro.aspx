<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FLibro.aspx.cs" Inherits="MySQL_Project.FLibro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Código Libro: <asp:TextBox runat="server" ID="txtCodLibro" /> </p>
            <p>Titulo: <asp:TextBox runat="server" ID="txtTitulo" /> </p>
            <p>Editorial: <asp:TextBox runat="server" ID="txtEditorial" /> </p>
            <p>Buscar: <asp:TextBox runat="server" ID="txtTexto" /> Criterio: <asp:DropDownList runat="server" ID="ddlCriterio">
                    <asp:ListItem Text="CodLibro" />
                    <asp:ListItem Text="Titulo" />
                    <asp:ListItem Text="Editorial" />
                </asp:DropDownList></p>
            <p>
                <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click"  />
                <asp:Button Text="Eliminar" runat="server" ID="btnEliminarr" OnClick="btnEliminar_Click"  />
                <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" OnClick="btnActualizar_Click" />
                <asp:Button Text="Buscar" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click" />
            </p>
            <asp:GridView runat="server" ID="gvDatos" ></asp:GridView>
        </div>
    </form>
</body>
</html>
