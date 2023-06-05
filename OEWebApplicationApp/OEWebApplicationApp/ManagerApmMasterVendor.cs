using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using OEWebApplicationApp.Models;
using System.Data;

namespace OEWebApplicationApp
{
    public class ManagerApmMasterVendor
    {
        ClassFunctions function = new();
        ClassConfig configclass = new();

        //GET ALL VENDORS ======================================================================
        public List<VendorModel> GetViewVendor()
        {

            List<VendorModel> listOfVendors = new List<VendorModel>();
            string username = configclass.username();
            string config = @"Data Source=VMORTL\SQLEXPRESS;Initial Catalog=TimberlineLink;User Id=ITMain;Password=M0rr1s0n1961; TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(config))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spr_APM_Master_Vendor";
                SqlDataAdapter sqlda = new SqlDataAdapter(command);
                DataTable dtOE = new DataTable();

                connection.Open();
                sqlda.Fill(dtOE);
                connection.Close();
                foreach (DataRow dr in dtOE.Rows)
                {
                    listOfVendors.Add(new VendorModel
                    {
                        Vendor = dr["Vendor"].ToString(),
                        Name = dr["name"].ToString(),

                    }); //list
                }//foreach
            }//using
            return listOfVendors;
            // return VendorModel;
        }//GetViewVendor

    }//class
}//namespace
