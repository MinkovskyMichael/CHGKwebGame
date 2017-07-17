using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ForSecPlus.DBconnect
{
    public class sqlConnection
    {
        public static DataSet getData(string procName)
        {
            return getData(procName, new string[,] { });
        }

        public static DataSet getData(string procName, string[,] myArray)
        {
            DataSet dsReturn = new DataSet();
            SqlCommand cmd;
            SqlConnection con = null;

            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["Db_connstr"].ConnectionString))
               
                con.Open();
                cmd = new SqlCommand(procName, con);
                cmd.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    if (myArray[i, 1] ==null)
                    {
                        cmd.Parameters.Add(new SqlParameter('@' + myArray[i, 0], DBNull.Value));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter('@' + myArray[i, 0], myArray[i, 1]));
                    }

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dsReturn);
                }
            }

            catch(SqlException e)
            {
                throw e;
            }

            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                if (con != null)
                {
                    con.Dispose();
                }
            }

            return dsReturn;
        }


    }
}