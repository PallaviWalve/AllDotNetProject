using System.Data;
using System.Data.SqlClient;
using BusinessLogicLibrary;
namespace DataAccessLibrary
{
    public class CustomerDAL
    {
        static string cnstring = "Data Source=.\\sqlexpress;Initial Catalog=Shopping;User ID=sa;Password=123456";

        public List<CustomerBAL> GetCustomers()
        {
            DataSet ds = ConnectAndGetData();
           DataTable dt = ds.Tables["dt_customer"];
            List<CustomerBAL> custsList = new List<CustomerBAL>();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CustomerBAL cust = new CustomerBAL();
                cust.CustomerId = Convert.ToInt32(dt.Rows[i]["CustomerId"]);
                cust.CustName = dt.Rows[i]["CustomerName"].ToString();
                custsList.Add(cust);
            }
            return custsList;
        }

        public void InsertCustomer(CustomerBAL cust)
        {
            DataSet ds = ConnectAndGetData();
            DataRow drow = ds.Tables["dt_customer"].NewRow();
            drow["CustomerId"] = cust.CustomerId;
            drow["CustomerName"] = cust.CustName;
            ds.Tables["dt_customer"].Rows.Add(drow);
            ConnectandUpdateServer(ds);
        }

        public void DeleteCustomer(int id)
        {
            DataSet ds = ConnectAndGetData();
            DataRow drow = ds.Tables["dt_customer"].Rows.Find(id);
            drow.Delete();
            ConnectandUpdateServer(ds);

        }

        public CustomerBAL FindCustomer(int id)
        {
                DataSet ds = ConnectAndGetData();
                DataRow drow = ds.Tables["dt_customer"].Rows.Find(id);
                CustomerBAL bal = new CustomerBAL();
                 bal.CustomerId = (int)drow["CustomerId"];
                 bal.CustName = drow["CustomerName"].ToString();
                return bal;
        }

        private static void ConnectandUpdateServer(DataSet ds)
        {
            SqlConnection cn = new SqlConnection(cnstring);
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Customer", cn);
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds.Tables["dt_customer"]);
        }

        private static DataSet ConnectAndGetData()
        {
            

            SqlConnection cn = new SqlConnection(cnstring);

            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Customer", cn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            //SqlDataAdapter da1 = new SqlDataAdapter("select * from dt_products", cn);
            DataSet ds  = new DataSet(); 
            da.Fill(ds, "dt_customer");
            //da1.Fill(ds, "dt_products");
            return ds;
        }

        public void UpdateCustomer(int id, CustomerBAL details)
        {
            DataSet ds = ConnectAndGetData();
            DataRow drow = ds.Tables["dt_customer"].Rows.Find(id);
            drow["CustomerId"] = details.CustomerId;
            drow["CustomerName"] = details.CustName;
            ConnectandUpdateServer(ds);
        }
    }
}