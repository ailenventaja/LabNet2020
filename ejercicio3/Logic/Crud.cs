using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Logic
{
    public class Crud
    {
        //Probé los insert, update y delete con SqlConnection
        public SqlConnection Connect()
        {
            SqlConnection cnn;
            string connectionString;
            connectionString = @"data source=(LocalDB)\MSSQLLocalDB;initial catalog=Northwind;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            return cnn;

        }

        public void Insert(string sqlInsert)
        {
            SqlConnection cnn = Connect();
            SqlCommand command;
            command = new SqlCommand(sqlInsert, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sqlInsert, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        public void Update (string sqlUpdate)
        {
            SqlConnection cnn = Connect();
            SqlCommand command;
            command = new SqlCommand(sqlUpdate, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = new SqlCommand(sqlUpdate, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
            }

        public void Delete (string sqlDelete)
        {
            SqlConnection cnn = Connect();
            SqlCommand command;
            command = new SqlCommand(sqlDelete, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = new SqlCommand(sqlDelete, cnn);
            command.ExecuteNonQuery();
            cnn.Close();

        }

    }

}
