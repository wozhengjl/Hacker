namespace DoubleColor.Redballs.Provider
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Summary description for DataBaseProvider
    /// </summary>
    public class SQLProvider : DataBaseProvider
    {
        public SQLProvider()
        {
            this.ConnectionString = ConfigurationManager.AppSettings["SQLConnr"];
        }

        public override DataTable Read(string selectStr)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(selectStr, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public override void Instert(string insertStr)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(insertStr, connection);
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}