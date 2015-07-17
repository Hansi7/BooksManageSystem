using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.IO;


namespace BooksManageSystem
{
    public class DBHelper
    {
        private static string conStr ;//=  @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB.accdb";

        static DBHelper()
        {
            conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""" +  Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"DB.accdb") + "\"";
        }
        //OleDbCommand comm = new OleDbCommand();
        public static DataTable ExecuteDataTable(OleDbCommand comm)
        {
            
            using (OleDbConnection conn = new OleDbConnection(conStr))
            {
                comm.Connection = conn;
                DataTable dt = new DataTable();
                OleDbDataAdapter adpt = new OleDbDataAdapter(comm);
                adpt.Fill(dt);
                return dt;
            }
        }

        public static object ExecuteScalar(OleDbCommand comm)
        {
            using (OleDbConnection conn = new OleDbConnection(conStr))
            {
                comm.Connection = conn;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                return comm.ExecuteScalar();
            }
        }

        public static int ExecuteNonQuery(OleDbCommand comm)
        {
            using (OleDbConnection conn = new OleDbConnection(conStr))
            {
                comm.Connection = conn;
                conn.Open();
                return comm.ExecuteNonQuery();
            }
        }

        public static int ExecuteNonQuery(string sql)
        {
            using (OleDbCommand comm = new OleDbCommand(sql))
            {
                return ExecuteNonQuery(comm);
            }
        }

    }
}
