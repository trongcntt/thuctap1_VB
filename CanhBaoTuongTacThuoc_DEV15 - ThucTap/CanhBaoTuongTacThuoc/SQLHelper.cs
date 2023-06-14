using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS4_0.Modules
{
    public static class SQLHelper
    {
        static SqlConnection sqlCon = null;
        public static bool ExecuteNonQuery(string spName, List<SQLParameter> lstPara)
        {
            using (sqlCon = new SqlConnection(HIS40Config.ConnectionString))
            {
                try
                {
                    sqlCon.Open();
                    SqlCommand sqlComm = new SqlCommand(spName, sqlCon);
                    sqlComm.CommandType = CommandType.StoredProcedure;

                    foreach (var item in lstPara)
                    {
                        sqlComm.Parameters.AddWithValue(item.ParaName, item.ParaType).Value = item.ParaValue;
                    }
                    sqlComm.ExecuteNonQuery();
                    sqlComm.Dispose();
                    sqlCon.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    HIS40Config.logger.ErrorException(ex.ToString(), ex);
                    return false;
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        public static bool ExecuteNonQueryWithTransaction(List<NanoSqlCommand> lstNanoSqlCommand)
        {
            SqlTransaction objTrans = null;
            using (sqlCon = new SqlConnection(HIS40Config.ConnectionString))
            {
                sqlCon.Open();
                objTrans = sqlCon.BeginTransaction();
                try
                {
                    foreach (var command in lstNanoSqlCommand)
                    {
                        SqlCommand sqlComm = new SqlCommand(command.SPName, sqlCon, objTrans);
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        foreach (var item in command.ListParas)
                        {
                            sqlComm.Parameters.AddWithValue(item.ParaName, item.ParaType).Value = item.ParaValue;
                        }
                        sqlComm.ExecuteNonQuery();
                        sqlComm.Dispose();
                    }
                    objTrans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    objTrans.Rollback();
                    HIS40Config.logger.ErrorException(ex.ToString(), ex);
                    return false;
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }
            public static List<SQLOutputParameter> ExecuteNonQueryWithOutput(string spName, List<SQLParameter> lstParaInput, List<SQLOutputParameter> lstParaOutput)
        {
            using (sqlCon = new SqlConnection(HIS40Config.ConnectionString))
            {
                try
                {
                    sqlCon.Open();
                    SqlCommand sqlComm = new SqlCommand(spName, sqlCon);
                    sqlComm.CommandType = CommandType.StoredProcedure;

                    foreach (var item in lstParaInput)
                    {
                        sqlComm.Parameters.AddWithValue(item.ParaName, item.ParaType).Value = item.ParaValue;
                    }
                    foreach (var item in lstParaOutput)
                    {
                        sqlComm.Parameters.Add(item.ParaName, item.ParaType, item.ParaSize).Direction = ParameterDirection.Output;
                    }
                    sqlComm.ExecuteNonQuery();
                    foreach (var item in lstParaOutput)
                    {
                        item.ParaResult = (sqlComm.Parameters[item.ParaName].Value);
                    }
                    //object kq = (sqlComm.Parameters[paraOutput.ParaName].Value);
                    sqlComm.Dispose();
                    sqlCon.Close();
                    return lstParaOutput;
                }
                catch (Exception ex)
                {
                    HIS40Config.logger.ErrorException(ex.ToString(), ex);
                    return lstParaOutput;
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        public static object ExecuteNonQueryWithOutput(string spName, List<SQLParameter> lstParaInput, SQLOutputParameter paraOutput)
        {
            using (sqlCon = new SqlConnection(HIS40Config.ConnectionString))
            {
                try
                {
                    sqlCon.Open();
                    SqlCommand sqlComm = new SqlCommand(spName, sqlCon);
                    sqlComm.CommandType = CommandType.StoredProcedure;

                    foreach (var item in lstParaInput)
                    {
                        sqlComm.Parameters.AddWithValue(item.ParaName, item.ParaType).Value = item.ParaValue;
                    }
                    sqlComm.Parameters.Add(paraOutput.ParaName, paraOutput.ParaType, paraOutput.ParaSize).Direction = ParameterDirection.Output;
                    sqlComm.ExecuteNonQuery();
                    object kq = (sqlComm.Parameters[paraOutput.ParaName].Value);
                    sqlComm.Dispose();
                    sqlCon.Close();
                    return kq;
                }
                catch (Exception ex)
                {
                    HIS40Config.logger.ErrorException(ex.ToString(), ex);
                    return ex;
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        public static DataSet ExecuteDataSet(string spName, List<SQLParameter> lstPara)
        {
            using (sqlCon = new SqlConnection(HIS40Config.ConnectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    sqlCon.Open();
                    SqlCommand sqlComm = new SqlCommand(spName, sqlCon);
                    sqlComm.CommandType = CommandType.StoredProcedure;

                    foreach (var item in lstPara)
                    {
                        sqlComm.Parameters.AddWithValue(item.ParaName, item.ParaType).Value = item.ParaValue;
                    }

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    da.Fill(ds);
                    sqlComm.Dispose();
                    sqlCon.Close();
                    return ds;
                }
                catch (Exception ex)
                {
                    HIS40Config.logger.ErrorException(ex.ToString(), ex);
                    return new DataSet();
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        public static DataTable ExecuteDataTable(string spName, List<SQLParameter> lstPara)
        {
            using (sqlCon = new SqlConnection(HIS40Config.ConnectionString))
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                try
                {
                    sqlCon.Open();
                    SqlCommand sqlComm = new SqlCommand(spName, sqlCon);
                    sqlComm.CommandType = CommandType.StoredProcedure;

                    foreach (var item in lstPara)
                    {
                        sqlComm.Parameters.AddWithValue(item.ParaName, item.ParaType).Value = item.ParaValue;
                    }

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    da.Fill(ds);

                    sqlComm.Dispose();
                    sqlCon.Close();
                    return ds.Tables[0];
                }
                catch (Exception ex)
                {
                    HIS40Config.logger.ErrorException(ex.ToString(), ex);
                    return new DataTable();
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }


    }
}
