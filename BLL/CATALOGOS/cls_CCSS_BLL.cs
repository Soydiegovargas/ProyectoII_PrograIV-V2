using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;

namespace BLL.CATALOGOS
{
    public class cls_CCSS_BLL
    {
        public void insertar_CCSS(ref cls_CCSS_DAL Obj_NuevoCCSS_DAL)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["insertar_CCSS"].ToString();

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_JUR", "7", Obj_NuevoCCSS_DAL.sCed_Jur);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO ", "1", Obj_NuevoCCSS_DAL.iTelefono);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@PAGINA", "5", Obj_NuevoCCSS_DAL.sPagina);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@DESCRIPCION", "5", Obj_NuevoCCSS_DAL.sDescripcion);


            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);
            Obj_NuevoCCSS_DAL.sMsgError = Obj_BD_DAL.sMsjError;

        }

        public void modificar_CCSS(ref cls_CCSS_DAL Obj_CCSS_DAL)
        {

            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["modificar_CCSS"].ToString();

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_JUR", "7", Obj_CCSS_DAL.sCed_Jur);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO ", "1", Obj_CCSS_DAL.iTelefono);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@PAGINA", "5", Obj_CCSS_DAL.sPagina);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@DESCRIPCION", "5", Obj_CCSS_DAL.sDescripcion);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);
            Obj_CCSS_DAL.sMsgError = Obj_BD_DAL.sMsjError;

        }

        public void eliminar_CCSS(ref cls_CCSS_DAL Obj_CCSS_DAL)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();


            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["eliminar_CCSS"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_JUR", "7", Obj_CCSS_DAL.sCed_Jur);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_CCSS_DAL.sMsgError = Obj_BD_DAL.sMsjError;

        }

        public void listar_CCSS(ref cls_CCSS_DAL Obj_CCSS_DAL)
        {
            cls_Empleados_DAL Obj_Caja = new cls_Empleados_DAL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (Obj_CCSS_DAL.sDescripcion == string.Empty)
            {

                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_CCSS"].ToString();
            }
            else
            {
                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["filtrar_CCSS"].ToString();
                Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Filtro", "5", Obj_CCSS_DAL.sCed_Jur);
            }

            Obj_BD_DAL.sNomTabla = "T_CCSS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_CCSS_DAL.sMsgError = string.Empty;
                Obj_CCSS_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_Caja.sMsgError = Obj_BD_DAL.sMsjError;
                Obj_Caja.dtDatos = null;
            }

        }

        public void listar_filtrar_CCSS(ref cls_CCSS_DAL Obj_CCSS_DAL)

        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_CCSS"].ToString();


            Obj_BD_DAL.sNomTabla = "T_CCSS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_CCSS_DAL.sMsgError = string.Empty;
                Obj_CCSS_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_CCSS_DAL.sMsgError = Obj_BD_DAL.sMsjError;
                Obj_CCSS_DAL.dtDatos = null;
            }

        }
    }
}
