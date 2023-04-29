using BLL.CATALOGOS;
using DAL.CATALOGOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UX.Pantallas.Formularios
{
    public partial class wfrm_Mant_Incapacidades : System.Web.UI.Page
    {

        #region variables publicas 

        cls_Incapacidades_BLL Obj_BLL = new cls_Incapacidades_BLL();
        cls_Incapacidades_DAL Obj_DAL = new cls_Incapacidades_DAL();
        #endregion

            protected void Page_Load(object sender, EventArgs e)
            {
                if (!Page.IsPostBack)
                    txt_buscar.Text = string.Empty;
                CargarDatos();
            dgv_incapacidades.DataSource = null;
            dgv_incapacidades.DataSource = Obj_DAL.DtDatos;
            dgv_incapacidades.DataBind();

                CargarCombos();
            }

            private void CargarDatos()
            {
            Obj_DAL.sCOD_Area = txt_buscar.Text.Trim();

            Obj_BLL.listar_filtrar_Incapacidades(ref Obj_DAL);

            dgv_incapacidades.DataSource = null;
            dgv_incapacidades.DataSource = Obj_DAL.DtDatos;
            dgv_incapacidades.DataBind();
            }

            private void CargarCombos()
            {
            Obj_DAL.sCOD_Area = "";

            Obj_BLL.listar_filtrar_Incapacidades(ref Obj_DAL);

            //ddl_Regiones.DataBind();

            }

            protected void txt_buscar_TextChanged(object sender, EventArgs e)
            {
                CargarDatos();
            }

            protected void btn_buscar_Click(object sender, EventArgs e)
            {
                CargarDatos();
            }

            protected void btn_Guardar_Click(object sender, EventArgs e)
            {
            //Obj_DAL.sNum_Incap = txt_sNum_Incap.Text.Trim();
            //Obj_DAL.sNombre = txt_sNombre.SelectedValue.ToString().Trim();

            //Obj_BLL.insertar_Pedidos(ref Obj_DAL);

            //    txt_cod_farmacia.Text = string.Empty;
            //    txt_medicamentos.Text = string.Empty;

            //    CargarDatos();
            }

            protected void btn_eliminar_Click(object sender, EventArgs e)
            {
            //Obj_DAL.eliminar_Incapacidades(ref Obj_DAL);

            //    txt_buscar.Text = string.Empty;
            //    CargarDatos();
            }
        }
}
