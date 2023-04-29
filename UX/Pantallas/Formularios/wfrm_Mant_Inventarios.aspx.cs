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
    public partial class wfrm_Mant_Inventarios : System.Web.UI.Page
    {
        #region variables publicas 

        cls_Inventarios_BLL Obj_BLL = new cls_Inventarios_BLL();
        cls_Inventarios_DAL Obj_DAL = new cls_Inventarios_DAL();
        private DataTable dtTablaInventarios;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            txt_buscar.Text = string.Empty;
            CargarDatos();
            dgv_Inventarios.DataSource = null;
            dgv_Inventarios.DataSource = Obj_DAL.DtDatos;
            dgv_Inventarios.DataBind();

            CargarCombos();
        }

        private void CargarDatos()
        {
            Obj_DAL.sCod_Medicina = txt_buscar.Text.Trim();

            //Obj_BLL.listar_filtrar_Inventarios(ref Obj_DAL);

            dgv_Inventarios.DataSource = null;
            dgv_Inventarios.DataSource = Obj_DAL.DtDatos;
            dgv_Inventarios.DataBind();
        }

        private void CargarCombos()
        {
            Obj_DAL.sCod_Medicina = "";

            Obj_BLL.listar_Filtrar_Inventarios(ref Obj_DAL);

            //Obj_DAL.DtDatos.Rows.Add("0", "--- SELECCIONE UN CODIGO ---");

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
            //Obj_DAL.sCod_Medicina = txt_sCod_Medicina.Text.Trim();
            //Obj_DAL.iCantidad = txt_iCantidad.Text.Trim();

            Obj_BLL.insertar_Inventarios(ref Obj_DAL);

            //txt_sCod_Medicina.Text = string.Empty;
            //txt_iCantidad.Text = string.Empty;

            CargarDatos();
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            Obj_BLL.eliminar_Inventarios(ref Obj_DAL);

            txt_buscar.Text = string.Empty;
            CargarDatos();
        }

    }
}
