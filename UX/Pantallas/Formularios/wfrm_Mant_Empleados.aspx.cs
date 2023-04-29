using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.CATALOGOS;
using BLL.WCF;
using DAL.CATALOGOS;


namespace UX.Pantallas.Formularios
{
    public partial class wfrm_Mant_Empleados : System.Web.UI.Page
    {
        #region Globales

        cls_Empleados_BLL BLL_EMPLE = new cls_Empleados_BLL();
        cls_Empleados_DAL DAL_EMPLE = new cls_Empleados_DAL();

        #endregion

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            CargaDatos();
            gv_Empleados.DataSource = null;
            gv_Empleados.DataSource = DAL_EMPLE.dtDatos;
            gv_Empleados.DataBind();

        }
        #endregion

        #region Metodos

        private void CargaDatos() {
            DAL_EMPLE.sCed_Empleado= txt_filtro.Text.Trim().ToString();
            BLL_EMPLE.listar_filtrar_Empleados(ref DAL_EMPLE);
            
        
        }

        #endregion

    }
}