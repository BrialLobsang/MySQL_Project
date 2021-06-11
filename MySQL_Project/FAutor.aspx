<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FAutor.aspx.cs" Inherits="MySQL_Project.FAutor" %>

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
            <p>Nombres: <asp:TextBox runat="server" ID="txtNombres" /> </p>
            <p>Apellidos: <asp:TextBox runat="server" ID="txtApellidos" /> </p>
            <p>Nacionalidad: <asp:TextBox runat="server" ID="txtNacionalidad" /> </p>
            
            <p>Buscar: <asp:TextBox runat="server" ID="txtTexto" /> Criterio: <asp:DropDownList runat="server" ID="ddlCriterio">
                    <asp:ListItem Text="CodAutor" />
                    <asp:ListItem Text="Nombres" />
                    <asp:ListItem Text="Apellidos" />
                    <asp:ListItem Text="Nacionalidad" />
                </asp:DropDownList></p>
            <p>
                <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click"  />
                <asp:Button Text="Eliminar" runat="server" ID="btnEliminarr" OnClick="btnEliminar_Click"  />
                <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" OnClick="btnActualizar_Click" style="height: 26px" />
                <asp:Button Text="Buscar" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click" />
            </p>
            <asp:GridView runat="server" ID="gvDatos" ></asp:GridView>
        </div>
    </form>
</body>
</html>
