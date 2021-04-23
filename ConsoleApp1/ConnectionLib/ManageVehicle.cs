using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectionLib
{
    
    public class ManageVehicle
    {
        string Con = @"Integrated Security =SSPI;initial catalog=Vehicle;Data Source=LAPTOP-5RS1NN83;";
        


        public DataSet getvehicledetails()
        {
            
            SqlConnection conn = new SqlConnection(Con);
            conn.Open();
            string sql = "select * from VehicleInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Vehicle");

            return ds;
        }

        public DataSet getvehicledetails1()
        {
            string sql = "select * from OtherInformation;";
            SqlConnection conn = new SqlConnection(Con);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "OtherInfo");

            return ds;
        }
    }
}
