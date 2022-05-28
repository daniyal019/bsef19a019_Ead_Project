using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace Project.Models
{
    public class CustomerData
    {

        public bool Add(Customer customer)
        {
            
                string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = $"Insert into customer (username,password,email,fullname) values('{customer.username}','{customer.password}','{customer.email}','{customer.fullName}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int rows = cmd.ExecuteNonQuery();
            if (rows >= 1)
            {
                return true;
            }


            else return false;
        }
        public List<Customer>Customers()
        {
            List<Customer> list = new List<Customer>();
            string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            string query = "Select * from customer";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                   Customer custom = new Customer();
                    custom.id = Convert.ToInt32(dr[0]);
                    custom.username = Convert.ToString(dr[1]);
                    custom.password = Convert.ToString(dr[2]);
                    custom.email = Convert.ToString(dr[3]);
                    custom.fullName = Convert.ToString(dr[4]);
                  list.Add(custom);
                }
            }
            return list;
        }
        public bool find(Customer custom)
        {
            string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            string query = $"Select * from customer where username = '{custom.username}' and password = '{custom.password}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
       
            if(dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
