using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;

namespace BLL.CATALOGOS
{
   public class cls_Departamentos_BLL
    {
        public void listar_Departamentos(ref cls_Departamentos_DAL Obj_Departamentos_DAL)
        {

            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Listar_DEPARTAMENTOS"].ToString();

            Obj_BD_DAL.sNomTabla = "T_Departamentos";


            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Departamentos_DAL.sMsjError = string.Empty;
                Obj_Departamentos_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_Departamentos_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Departamentos_DAL.dtDatos = null;
            }

        }

        public void filtrar_Departamentos(ref cls_Departamentos_DAL Obj_Departamentos_DAL)
        {
            cls_Departamentos_DAL Obj_Departamentos = new cls_Departamentos_DAL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (Obj_Departamentos_DAL.sEspecialidad == null)
            {
                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Listar_DEPARTAMENTOS"].ToString();

            }
            else
            {

                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Filtrar_DEPARTAMENTOS"].ToString();
                Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_Departamentos_DAL.sEspecialidad); //Mando los parámetros del Store Procedure

            }

            Obj_BD_DAL.sNomTabla = "T_DEPARTAMENTOS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Departamentos_DAL.sMsjError = string.Empty;
                Obj_Departamentos_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_Departamentos_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Departamentos_DAL.dtDatos = null;
            }

        }

        public void eliminar_Departamentos(ref cls_Departamentos_DAL Obj_Departamentos_DAL)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["eliminar_DEPARTAMENTOS"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_AREA", "4", Obj_Departamentos_DAL.sCodArea); //Mando los parámetros del Store Procedure


            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_Departamentos_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void insertar_Departamentos(ref cls_Departamentos_DAL Obj_Departamentos_DAL)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["insertar_DEPARTAMENTOS"].ToString();

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable


            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_AREA", "4", Obj_Departamentos_DAL.sCodArea); //Mando los parámetros del Store Procedure
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_Departamentos_DAL.sEspecialidad);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO", "1", Obj_Departamentos_DAL.sTelefono);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_CENTRO", 7, Obj_Departamentos_DAL.sCodCentro);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_Departamentos_DAL.sMsjError = Obj_BD_DAL.sMsjError;

        }

        public void modificar_Departamentos(ref cls_Departamentos_DAL Obj_Departamentos_DAL)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["modificar_DEPARTAMENTOS"].ToString();

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Departamentos_DAL.sCodCentro);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_AREA", "4", Obj_Departamentos_DAL.sCodArea);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_Departamentos_DAL.sEspecialidad);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO", "1", Convert.ToInt32(Obj_Departamentos_DAL.sTelefono));

            // Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO", "1", Obj_Departamentos_DAL.sTel);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_Departamentos_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void listar_filtrar_Centros(ref cls_Departamentos_DAL Obj_Centro_DAL)

        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_CENTROS"].ToString();


            Obj_BD_DAL.sNomTabla = "T_listar_CENTROS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Centro_DAL.sMsjError = string.Empty;
                Obj_Centro_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_Centro_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Centro_DAL.dtDatos = null;
            }

        }

    }
}
