using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DAL.CATALOGOS;

namespace UX
{

   
    public class PRUEBAS_DATAGRID
    {
        //#region GLobales
        //cls_CCSS_DAL OBJ_DAL = new cls_CCSS_DAL();

        //#endregion
        ////CONEXION QUEMADA A UNA BASE DE DATOS DE CCSS para pruebas de GRID
        //public static SqlConnection Open()
        //{
        //    SqlConnection Conn = new SqlConnection("Data Source=desktop-rb\\SQL2019_DEV; User Id=sa;Password=123456;Max Pool Size=200");
        //    Conn.Open();
        //    return Conn;
        //}

        //public static SqlConnection Close()
        //{
        //    SqlConnection Conn = new SqlConnection("Data Source=desktop-rb\\SQL2019_DEV; User Id=sa;Password=123456;Max Pool Size=200");
        //    Conn.Close();
        //    return Conn;
        //}

        ////PRUEBAS con ESQUEMA de CONEXION REAL
        //public void crearDTparametros(ref CLS_BD_DAL_PRUEBA Obj_DAL)
        //{
        //    Obj_DAL.obj_dtParametros = new DataTable("parametros");
        //    Obj_DAL.obj_dtParametros.Columns.Add("Nom_Param");
        //    Obj_DAL.obj_dtParametros.Columns.Add("Tipo_Dato");
        //    Obj_DAL.obj_dtParametros.Columns.Add("Valor");
        //}

        //public void ExecCommand(ref CLS_BD_DAL_PRUEBA Obj_BD_DAL)
        //{//para realizar las instrucciones
        //    try
        //    {
        //        Obj_BD_DAL.obj_Sqlcnx = new SqlConnection(ConfigurationManager.ConnectionStrings["sql_auth"].ToString());

        //        if (Obj_BD_DAL.obj_Sqlcnx.State == ConnectionState.Closed)
        //        {
        //            Obj_BD_DAL.obj_Sqlcnx.Open();
        //        }



        //        Obj_BD_DAL.obj_Sqlcmd = new SqlCommand(Obj_BD_DAL.sNomSp,
        //                                                Obj_BD_DAL.obj_Sqlcnx);

        //        Obj_BD_DAL.obj_Sqlcmd.CommandType = CommandType.StoredProcedure;

        //        #region AGREGAR PARÁMETROS

        //        if (Obj_BD_DAL.obj_dtParametros != null)
        //        {
        //            SqlDbType TipoDatoSQL = SqlDbType.VarChar;

        //            foreach (DataRow dr in Obj_BD_DAL.obj_dtParametros.Rows)
        //            {
        //                #region Definición de tipos de Datos del SQL

        //                switch (dr[1])
        //                {
        //                    case "1":
        //                        {
        //                            TipoDatoSQL = SqlDbType.Int;
        //                            break;
        //                        }
        //                    case "2":
        //                        {
        //                            TipoDatoSQL = SqlDbType.Decimal;
        //                            break;
        //                        }
        //                    case "3":
        //                        {
        //                            TipoDatoSQL = SqlDbType.Float;
        //                            break;
        //                        }
        //                    case "4":
        //                        {
        //                            TipoDatoSQL = SqlDbType.Char;
        //                            break;
        //                        }
        //                    case "5":
        //                        {
        //                            TipoDatoSQL = SqlDbType.NChar;
        //                            break;
        //                        }
        //                    case "6":
        //                        {
        //                            TipoDatoSQL = SqlDbType.VarChar;
        //                            break;
        //                        }
        //                    case "7":
        //                        {
        //                            TipoDatoSQL = SqlDbType.NVarChar;
        //                            break;
        //                        }
        //                    case "8":
        //                        {
        //                            TipoDatoSQL = SqlDbType.DateTime;
        //                            break;
        //                        }
        //                    case "9":
        //                        {
        //                            TipoDatoSQL = SqlDbType.Bit;
        //                            break;
        //                        }
        //                    case "10":
        //                        {
        //                            TipoDatoSQL = SqlDbType.Money;
        //                            break;
        //                        }
        //                    case "11":
        //                        {
        //                            TipoDatoSQL = SqlDbType.TinyInt;
        //                            break;
        //                        }

        //                    default:
        //                        break;
        //                }

        //                #endregion

        //                Obj_BD_DAL.obj_Sqlcmd.Parameters.Add(dr[0].ToString(),
        //                                                                TipoDatoSQL
        //                                                                ).Value = dr[2].ToString();

        //            }
        //        }

        //        #endregion

        //        Obj_BD_DAL.obj_Sqlcmd.ExecuteNonQuery();

        //        Obj_BD_DAL.sMsjError = string.Empty;
        //    }
        //    catch (SqlException ex)
        //    {
        //        Obj_BD_DAL.sMsjError = ex.Message.ToString();
        //    }
        //    finally
        //    {
        //        if (Obj_BD_DAL.obj_Sqlcnx.State == ConnectionState.Open)
        //        {
        //            Obj_BD_DAL.obj_Sqlcnx.Close();
        //        }

        //        Obj_BD_DAL.obj_Sqlcnx.Dispose();
        //    }
        //}

    }
}