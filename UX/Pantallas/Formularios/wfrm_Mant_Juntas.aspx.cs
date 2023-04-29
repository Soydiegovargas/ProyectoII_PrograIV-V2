using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.CATALOGOS;
using BLL.CATALOGOS;

namespace UX.Pantallas.Formularios
{
    public partial class wfrm_Mant_Juntas : System.Web.UI.Page
    {
        #region variables publicas 

        cls_Juntas_DAL obj_juntas_dal = new cls_Juntas_DAL();
        cls_Juntas_BLL obj_juntas_BLL = new cls_Juntas_BLL();



        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                txt_buscar.Text = string.Empty;
            CargarDatos();
            dgv_juntas.DataSource = null;
            dgv_juntas.DataSource = obj_juntas_dal.dtDatos;
            dgv_juntas.DataBind();

            CargarCombos();
        }
        private void CargarDatos()
        {
            obj_juntas_dal.sCod_Junta = txt_buscar.Text.Trim();

            obj_juntas_BLL.Listar_Filtrar_Juntas(ref obj_juntas_dal);

            dgv_juntas.DataSource = null;
            dgv_juntas.DataSource = obj_juntas_dal.dtDatos;
            dgv_juntas.DataBind();
        }
        private void CargarCombos()
        {
            obj_juntas_dal.sCod_Junta = "";

            obj_juntas_BLL.Listar_Filtrar_Juntas(ref obj_juntas_dal);

            obj_juntas_dal.dtDatos.Rows.Add("0", "--- SELECCIONE UN CODIGO ---");

            ddl_COD_JUNTA.DataSource = null;
            ddl_COD_JUNTA.DataTextField = "COD_JUNTA";
            ddl_COD_JUNTA.DataValueField = "COD_JUNTA";
            ddl_COD_JUNTA.DataSource = obj_juntas_dal.dtDatos;
            //ddl_Regiones.DataBind();

            ddl_COD_JUNTA.SelectedValue = "0";
        }

        protected void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            obj_juntas_dal.sCod_Centro = txt_cod_centro.Text.Trim();
            obj_juntas_dal.sNombre = txt_Nombre.Text.Trim();
            obj_juntas_dal.iTelefono = Convert.ToInt32(txt_telefono.Text.Trim());
            obj_juntas_dal.sCod_Junta = ddl_COD_JUNTA.SelectedValue.ToString().Trim();

            obj_juntas_BLL.insertar_Juntas(ref obj_juntas_dal);

            txt_cod_centro.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            txt_telefono.Text = string.Empty;

            CargarDatos();

        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            obj_juntas_dal.sCod_Junta = ddl_COD_JUNTA.Text.Trim();

            obj_juntas_BLL.eliminar_Juntas(ref obj_juntas_dal);

            txt_buscar.Text = string.Empty;
            CargarDatos();
        }
    }
    }