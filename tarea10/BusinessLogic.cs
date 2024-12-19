using System.Data;

public class BusinessLogic
{
    private DataAccess dataAccess = new DataAccess();

    public DataTable GetSampleData()
    {
        string query = "SELECT * FROM SampleTable";
        return dataAccess.GetData(query);
    }
}
