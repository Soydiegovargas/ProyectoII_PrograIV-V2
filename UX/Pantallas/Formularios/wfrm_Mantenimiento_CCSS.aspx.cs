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

        #region Variables globales

        cls_Empleados_BLL Obj_Empleados_BLL = new cls_Empleados_BLL();
        cls_Empleados_DAL Obj_Empleados_DAL = new cls_Empleados_DAL();
         
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }



        public void ConsumoWS() {
            string parametro = "valor del parametro";
            using (WCF.BDClient client = new WCF.BDClient())


                Obj_Empleados_DAL.dtDatos = client.ListarFiltrar("T_EMPLEADOS", ConfigurationManager.AppSettings["listar_Empleados"], null);
            //gv_Data.DataSource = null;
          //  gv_Data.DataSource = Obj_Empleados_DAL.dtDatos;
            
            //  Obj_Empleados_DAL.dtDatos = client.ListarFiltrar("T_EMPLEADOS", ConfigurationManager.AppSettings["listar_Empleados"], null); //Se manda a ejecutar sin parámetros para filtrar todo


        }
        #region Metodos 
        private void CargarDatos()
        {

            Obj_Empleados_DAL.sNombre = TextBox1.Text.Trim().ToString();
         //   ConsumoWS();
       

            if (Obj_Empleados_DAL.sMsjError == string.Empty)
            {
             //   gv_Data.DataSource = null;
               // gv_Data.DataSource = Obj_Empleados_DAL.dtDatos;

              

            }
            else
            {
            // MessageBox.Show("Se ha presentado un error al cargar los datos" + Obj_Empleados_DAL.sMsjError, "Error en carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #endregion

        protected void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}