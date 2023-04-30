<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrm_Mant_Departamentos.aspx.cs" Inherits="UX.Pantallas.Formularios.wfrm_Mant_Departamentos" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <title>Mantenimiento de Departamentos</title>
      <link href="../../Estilos/main.css" rel="stylesheet" />
   </head>
   <body class="homepage is-preload">
      <form id="form1" runat="server">
         <div id="page-wrapper">
            <!-- Header -->
            <section id="header">
               <div class="container">
                  <!-- Logo -->
                  <h1 id="logo"><a href="wfrm_Inicio.aspx">Caja Costarricense del Seguro Social</a></h1>
                  <!-- Nav -->
                  <nav id="nav">
                     <ul>
                        <li><a class="icon solid fa-home" href="wfrm_Inicio.aspx"><span>Inicio</span></a></li>
                        <li>
                           <a href="#" class="icon fa-chart-bar"><span>Esquema Administrativo</span></a>
                           <ul>
                              <li><a href="wfrm_Mantenimiento_CCSS.aspx">Mantenimiento entidad</a></li>
                              <li><a href="wfrm_Mant_Centros.aspx">Mantenimiento Centros</a></li>
                              <li><a href="wfrm_Mant_Departamentos.aspx">Mantenimiento Departamentos</a></li>
                              <li><a href="wfrm_Mant_Farmacias.aspx">Mantenimiento Farmacias</a></li>
                              <li><a href="wfrm_Mant_Incapacidades.aspx">Mantenimiento Incapacidades</a></li>
                              <li><a href="wfrm_Mant_Inventarios.aspx">Mantenimiento Inventarios</a></li>
                              <li><a href="wfrm_Mant_Juntas.aspx">Mantenimiento Juntas</a></li>
                              <li><a href="wfrm_Mant_Pedidos.aspx">Mantenimiento Pedidos</a></li>
                              <li>
                              </li>
                           </ul>
                        </li>
                        <li>
                           <a href="#" class="icon fa-chart-bar"><span>Esquema Medico</span></a>
                           <ul>
                              <li><a href="wfrm_Mant_Asegurados.aspx">Mantenimiento Asegurados</a></li>
                              <li><a href="wfrm_Mant_Contratas.aspx">Mantenimiento Contratas</a></li>
                              <li><a href="wfrm_Mant_Empleados.aspx">Mantenimiento Empleados</a></li>
                              <li><a href="wfrm_Mant_Especialidades.aspx">Mantenimiento Especialidades</a></li>
                           </ul>
                        </li>
                     </ul>
                  </nav>
               </div>
            </section>
            <!-- Main content -->
            <main id="main">
               <div class="container">
                  <h2>Mantenimiento de Departamentos</h2>
                  <!-- Buttons -->
                  <div class="button-group">
                     <input id="btn_Acciones" type="button" value="Acciones"  onclick="toggle()" />
                  </div>
                  <div id="cont_Edicion"  style="display:none" >
                     <button id="btnAgregar">Agregar</button>
                     <button id="btn_Editar" value="Editar">Editar</button>
                     <button id="btnEliminar">Eliminar</button>
                     <br /> 
                     <asp:Label ID="lbl_CodArea" runat="server" Text="Código de área"></asp:Label>
                     <asp:TextBox ID="Cod_Area" runat="server"></asp:TextBox>
                     <asp:Label ID="lbl_espec" runat="server" Text="Especialidad"></asp:Label>
                     <asp:TextBox ID="Especialidad" runat="server"></asp:TextBox>
                     <asp:Label ID="lbl_Tel" runat="server" Text="Teléfono"></asp:Label>
                     <asp:TextBox ID="Telefono" runat="server"></asp:TextBox>
                     <asp:Label ID="lbl_CodCentro" runat="server" Text="Código de Centro"></asp:Label>
                     <asp:TextBox ID="CodigoCentro" runat="server"></asp:TextBox>
                  </div>
                  <div>
                     <asp:Label ID="lbl_Filtro" runat="server" Text="Filtro"></asp:Label>
                     <asp:TextBox ID="txt_Filtro" runat="server"  OnTextChanged="txt_Filtro_TextChanged"></asp:TextBox>
                  </div>
                  <!-- Grid -->
                  <div id="gridDepartamentos">
                     <asp:GridView ID="dgv_Departamentos" runat="server" OnSelectedIndexChanged="dgv_Departamentos_SelectedIndexChanged" AutoPostBack="false">
                        <Columns>
                           <asp:TemplateField>
                              <ItemTemplate>
                                 <asp:Button runat="server" Text="Seleccionar fila" CommandName="SelectRow" CommandArgument='<%# Container.DataItemIndex %>' AutoPostBack="false" />
                              </ItemTemplate>
                           </asp:TemplateField>
                        </Columns>
                     </asp:GridView>
                  </div>
               </div>
            </main>
            <!-- Footer -->
            <footer id="footer">
               <div class="container">
                  <p>&copy; 2023 Caja Costarricense del Seguro Social</p>
               </div>
            </footer>
         </div>
         <!-- A partir de aqui empieza la personalizacion de las paginas individuales -->
         <!--    Salto linea codigo-->
         <div> HOLA mantenimiento de Departamentos</div>
         <!-- Scripts  JS, no afectan grfico-->
         <script src="../../Javascript/jquery.min.js"></script>
         <script src="../../Javascript/jquery.dropotron.min.js"></script>
         <script src="../../Javascript/browser.min.js"></script>
         <script src="../../Javascript/breakpoints.min.js"></script>
         <script src="../../Javascript/util.js"></script>
         <script src="../../Javascript/main.js"></script>
      </form>
   </body>
   <script>
       function toggle() {

           var ele = document.getElementsByID("cont_Edicion");

           if (ele.style.display == "block") {

               ele.style.display = "none";
           }
           else {

               ele.style.display = "block";
           }
       }

   </script>
</html>