using System.Data;
using System.Data.SqlClient;

public class DataAccess
{
    private string connectionString = "your_connection_string_here";

    public DataTable GetData(string query)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
