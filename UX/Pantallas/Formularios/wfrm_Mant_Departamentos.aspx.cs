using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.CATALOGOS;
using BLL.CATALOGOS;
using BLL.WCF;


namespace UX.Pantallas.Formularios
{
    public partial class wfrm_Mant_Departamentos : System.Web.UI.Page
    {
            cls_Departamentos_DAL Obj_Depa_DAL = new cls_Departamentos_DAL();
            cls_Departamentos_BLL Obj_Depa_BLL = new cls_Departamentos_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            txt_filtro.Text = string.Empty;
            cargaDatos();
            
        }

        private void cargaDatos()
        {
            Obj_Depa_DAL.sEspecialidad = txt_filtro.Text.Trim();

            Obj_Depa_BLL.listar_Filtrar_Departamentos(ref Obj_Depa_DAL);

            if (Obj_Depa_DAL.sMsjError == string.Empty)
            {
                dgv_Departamentos.DataSource = null;

                dgv_Departamentos.DataSource = Obj_Depa_DAL.dtDatos;
                dgv_Departamentos.DataBind();
            }
            //else
            //{
            //    MessageBox.Show("Se ha presentado un error al cargar los datos \n\n" + Obj_Departamentos_DAL.sMsjError,
            //        "Error en carga de datos",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);

            //}

        }

        protected void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            Obj_Depa_DAL.sEspecialidad = txt_filtro.Text.Trim();
            cargaDatos();
        }

        protected void btn_filtrar_Click(object sender, EventArgs e)
        {
            Obj_Depa_DAL.sEspecialidad = txt_filtro.Text.Trim();
            cargaDatos();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            
            
        }

        protected void txt_Eliminar_Click(object sender, EventArgs e)
        {

        }

        protected void dgv_Departamentos_DataBinding(object sender, EventArgs e)
        {

        }

        private void CargaCBoxDepartamentos()
        {
          
        }
    }
}