using System;
using System.Web.UI;
using System.Data;

public partial class _Default : Page
{
    private BusinessLogic businessLogic = new BusinessLogic();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable data = businessLogic.GetSampleData();
            // Bind data to controls, e.g., GridView, Repeater, etc.
        }
    }
}
