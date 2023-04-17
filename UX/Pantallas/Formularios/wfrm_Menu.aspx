<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="wfrm_Menu.aspx.cs" Inherits="UX.Pantallas.Formularios.wfrm_Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilos/CCSS.css" rel="stylesheet" />
    <title> Menu</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1> Bienvenido a Caja Costarricense de Seguro Social</h1>

    <div class="div_titulo">
        <h2>Elija la opcion de su agrado</h2>
    </div>

    <div class="div_botones">
        <asp:Button ID="btn_CCSS" runat="server" Text="CCSS" class="btn_General" OnClick="btn_CCSS_Click" />
        <asp:Button ID="btn_Centros" runat="server" Text="Centros" class="btn_General" OnClick="btn_Centros_Click" />
        <asp:Button ID="btn_Departamentos" runat="server" Text="Departamentos" class="btn_General" OnClick="btn_Departamentos_Click" />
        <asp:Button ID="btn_Farmacias" runat="server" Text="Farmacias" class="btn_General" OnClick="btn_Farmacias_Click" />
        <asp:Button ID="btn_Incapacidades" runat="server" Text="Incapacidades" class="btn_General" OnClick="btn_Incapacidades_Click" />
        <asp:Button ID="btn_Inventarios" runat="server" Text="Inventarios" class="btn_General" OnClick="btn_Inventarios_Click" />
        <asp:Button ID="btn_Juntas" runat="server" Text="Juntas" class="btn_General" OnClick="btn_Juntas_Click" />
        <asp:Button ID="btn_Pedidos" runat="server" Text="Pedidos" class="btn_General" OnClick="btn_Pedidos_Click" />
        <asp:Button ID="btn_Asegurados" runat="server" Text="Asegurados" class="btn_General" OnClick="btn_Asegurados_Click" />
        <asp:Button ID="btn_Contratas" runat="server" Text="Contratas" class="btn_General" OnClick="btn_Contratas_Click" />
        <asp:Button ID="btn_Empleados" runat="server" Text="Empleados" class="btn_General" OnClick="btn_Empleados_Click" />
        <asp:Button ID="btn_Especialidades" runat="server" Text="Especialidades" class="btn_General" OnClick="btn_Especialidades_Click" />
        
        <br />
    </div>
</asp:Content>
