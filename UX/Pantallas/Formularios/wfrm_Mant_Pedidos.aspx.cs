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
    public partial class wfrm_Mant_Pedidos : System.Web.UI.Page
    {

        #region variables publicas 

        cls_Pedidos_DAL obj_pedidos_dal = new cls_Pedidos_DAL();
        cls_Pedidos_BLL obj_Pedidos_BLL = new cls_Pedidos_BLL();



        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            txt_buscar.Text = string.Empty;
            CargarDatos();
            CargarCombos();
        }

        private void CargarDatos()
        {
            obj_pedidos_dal.scodpedido = txt_buscar.Text.Trim();

            obj_Pedidos_BLL.listar_filtrar_Pedidos(ref obj_pedidos_dal);

            dgv_pedidos.DataSource = null;
            dgv_pedidos.DataSource = obj_pedidos_dal.DtDatos;
            dgv_pedidos.DataBind();
        }

        private void CargarCombos()
        {
            obj_pedidos_dal.scodpedido = "";

            obj_Pedidos_BLL.listar_filtrar_Pedidos(ref obj_pedidos_dal);

            obj_pedidos_dal.DtDatos.Rows.Add("0", "--- SELECCIONE UN CODIGO ---");

            ddl_cod_pedido.DataSource = null;
            ddl_cod_pedido.DataTextField = "NOMBRE REGIÓN";
            ddl_cod_pedido.DataValueField = "CÓDIGO REGIÓN";
            ddl_cod_pedido.DataSource = obj_pedidos_dal.DtDatos;
            //ddl_Regiones.DataBind();

            ddl_cod_pedido.SelectedValue = "0";
        }

        protected void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}