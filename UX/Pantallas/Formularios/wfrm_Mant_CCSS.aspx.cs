using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace UX.Pantallas.Formularios
{
    public partial class wfrm_Mant_CCSS : System.Web.UI.Page
    {
        //LOAD CON METODO DE BASE DE DATOS QUEMADA
        protected void Page_Load(object sender, EventArgs e)
        {
          
           
        }
        //LLAMAR  BASE DE DATOS QUEMADA
      /*
        private void LlenarGV()
        {
            DataTable GV = new DataTable();
            GV.Columns.AddRange(new DataColumn[] {
                new DataColumn("COD_AREA",typeof(string)),
                new DataColumn("NUM_INCAP",typeof(string)),
                new DataColumn("NOMBRE",typeof(string)),
                new DataColumn("DIAS",typeof(string)),
                new DataColumn("MOTIVO",typeof(string))
                
            });

            SqlCommand cmd = new SqlCommand("BD_CCSS.SCH_ADMIN.sp_Listar_INCAPACIDADES", PRUEBAS_DATAGRID.Open());

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    GV.Rows.Add(
                        dr["COD_AREA"].ToString(),
                        dr["NUM_INCAP"].ToString(),
                        dr["NOMBRE"].ToString(),
                        dr["DIAS"].ToString(),
                        dr["MOTIVO"].ToString()

                        ) ;
                }
            }

            PRUEBAS_DATAGRID.Close();

            gv_Compania.DataSource = GV;
            gv_Compania.DataBind();
        }
       */
        protected void gv_Compania_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
