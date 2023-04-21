<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="wfrm_Mant_Departamentos.aspx.cs" Inherits="UX.Pantallas.Formularios.wfrm_Mant_Departamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="jumbotron">
        <h1>CONSUMO WCF PROYECTO CCSS</h1>
        <p class="lead">Esta funcionalidad consume el servicio WCF del proyecto para la tabla de regiones.</p>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Buscar: "></asp:Label> 
            &nbsp;
            &nbsp;
            <asp:TextBox ID="txt_filtro" runat="server" Height="31px" Width="375px" OnTextChanged="txt_filtro_TextChanged"></asp:TextBox>
            &nbsp;
            &nbsp;
            <asp:Button ID="btn_filtrar" runat="server" Text="Aplicar Filtro" OnClick="btn_filtrar_Click" />
            &nbsp;
            &nbsp;
            <input id="btn_editar" type="button" value="Habilitar Edición" OnClick="toggle()"/>
        </div>
         
         <br />
        <br />
        <div>
            <div id="div_Editar" class="jumbotron" style="display:block">
                <p class="lead">Edición de Datos de Regiones.</p>
                <div style="height: 401px">
                    <asp:Label ID="Label2" runat="server" Text="Id Departamento: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_IdTerritorio" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    &nbsp;
                    &nbsp;
                    <asp:Label ID="Label3" runat="server" Text="Nombre Departamento: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_DescDepartamento" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Id Departamento: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    &nbsp;
                    &nbsp;<asp:DropDownList ID="ddl_Departamentos" runat="server" Height="53px" Width="386px">
                    </asp:DropDownList>
&nbsp;<div style="text-align:center">
                         <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" OnClick="btn_Guardar_Click"  />
                         &nbsp;
                         &nbsp;
                         <asp:Button ID="txt_Eliminar" runat="server" Text="Eliminar" OnClick="txt_Eliminar_Click"/>
                    </div>
                    &nbsp;
                    &nbsp;
            <p>
               <asp:GridView ID="dgv_Departamentos" runat="server"></asp:GridView>
            </p>
                </div>
                <br />
        
            </div>

        </div>
    </div>
    
    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

    <script>

        function toggle() {

            var ele = document.getElementById("div_Editar");

            if (ele.style.display == "block") {

                ele.style.display = "none";
            }
            else {

                ele.style.display = "block";
            }
        }

    </script>

</asp:Content>
