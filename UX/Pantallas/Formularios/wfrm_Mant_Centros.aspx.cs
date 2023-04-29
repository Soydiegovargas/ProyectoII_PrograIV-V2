using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.CATALOGOS;
using DAL.CATALOGOS;


namespace UX.Pantallas.Formularios
{
    public partial class wfrm_Mant_Centros : System.Web.UI.Page
    {
        cls_Centros_BLL Obj_BLL = new cls_Centros_BLL();
        cls_Centros_DAL Obj_DAL = new cls_Centros_DAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Cargar los datos en el GridView
                CargarCentros();
            }

        }
        //logica grid 
        public void CargarCentros()
        {
            Obj_DAL.sCodCentro = txt_Filtro.Text;
            Obj_BLL.listar_filtrar_Centros(ref Obj_DAL);

            Grid_centros.DataSource = null;
            Grid_centros.DataSource = Obj_DAL.dtDatos;
            Grid_centros.DataBind();

        }
    }
}