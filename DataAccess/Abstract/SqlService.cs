using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccess
{
    public abstract class SqlService
    {
        readonly string connectionString = "Data Source=YOURSERVERNAME;Initial Catalog=STORE;Integrated Security=True";
        SqlConnection connection;
        public SqlService()
        {
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
        }

        public SqlConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlCommand Stored(string commandText, params SqlParameter[] parameters)// exec PersonelGuncelle
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = OpenConnection();
            command.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            command.ExecuteNonQuery();
            CloseConnection();
            return command;
        }

        public SqlDataReader StoreReader(string commandText, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = OpenConnection();
            command.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            SqlDataReader dataReader = command.ExecuteReader();
            return dataReader;
        }

        public DataTable GetDataTable(string commandText, params SqlParameter[] parameters)
        {
            CloseConnection();
            OpenConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = Stored(commandText, parameters);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
