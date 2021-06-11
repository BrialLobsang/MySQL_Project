<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FPrestamo.aspx.cs" Inherits="MySQL_Project.FPrestamo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Código Autor: <asp:TextBox runat="server" ID="txtCodAutor" /> </p>
            <p>Codigo Libro: <asp:TextBox runat="server" ID="txtCodLibro" /> </p>
            <p>Fecha del Prestamo: <asp:TextBox runat="server" ID="txtFechaPrestamo" /> </p>
            <p>Buscar: <asp:TextBox runat="server" ID="txtTexto" /> Criterio: <asp:DropDownList runat="server" ID="ddlCriterio">
                    <asp:ListItem Text="CodAutor" />
                    <asp:ListItem Text="CodLibro" />
                    <asp:ListItem Text="FechaPrestamo" />
                </asp:DropDownList></p>
            <p>
                <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click"  />
                <asp:Button Text="Eliminar" runat="server" ID="btnEliminarr" OnClick="btnEliminar_Click"  />
                <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" OnClick="btnActualizar_Click" />
                <asp:Button Text="Buscar" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click" style="height: 26px" />
            </p>
            <asp:GridView runat="server" ID="gvDatos" ></asp:GridView>
        </div>
    </form>
</body>
</html>
