using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.WCF;
using BLL.CATALOGOS;
using DAL.CATALOGOS;
using System.Configuration;

namespace UX.Pantallas.Formularios
{
    public partial class wfrm_Mantenimiento_CCSS : System.Web.UI.Page
    {
        cls_CCSS_BLL Obj_BLL = new cls_CCSS_BLL();
        cls_CCSS_DAL Obj_DAL = new cls_CCSS_DAL();
        #region Variables globales

        cls_Empleados_BLL Obj_Empleados_BLL = new cls_Empleados_BLL();
        cls_Empleados_DAL Obj_Empleados_DAL = new cls_Empleados_DAL();
         
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Cargar los datos en el GridView
                CargarMantenimientoCSS();
            }
        }
        //logica grid 
        public void CargarMantenimientoCSS()
        {
            Obj_DAL.sCed_Jur = txt_Filtro.Text;
            Obj_BLL.listar_filtrar_CCSS(ref Obj_DAL);

            GridCCSS.DataSource = null;
            GridCCSS.DataSource = Obj_DAL.dtDatos;
            GridCCSS.DataBind();

        }


        #region Metodos 


        #endregion


    }
}