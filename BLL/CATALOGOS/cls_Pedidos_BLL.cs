using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;

namespace BLL.CATALOGOS
{
    public class cls_Pedidos_BLL
    {
        //    public void listar_filtrar_Pedidos(ref cls_Pedidos_DAL Obj_Pedidos_DAL)
        //    {
        //        cls_Pedidos_DAL Obj_Pedidos = new cls_Pedidos_DAL();
        //        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //        if (Obj_Pedidos_DAL.scodpedido == string.Empty)
        //        {
        //            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_Pedidos"].ToString();

        //        }
        //        else
        //        {

        //            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["filtrar_Pedidos"].ToString();
        //            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
        //            Obj_BD_DAL.obj_dtParametros.Rows.Add("@FILTRO", "7", Obj_Pedidos_DAL.scodpedido);

        //        }

        //        Obj_BD_DAL.sNomTabla = "T_PEDIDOS";

        //        Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

        //        if (Obj_BD_DAL.sMsjError == string.Empty)
        //        {
        //            Obj_Pedidos_DAL.sMsjError = string.Empty;
        //            Obj_Pedidos_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
        //        }
        //        else
        //        {
        //            Obj_Pedidos_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //            Obj_Pedidos_DAL.dtDatos = null;
        //        }
        //    }
        //    public void listar_Pedidos(ref cls_Pedidos_DAL Obj_Pedidos_DAL)
        //    {

        //        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();


        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_Pedidos"].ToString();

        //        Obj_BD_DAL.sNomTabla = "T_PEDIDOS";

        //        Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

        //        if (Obj_BD_DAL.sMsjError == string.Empty)
        //        {
        //            Obj_Pedidos_DAL.sMsjError = string.Empty;
        //            Obj_Pedidos_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
        //        }
        //        else
        //        {
        //            Obj_Pedidos_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //            Obj_Pedidos_DAL.dtDatos = null;
        //        }

        //    }
        //    public void eliminar_Pedidos(ref cls_Pedidos_DAL Obj_pedidos_DAL)
        //    {
        //        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["eliminar_Pedidos"].ToString();
        //        Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_PEDIDO", "7", Obj_pedidos_DAL.scodpedido);

        //        Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //        Obj_pedidos_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //    }
        //    public void insertar_Pedidos(ref cls_Pedidos_DAL Obj_Territorios_DAL)
        //    {
        //        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["insertar_Pedidos"].ToString();

        //        Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_PEDIDO", "7", Obj_Territorios_DAL.scodpedido);
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_FARMACIA", "7", Obj_Territorios_DAL.scodfarmacia);
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@MEDICAMENTOS", "7", Obj_Territorios_DAL.sMedicamnetos);

        //        Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //        Obj_Territorios_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //    }
        //    public void modificar_Pedidos(ref cls_Pedidos_DAL Obj_Territorios_DAL)
        //    {
        //        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["modificar_Pedidos"].ToString();

        //        Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_PEDIDO", "7", Obj_Territorios_DAL.scodpedido);
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_FARMACIA", "7", Obj_Territorios_DAL.scodfarmacia);
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@MEDICAMENTOS", "7", Obj_Territorios_DAL.sMedicamnetos);

        //        Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //        Obj_Territorios_DAL.sMsjError = Obj_BD_DAL.sMsjError;


        //    }
    }
}
