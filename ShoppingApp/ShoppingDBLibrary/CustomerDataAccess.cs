using System.Data;
using BusinessLogicLibrary;
using Microsoft.Data.SqlClient;
using ShoppingDBLibrary;
namespace ShoppingDBLibrary
{
    public class CustomerDataAccess
    {
        string cnString = "Data Source=.\\sqlexpress;" +
            "Initial Catalog=Shopping;User ID=sa;" +
            "Password=123456;Trust Server Certificate = True";
        public void InsertCustomer(CustomerBusinessLogic c)
        {
            SqlConnection cn = new SqlConnection(cnString);
            SqlCommand cmd = new SqlCommand("[dbo].sp_NewCustomer", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cn.Open();

            cmd.Parameters.AddWithValue("@p_Custid", c.CustomerId);
            cmd.Parameters.AddWithValue("@p_CustName", c.CustomerName);

            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
        }

        public void UpdateCustomer(int id, CustomerBusinessLogic c)
        {

        }

        public CustomerBusinessLogic? DeleteCustomer(int id)
        {
            CustomerBusinessLogic c = new CustomerBusinessLogic();
            SqlConnection cn = new SqlConnection(cnString);
            SqlCommand cmd = new SqlCommand("select * from tbl_Customer where CustomerId = " +id, cn);
            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                c.CustomerId = Convert.ToInt32(dr[0]);
                c.CustomerName = dr[1].ToString();

                cn.Close();
                cn.Dispose();
                cmd.Dispose();

                Console.WriteLine("Are you sure to delete");
                char ans = Convert.ToChar(Console.ReadLine());

                if (ans == 'y' || ans == 'Y')
                {
                    cn = new SqlConnection(cnString);
                    cmd = new SqlCommand("[dbo].sp_DeleteCustomer", cn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();

                    cmd.Parameters.AddWithValue("@custid", c.CustomerId);
                   
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    cn.Dispose();
                }
            }
            return c;

        }

        public List<CustomerBusinessLogic> ShowCustomerList()
        {
            SqlConnection cn = new SqlConnection(cnString);
            SqlCommand cmd = new SqlCommand("select * from tbl_Customer",cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<CustomerBusinessLogic> custlist = new List<CustomerBusinessLogic>();   

            while (dr.Read())
            {
                CustomerBusinessLogic cust = new CustomerBusinessLogic();
                for (int i = 0; i < 2; i++)
                {
                    cust.CustomerId = Convert.ToInt32(dr[0]);
                    cust.CustomerName = dr[1].ToString();
                    
                }
                custlist.Add(cust);
            }
            cmd.Dispose();
            cn.Close();
            cn.Dispose();

            return custlist;

        }
    }
}