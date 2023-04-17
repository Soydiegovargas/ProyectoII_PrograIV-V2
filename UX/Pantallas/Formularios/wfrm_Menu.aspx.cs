using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UX.Pantallas.Formularios
{
    public partial class wfrm_Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_CCSS_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Pantallas/Formularios/wfrm_Mant_CCSS.aspx");
        }

        protected void btn_Centros_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Pantallas/Formularios/wfrm_Mant_Centros.aspx");
        }

        protected void btn_Departamentos_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Pantallas/Formularios/wfrm_Mant_Departamentos.aspx");
        }

        protected void btn_Farmacias_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Pantallas/Formularios/wfrm_Mant_Farmacias.aspx");
        }

        protected void btn_Incapacidades_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Pantallas/Formularios/wfrm_Mant_Incapacidades.aspx");
        }

        protected void btn_Inventarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Pantallas/Formularios/wfrm_Mant_Inventarios.aspx");
        }

        protected void btn_Juntas_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Pantallas/Formularios/wfrm_Mant_Juntas.aspx");
        }

        protected void btn_Asegurados_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Pantallas/Formularios/wfrm_Mant_Asegurados.aspx");
        }

        protected void btn_Pedidos_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Pantallas/Formularios/wfrm_Mant_Pedidos.aspx");
        }

        protected void btn_Contratas_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Pantallas/Formularios/wfrm_Mant_Contratas.aspx");
        }

        protected void btn_Empleados_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Pantallas/Formularios/wfrm_Mant_Empleados.aspx");
        }

        protected void btn_Especialidades_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Pantallas/Formularios/wfrm_Mant_Especialidades.aspx");
        }
    }
}