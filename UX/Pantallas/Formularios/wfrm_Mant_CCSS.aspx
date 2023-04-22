<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="wfrm_Mant_CCSS.aspx.cs" Inherits="UX.Pantallas.Formularios.wfrm_Mant_CCSS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <title> Mantenimiento de Entidad</title>
    <script src="../../Javascript/js_Agregar_CCSS.js"></script>
    <link href="../../Estilos/Mant_CCSS.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div class="div_Titulo">

         

          Mantenimiento de Datos en CCSS
    </div>
    
             
    <div class="div_main">
       
    </div>
    <div class="div_Botones"> 
         <asp:Button ID="btn_Refrescar" runat="server" Text="" CssClass="btn_Refrescar" />
        <asp:Label ID="lbl_Refrescar" runat="server" Text="Refrescar" ></asp:Label>
        <asp:Image ID="Division" runat="server" ImageUrl="~/Imagenes/pipe.png" CssClass="img_Division"/>
    </div>
    <div class="div_Botones">
        <asp:Button ID="btn_Nuevo" runat="server" Text="" CssClass="btn_Nuevo"/>
        <asp:Label ID="lbl_Nuevo" runat="server" Text="Nuevo Registro" ></asp:Label>
        <asp:Image ID="Division_I" runat="server" ImageUrl="~/Imagenes/pipe.png" CssClass="img_Division"/>
    </div>
    <div class="div_Botones">
         <asp:Button ID="btn_Modificar" runat="server" Text="" CssClass="btn_Modificar"/>
        <asp:Label ID="lbl_Modificar" runat="server" Text="Modificar"></asp:Label>
        <asp:Image ID="Division_II" runat="server" ImageUrl="~/Imagenes/pipe.png" CssClass="img_Division"/>
    </div>
    <div class="div_Botones">
         <asp:Button ID="btn_Filtrar" runat="server" Text="" CssClass="btn_Filtrar" />
        <asp:Label ID="lbl_Filtrar" runat="server" Text="Filtrar"></asp:Label>
        <asp:TextBox ID="txt_Busqueda" runat="server" class="txt_Busqueda"></asp:TextBox>
        <asp:Image ID="Division_III" runat="server" ImageUrl="~/Imagenes/pipe.png" CssClass="img_Division"/>
    </div>
    <div class="div_Botones">
        <asp:Button ID="btn_Eliminar" runat="server" Text="" CssClass="btn_Eliminar" />
        <asp:Label ID="lbl_Eliminar" runat="server" Text="Eliminar"></asp:Label>
    </div>

 

    <div class="div_Grid">

         <asp:ScriptManager id="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel id="UpdatePanel1" UpdateMode="Conditional" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="gv_Compania" CSSClass="gv_Compania" runat="server"  AutoGenerateColumns="True" OnSelectedIndexChanged="gv_Compania_SelectedIndexChanged" HorizontalAlign="Center" AutoGenerateSelectButton="True"  Font-Size="X-Large"  >
                        
                        <EditRowStyle BorderStyle="Dashed" />
                        <HeaderStyle BorderStyle="Solid" BorderWidth="4px" />
                        
                        <SelectedRowStyle BackColor="#66CCFF" BorderStyle="Ridge" BorderWidth="2px" HorizontalAlign="Center" VerticalAlign="Middle" />
                        
                    </asp:GridView>

                 



                </ContentTemplate>
            </asp:UpdatePanel>

    </div>

 
    <asp:Button ID="Button1" runat="server" Text="Button" />

 
</asp:Content>

