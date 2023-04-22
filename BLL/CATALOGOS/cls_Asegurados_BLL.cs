using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DAL.CATALOGOS;
using BLL.WCF;

namespace BLL.CATALOGOS
{
    public class cls_Asegurados_BLL
    {
        public void listar_filtrar_Asegurados(ref cls_Asegurados_DAL Obj_Asegurados_DAL) //LISTO
        {

            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Asegurados_DAL.sCedAsegurado == string.Empty) // Para Listar si esta vacio
            {
                Obj_Asegurados_DAL.dtParametros = null;
                Obj_Asegurados_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_ASEGURADOS", ConfigurationManager.AppSettings["Listar_ASEGURADOS"], Obj_Asegurados_DAL.dtParametros);
            }
            else // Para filtrar
            {
                Obj_Asegurados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Asegurados_DAL.dtParametros);
                Obj_Asegurados_DAL.dtParametros.Rows.Add("@Filtro", "7", Obj_Asegurados_DAL.sCodCentro);
                Obj_Asegurados_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_ASEGURADOS", ConfigurationManager.AppSettings["Filtrar_ASEGURADOS"], Obj_Asegurados_DAL.dtParametros);
            }
        }

        
        

        public void eliminar_Asegurados(ref cls_Asegurados_DAL Obj_Asegurados_DAL)
        {
            

            {
                WCF.BDClient Obj_WCF = new BDClient();


                Obj_Asegurados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Asegurados_DAL.dtParametros);

                Obj_Asegurados_DAL.dtParametros.Rows.Add("@CED_ASEGURADO", "7", Obj_Asegurados_DAL.sCodCentro);



                Obj_Asegurados_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Eliminar_ASEGURADO"], "NORMAL", Obj_Asegurados_DAL.dtParametros);

            }

          
            }

            public void insertar_Asegurados(ref cls_Asegurados_DAL Obj_Asegurados_DAL)
            {
                WCF.BDClient Obj_WCF = new BDClient();

                Obj_Asegurados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Asegurados_DAL.dtParametros);

                Obj_Asegurados_DAL.dtParametros.Rows.Add("@CED_ASEGURADO", "7", Obj_Asegurados_DAL.sCedAsegurado);
                Obj_Asegurados_DAL.dtParametros.Rows.Add("@NOMBRE", "7", Obj_Asegurados_DAL.sNombre);
                Obj_Asegurados_DAL.dtParametros.Rows.Add("@TELEFONO", "7", Obj_Asegurados_DAL.sTelefono);
                Obj_Asegurados_DAL.dtParametros.Rows.Add("@DIRECCION", "7", Obj_Asegurados_DAL.sDireccion);
                Obj_Asegurados_DAL.dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Asegurados_DAL.sCodCentro);

            Obj_Asegurados_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Insertar_ASEGURADOS"], "IDENTITY", Obj_Asegurados_DAL.dtParametros);
        }

            public void modificar_Asegurados(ref cls_Asegurados_DAL Obj_Asegurados_DAL)
            {

             WCF.BDClient Obj_WCF = new BDClient();

            Obj_Asegurados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Asegurados_DAL.dtParametros);

            Obj_Asegurados_DAL.dtParametros.Rows.Add("@CED_ASEGURADO", "7", Obj_Asegurados_DAL.sCedAsegurado);
            Obj_Asegurados_DAL.dtParametros.Rows.Add("@NOMBRE", "7", Obj_Asegurados_DAL.sNombre);
            Obj_Asegurados_DAL.dtParametros.Rows.Add("@TELEFONO", "7", Obj_Asegurados_DAL.sTelefono);
            Obj_Asegurados_DAL.dtParametros.Rows.Add("@DIRECCION", "7", Obj_Asegurados_DAL.sDireccion);
            Obj_Asegurados_DAL.dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Asegurados_DAL.sCodCentro);

            Obj_Asegurados_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Modificar_ASEGURADOS"], "NORMAL", Obj_Asegurados_DAL.dtParametros);
        }

            public void listar_filtrar_Centro(ref cls_Centros_DAL Obj_Centro_DAL)

            {
             WCF.BDClient Obj_WCF = new BDClient();


            if (Obj_Centro_DAL.sDescripcion == string.Empty) // Para Listar si esta vacio
            {
                Obj_Centro_DAL.dtParametros = null;
                Obj_Centro_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CENTROS", "listar_CCSS", Obj_Centro_DAL.dtParametros);
            }
            else // Para filtrar
            {
                Obj_Centro_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Centro_DAL.dtParametros);
                Obj_Centro_DAL.dtParametros.Rows.Add("@Filtro", "5", Obj_Centro_DAL.sCedJur);
                Obj_Centro_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CENTROS", ConfigurationManager.AppSettings["filtrar_CENTROS"], Obj_Centro_DAL.dtParametros);
            }

        }

        }
}
