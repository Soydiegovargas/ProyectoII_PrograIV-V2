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
    public partial class wfrm_Mant_Departamentos : System.Web.UI.Page
    {
        cls_Departamentos_DAL Obj_Departamentos_DAL = new cls_Departamentos_DAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Obj_Departamentos_DAL.sEspecialidad = "";
                cargaDatos();
                CargaComboBoxDepartamentos();
            }

        }

        private void cargaDatos()
        {
            cls_Departamentos_DAL Obj_Departamentos_DAL = new cls_Departamentos_DAL();
            cls_Departamentos_BLL Obj_Depa_BLL = new cls_Departamentos_BLL();
            Obj_Departamentos_DAL.sEspecialidad = txt_filtro.Text.Trim();

            Obj_Depa_BLL.listar_Filtrar_Departamentos(ref Obj_Departamentos_DAL);

            dgv_Departamentos.DataSource = null;
            dgv_Departamentos.DataSource = Obj_Departamentos_DAL.dtDatos;
            dgv_Departamentos.DataBind();

        }
        //else
        //{
        //    MessageBox.Show("Se ha presentado un error al cargar los datos \n\n" + Obj_Departamentos_DAL.sMsjError,
        //        "Error en carga de datos",
        //        MessageBoxButtons.OK,
        //        MessageBoxIcon.Error);

        //}
    
        

        protected void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            
            cargaDatos();
        }

        protected void btn_filtrar_Click(object sender, EventArgs e)
        {
            Obj_Departamentos_DAL.sEspecialidad = txt_filtro.Text.Trim();
            cargaDatos();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            //Obj_Depa_DAL.sCodArea;
            
        }

        protected void txt_Eliminar_Click(object sender, EventArgs e)
        {

        }

       

        private void CargaComboBoxDepartamentos()
        {
            //    cls_Departamentos_DAL Obj_Departamentos_DAL = new cls_Departamentos_DAL();
            //    cls_Departamentos_BLL Obj_Depa_BLL = new cls_Departamentos_BLL();
            //    Obj_Departamentos_DAL.sEspecialidad = txt_filtro.Text.Trim();

            //    Obj_Depa_BLL.listar_Filtrar_Departamentos(ref Obj_Departamentos_DAL);
            //    Obj_Departamentos_DAL.dtDatos.Rows.Add("0", "---Seleccione un Departamento---");

            //    ddl_Departamentos.DataSource = null;
            //    ddl_Departamentos.DataTextField = "ESPECIALIDAD";
            //    ddl_Departamentos.DataValueField = "COD_AREA";
            //    ddl_Departamentos.DataSource = Obj_Departamentos_DAL.dtDatos;
            //    ddl_Departamentos.DataBind();

            //    ddl_Departamentos.SelectedValue = "0";


        }

        protected void dgv_Departamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}