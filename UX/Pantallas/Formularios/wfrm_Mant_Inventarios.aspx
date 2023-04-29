<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrm_Mant_Inventarios.aspx.cs" Inherits="UX.Pantallas.Formularios.wfrm_Mant_Inventarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mantenimiento de Inventarios</title>
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
		
	<div> HOLA mantenimiento de Inventarios</div>
		<asp:TextBox ID="txt_buscar" runat="server" Width="743px" OnTextChanged="txt_buscar_TextChanged"></asp:TextBox>
        
		<br />
	<h1>Incapacidades</h1>
	<form method="post" action="procesar_incapacidad.php">
		<label for="cod_area">Código de área:</label>
		<input type="text" id="cod_area" name="cod_area"><br>

		<label for="num_incap">Número de incapacidad:</label>
		<input type="text" id="num_incap" name="num_incap"><br>

		<label for="nombre">Nombre:</label>
		<input type="text" id="nombre" name="nombre"><br>

		<label for="motivo">Motivo:</label>
		<input type="text" id="motivo" name="motivo"><br>

		<label for="dias">Días:</label>
		<input type="text" id="dias" name="dias"><br>

		<input type="submit" value="Enviar">
		    <asp:Button ID="btn_buscar" runat="server" Text="Buscar" OnClick="btn_buscar_Click" />
    <asp:Button ID="btn_limpiar" runat="server" Text="Limpiar" OnClick="btn_limpiar_Click" />
	        <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" OnClick="btn_Guardar_Click" />
	        <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" OnClick="btn_eliminar_Click" />

		        <asp:GridView ID="dgv_Inventarios" runat="server">
        </asp:GridView>
	</form>
        <br />
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
