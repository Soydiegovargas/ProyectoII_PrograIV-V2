using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.WCF;
using DAL.CATALOGOS;
using System.Configuration;

namespace BLL.CATALOGOS
{
    public class cls_Centros_BLL
    {


        public void listar_filtrar_Centros(ref cls_Centros_DAL Obj_Centros_DAL)
        {

            cls_Centros_DAL Obj_Centros = new cls_Centros_DAL();


            if (Obj_Centros_DAL.sCodCentro == string.Empty)
            {
                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_CENTROS"].ToString();

            }
            else
            {

                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Filtrar_CENTROS"].ToString();
                Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@FILTRO", "7", Obj_Centros_DAL.sCodCentro); //Mando los parámetros del Store Procedure

            }

            Obj_BD_DAL.sNomTabla = "T_CENTROS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Centros_DAL.sMsjError = string.Empty;
                Obj_Centros_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_Centros_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Centros_DAL.dtDatos = null;
            }

        }

        public void listar_filtrar_CCSS(ref cls_Centros_DAL Obj_CCSS_DAL)
        {

            cls_Centros_DAL Obj_Centros_DAL = new cls_Centros_DAL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();


            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Listar_CCSS"].ToString();

            Obj_BD_DAL.sNomTabla = "T_CCSS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_CCSS_DAL.sMsjError = string.Empty;
                Obj_CCSS_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_CCSS_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_CCSS_DAL.dtDatos = null;
            }

        }

        public void eliminar_Centros(ref cls_Centros_DAL Obj_Centros_DAL)
        {


            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Eliminar_CENTRO"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Centros_DAL.sCodCentro); //Mando los parámetros del Store Procedure

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_Centros_DAL.sMsjError = Obj_BD_DAL.sMsjError;


        }

        public void insertar_Centros(ref cls_Centros_DAL Obj_Centros_DAL)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Insertar_CENTROS"].ToString();

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable

            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_JUNTA", "7", Obj_Centros_DAL.sCodJunta);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_JUR", "7", Obj_Centros_DAL.sCedJur);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@NOMBRE", "7", Obj_Centros_DAL.sNombreC);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@DIRECCION", "7", Obj_Centros_DAL.sDirrecionC);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Centros_DAL.sCodCentro);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_Centros_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void modificar_Centros(ref cls_Centros_DAL Obj_Centros_DAL)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Modificar_CENTROS"].ToString();

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable

            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_JUNTA", "7", Obj_Centros_DAL.sCodJunta);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_JUR", "7", Obj_Centros_DAL.sCedJur);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@NOMBRE", "7", Obj_Centros_DAL.sNombreC);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@DIRECCION", "7", Obj_Centros_DAL.sDirrecionC);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Centros_DAL.sCodCentro);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_Centros_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Listar_CCCS(ref cls_Centros_DAL Obj_Centros_DAL)
        {


            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_CCSS"].ToString();


            Obj_BD_DAL.sNomTabla = "T_CCSS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Centros_DAL.sMsjError = string.Empty;
                Obj_Centros_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_Centros_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Centros_DAL.dtDatos = null;
            }




        }

        public void Listar_JUNTA(ref cls_Centros_DAL Obj_Juntas_DAL)
        {


            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_Juntas"].ToString();


            Obj_BD_DAL.sNomTabla = "T_JUNTAS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Juntas_DAL.sMsjError = string.Empty;
                Obj_Juntas_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_Juntas_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Juntas_DAL.dtDatos = null;
            }




        }
    }
}
