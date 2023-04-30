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
    public partial class wfrm_Mant_Empleados : System.Web.UI.Page
    {
        #region Globales
        cls_Juntas_BLL BLL_JUNTAS = new cls_Juntas_BLL();
        cls_Juntas_DAL DAL_JUNTAS = new cls_Juntas_DAL();
        cls_Empleados_BLL BLL_EMPLE = new cls_Empleados_BLL();
        cls_Empleados_DAL DAL_EMPLE = new cls_Empleados_DAL();

        #endregion

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                CargaDatos();
                LimpiarTextos();
                cargarComboJunta();
            }



        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {

            
            txt_filtro.Text = DAL_EMPLE.sCod_Junta;
            BLL_EMPLE.listar_filtrar_Empleados(ref DAL_EMPLE);
            gv_Empleados.DataSource = null;
            gv_Empleados.DataSource = DAL_EMPLE.dtDatos;
            gv_Empleados.DataBind();
            CargaDatos();


        }
        private void recarga() {
            
        }

        protected void btn_Insertar_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Guardar_Click(object sender, EventArgs e)

        {


            DAL_EMPLE.sDireccion = txt_Dir.Text.Trim().ToString();
            DAL_EMPLE.sNombre = txt_Nombre.Text.Trim().ToString();
            DAL_EMPLE.iTelefono = Convert.ToInt32(txt_Tel.Text.Trim().ToString());
            DAL_EMPLE.sCed_Empleado = txt_Ced.Text.Trim().ToString();
            DAL_EMPLE.sCod_Junta = ddl_COD_JUNTA.SelectedValue;

            BLL_EMPLE.insertar_Empleados(ref DAL_EMPLE);
            Notificacion(ref DAL_EMPLE);
            LimpiarTextos();

        }
        #endregion

        #region Metodos

        private void CargaDatos()
        {

            DAL_EMPLE.sCod_Junta = txt_filtro.Text;
            BLL_EMPLE.listar_filtrar_Empleados(ref DAL_EMPLE);
            gv_Empleados.DataSource = null;
            gv_Empleados.DataSource = DAL_EMPLE.dtDatos;
            gv_Empleados.DataBind();
            

        }


        private void LimpiarTextos()
        {

            txt_Dir.Text = "";
            txt_Nombre.Text = "";
            txt_Tel.Text = "";
            txt_Ced.Text = "";

        }

        private void Notificacion(ref cls_Empleados_DAL DAL_EMPLEA)
        {



            CargaDatos();
            if (DAL_EMPLE.sMsjError == string.Empty)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mostrarMensajePositivo", "mostrarMensajePositivo();", true);
                Page_Load(this, EventArgs.Empty);
            }
            else
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "mostrarMensajeNegativo", "mostrarMensajeNegativo();", true);
                Page_Load(this, EventArgs.Empty);
            }
        }
        private void Notificacion_II(ref cls_Empleados_DAL DAL_EMPLEA)
        {



            CargaDatos();
            if (DAL_EMPLE.sMsjError == string.Empty)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mostrarMensajeEliminacionPositivo", "mostrarMensajeEliminacionPositivo();", true);
                Page_Load(this, EventArgs.Empty);
            }
            else
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "mostrarMensajeEliminacionNegativo", "mostrarMensajeEliminacionNegativo();", true);
                Page_Load(this, EventArgs.Empty);
            }
        }

        private void cargarComboJunta()
        {

            BLL_JUNTAS.Listar_Filtrar_Juntas(ref DAL_JUNTAS);
            //pone la lista dropdownlist en blanco para luego inyectar data  y agrega fila
            DAL_EMPLE.dtDatos.Rows.Add("0", "--- SELECCIONE UN codigo ---");
            ddl_COD_JUNTA.DataSource = null;
            //nombre exacto de Segunda columna de la tabla, esta son los datos
            ddl_COD_JUNTA.DataTextField = "COD_JUNTA";
            //nombre exacto de primera columna de la tabla/ ni idea pero si no no jala el nombre de arriab ''seleccone un codigo''
            ddl_COD_JUNTA.DataValueField = "COD_JUNTA";
            ddl_COD_JUNTA.DataSource = DAL_JUNTAS.dtDatos;
            ddl_COD_JUNTA.DataBind();

            //ddl_COD_JUNTA.SelectedIndex = 4;
        }



        #endregion



        protected void ddl_COD_JUNTA_SelectedIndexChanged(object sender, EventArgs e)
        {

            //la captura esta en este evento para evitar que se sobreescriba cuando se recarga la pagina
            DAL_EMPLE.sCod_Junta = ddl_COD_JUNTA.SelectedValue;
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {


        }

        protected void gv_Empleados_SelectedIndexChanged(object sender, EventArgs e)
        {



            DAL_EMPLE.ISeleccion = gv_Empleados.SelectedIndex;
            txt_Ced.Text = Convert.ToString(gv_Empleados.Rows[DAL_EMPLE.ISeleccion].Cells[1].Text);
            txt_Nombre.Text = Convert.ToString(gv_Empleados.Rows[DAL_EMPLE.ISeleccion].Cells[2].Text);
            txt_Tel.Text = Convert.ToString(gv_Empleados.Rows[DAL_EMPLE.ISeleccion].Cells[3].Text);
            txt_Dir.Text = Convert.ToString(gv_Empleados.Rows[DAL_EMPLE.ISeleccion].Cells[4].Text);
            btn_editar.Enabled = true;
            btn_Guardar.Enabled = false;
            CargaDatos();
        }

        protected void gv_Empleados_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void gv_Empleados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DAL_EMPLE.ISeleccion = gv_Empleados.SelectedIndex;
            DAL_EMPLE.sCed_Empleado = gv_Empleados.Rows[DAL_EMPLE.ISeleccion].Cells[1].Text;

            BLL_EMPLE.eliminar_Empleados(ref DAL_EMPLE);
            // realizar la acción de eliminación para la fila con el índice rowIndex
            Notificacion_II(ref DAL_EMPLE);
            CargaDatos();
            LimpiarTextos();
            cargarComboJunta();

        }

        protected void gv_Empleados_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            Notificacion_II(ref DAL_EMPLE);
        }

        protected void gv_Empleados_RowEditing(object sender, GridViewEditEventArgs e)
        {
            DAL_EMPLE.ISeleccion = gv_Empleados.SelectedIndex;
            DAL_EMPLE.sCed_Empleado = gv_Empleados.Rows[DAL_EMPLE.ISeleccion].Cells[1].Text;
            DAL_EMPLE.sNombre = gv_Empleados.Rows[DAL_EMPLE.ISeleccion].Cells[2].Text;
            DAL_EMPLE.iTelefono = Convert.ToInt32(gv_Empleados.Rows[DAL_EMPLE.ISeleccion].Cells[3].Text);
            DAL_EMPLE.sDireccion = gv_Empleados.Rows[DAL_EMPLE.ISeleccion].Cells[4].Text;
            DAL_EMPLE.sCod_Junta = gv_Empleados.Rows[DAL_EMPLE.ISeleccion].Cells[5].Text;
            BLL_EMPLE.modificar_Empleados(ref DAL_EMPLE);

        }

        protected void btn_editar_Click(object sender, EventArgs e)
        {

            DAL_EMPLE.sDireccion = txt_Dir.Text.Trim().ToString();
            DAL_EMPLE.sNombre = txt_Nombre.Text.Trim().ToString();
            DAL_EMPLE.iTelefono = Convert.ToInt32(txt_Tel.Text.Trim().ToString());
            DAL_EMPLE.sCed_Empleado = txt_Ced.Text.Trim().ToString();
            DAL_EMPLE.sCod_Junta = ddl_COD_JUNTA.SelectedValue;
            BLL_EMPLE.modificar_Empleados(ref DAL_EMPLE);
            Notificacion(ref DAL_EMPLE);
        }

        protected void bnt_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextos();
        }

        protected void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            DAL_EMPLE.sCod_Junta = txt_filtro.Text;
            CargaDatos();
            
        }
    }
}