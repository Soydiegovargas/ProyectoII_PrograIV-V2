using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;

namespace BLL.CATALOGOS
{
    public class cls_Inventarios_BLL
    {

        #region Globales
        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();


        #endregion


        public void Listar_Inventarios(ref cls_Inventarios_DAL Obj_Inventarios_DAL)
        {
            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_Inventarios"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
            Obj_BD_DAL.sNomTabla = "Inventarios";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);


            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Inventarios_DAL.sMsjError = string.Empty;
                Obj_Inventarios_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_Inventarios_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Inventarios_DAL.dtDatos = null;
            }


        }
        public void Filtrar_Inventarios(ref cls_Inventarios_DAL Obj_Inventarios_DAL)
        {

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["filtrar_Inventarios"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
            Obj_BD_DAL.sNomTabla = "Inventarios";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Filtro", "4", Obj_Inventarios_DAL.sCod_Medicina);
            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Inventarios_DAL.sMsjError = string.Empty;
                Obj_Inventarios_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_Inventarios_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Inventarios_DAL.dtDatos = null;
            }

        }
        public void insertar_Inventarios(ref cls_Inventarios_DAL Obj_Inventarios_DAL)
        {

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["insertar_Inventarios"].ToString();

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable

            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_MEDICINA", "4", Obj_Inventarios_DAL.sCod_Medicina);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@FECHA_VENC", "8", Obj_Inventarios_DAL.date);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@CANTIDAD", "1", Obj_Inventarios_DAL.iCantidad);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_FARMACIA", "7", Obj_Inventarios_DAL.sCod_Farmacia);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_Inventarios_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        }
        public void modificar_Inventarios(ref cls_Inventarios_DAL Obj_Inventarios_DAL)
        {


            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["modificar_Inventarios"].ToString();

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable

            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_MEDICINA", "4", Obj_Inventarios_DAL.sCod_Medicina);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@FECHA_VENC", "8", Obj_Inventarios_DAL.date);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@CANTIDAD", "1", Obj_Inventarios_DAL.iCantidad);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_FARMACIA", "7", Obj_Inventarios_DAL.sCod_Farmacia);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_Inventarios_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        }
        public void eliminar_Inventarios(ref cls_Inventarios_DAL Obj_Inventarios_DAL)
        {



            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["eliminar_Inventarios"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable porque se tiene que recibir un parámetro 
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_MEDICINA", "4", Obj_Inventarios_DAL.sCod_Medicina); //Mando los parámetros del Store Procedure

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_Inventarios_DAL.sMsjError = Obj_BD_DAL.sMsjError;

        }
        public void Listar_Farmacias(ref cls_Inventarios_DAL Obj_Inventarios_DAL)
        {

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_Farmacias"].ToString();


            Obj_BD_DAL.sNomTabla = "T_FARMACIAS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Inventarios_DAL.sMsjError = string.Empty;
                Obj_Inventarios_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_Inventarios_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Inventarios_DAL.dtDatos = null;
            }




        }
    }
}
