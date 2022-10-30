using Adonet.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Adonet
{
    public class EmpRepository
    {
        private SqlConnection con;

        private void Connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getEmp"].ToString();
            con = new SqlConnection(constr);
        }

        //Add Employee Details
        public bool AddEmployee(EmpModel obj)
        {
            Connection();
            SqlCommand sqlCommand = new SqlCommand("AddNewEmpDetails", con);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Name", obj.Name);
            sqlCommand.Parameters.AddWithValue("@Age", obj.Age);

            con.Open();
            int i = sqlCommand.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                return true;
            else return false;
        }


        public List<EmpModel> GetAllEmployees()
        {
            Connection();
            List<EmpModel> empList = new List<EmpModel>();

            SqlCommand com = new SqlCommand("GetEmployees", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();

            //Bind EmpModel generic list using dataRow
            foreach(DataRow dr in dt.Rows)
            {
                empList.Add(new EmpModel
                {
                    Empid = Convert.ToInt32(dr["Id"]),
                    Name = Convert.ToString(dr["Name"]),
                    Age = Convert.ToInt32(dr["Age"])
                });
            }

            return empList;
        }

    }
}