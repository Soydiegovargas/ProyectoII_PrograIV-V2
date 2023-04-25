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
        cls_Departamentos_BLL Obj_BLL = new cls_Departamentos_BLL();
        cls_Departamentos_DAL Obj_DAL = new cls_Departamentos_DAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Cargar los datos en el GridView
                CargarDepartamentos();
            }
        }

        public void CargarDepartamentos()
        {
                Obj_DAL.sEspecialidad = txt_Filtro.Text;
                Obj_BLL.listar_Filtrar_Departamentos(ref Obj_DAL);

                dgv_Departamentos.DataSource = null;
                dgv_Departamentos.DataSource = Obj_DAL.dtDatos;
                dgv_Departamentos.DataBind();
            
        }

        protected void txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            Obj_DAL.sEspecialidad = txt_Filtro.Text;
            CargarDepartamentos();
            
        }

        
    }
}