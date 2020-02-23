using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



public class DatabaseConnection
{
	public DatabaseConnection(string connectionString)
	{
        this.ConnectionString = connectionString;
	}

    public string ConnectionString { get; set; }
    
    


    private void Connect()
    {
        SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        if (sqlConnection.state == ConnectionState.Closed)
            sqlConnection.Open();

        using (SqlCommand sqlCommand = new sqlCommand(String.Format("SELECT * FROM", sqlConnection)))
        {
            IDataReader dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                
            }
        }

    }
    

}
