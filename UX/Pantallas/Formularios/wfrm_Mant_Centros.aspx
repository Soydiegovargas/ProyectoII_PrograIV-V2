﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrm_Mant_Centros.aspx.cs" Inherits="UX.Pantallas.Formularios.wfrm_Mant_Centros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mantenimiento de Centros</title>
	<link href="../../Estilos/main.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            margin-right: 30;
        }
    </style>
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
											<li><a href="wfrm_Mant_Empleados">Mantenimiento Empleados</a></li>
											<li><a href="wfrm_Mant_Especialidades">Mantenimiento Especialidades</a></li>
										</ul>
									</li>
						
								</ul>
							</nav>

					</div>
				</section>
		</div>

	<!-- A partir de aqui empieza la personalizacion de las paginas individuales -->
		
	<div> HOLA mantenimiento de Centros
		<br />
		<asp:Label ID="Centros" runat="server" Text="Label"></asp:Label>
		<asp:TextBox ID="txt_Filtro" runat="server"></asp:TextBox>
        <asp:Button ID="btn_filtrar_centros" runat="server" Text="FILTRAR" />
        <asp:Button ID="btn_eliminar_centros" runat="server" Text="ELIMINAR" />
        <asp:Button ID="btn_consultar_centros" runat="server" Text="CONSULTAR" />
        <br />
        <br />
        <br />
		  <asp:GridView ID="Grid_centros" runat="server" CssClass="auto-style1" Width="954px">
        </asp:GridView>
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
