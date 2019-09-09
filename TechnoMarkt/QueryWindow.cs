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

namespace TechnoMarkt
{
    public partial class QueryWindow : Form
    {

        SqlConnection con = new SqlConnection("Data Source=ABRA;Initial Catalog=TechnoMarkt;Integrated Security=True");
        public QueryWindow()
        {
            InitializeComponent();
        }

        private void run_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand.Text, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void productDetails_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From ProductsDetails", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void workerDetails_Click(object sender, EventArgs e)
        {
           
            SqlDataAdapter sda = new SqlDataAdapter("Select per.BusinessEntityID, per.Title, per.FirstName, ISNULL(per.MiddleName,' ') AS MiddleName, per.LastName, emp.JobTitle, per.EmailAddress, emp.Salary FROM dbo.[Person.Person] AS per INNER JOIN dbo.[HumanResources.Employee] as emp ON per.BusinessEntityID = emp.BusinessEntityID", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
