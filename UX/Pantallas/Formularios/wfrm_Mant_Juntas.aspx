<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrm_Mant_Juntas.aspx.cs" Inherits="UX.Pantallas.Formularios.wfrm_Mant_Juntas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mantenimiento de Juntas</title>
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
		</div>

	<!-- A partir de aqui empieza la personalizacion de las paginas individuales -->
		
	<div> HOLA mantenimiento de JUNTAS<asp:TextBox ID="txt_buscar" runat="server" Width="734px" Height="17px" OnTextChanged="txt_buscar_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="btn_buscar" runat="server" Text="Buscar" OnClick="btn_buscar_Click" />
        <br />
        <br />
        <br />
        <asp:GridView ID="dgv_juntas" runat="server">
        </asp:GridView>
        <br />
        Editar datos:<br />
        COD_JUNTA:<asp:DropDownList ID="ddl_COD_JUNTA" runat="server" Width="221px">
        </asp:DropDownList>
        <br />
        COD_CENTRO:<asp:TextBox ID="txt_cod_centro" runat="server" Height="37px" Width="184px"></asp:TextBox>
        <br />
        NOMBRE:<asp:TextBox ID="txt_Nombre" runat="server"></asp:TextBox>
        <br />
        TELEFONO:<asp:TextBox ID="txt_telefono" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_guardar" runat="server" Text="Guardar" OnClick="btn_guardar_Click" />
        <br />
        <br />
        <asp:Button ID="btn_eliminar" runat="server" OnClick="btn_eliminar_Click" Text="Eliminar" />
        <br />
        <br />
        <br />
        <br />
            </div>
		<!-- Scripts -->
			<script src="../../Javascript/jquery.min.js"></script>
			<script src="../../Javascript/jquery.dropotron.min.js"></script>
			<script src="../../Javascript/browser.min.js"></script>
			<script src="../../Javascript/breakpoints.min.js"></script>
			<script src="../../Javascript/util.js"></script>
			<script src="../../Javascript/main.js"></script>
	
			</form>
			</body>
</html>
