using Microsoft.Data.SqlClient;
using System.Data;

namespace OEWebApplicationApp
{
    public class ApmMasterVendorManager
    {
        ClassFunctions function = new();
        ClassConfig configclass = new();
        public List<ApmMasterVendor> GetViewVendor()
        {
            ApmMasterVendor apmMasterVendor = new ApmMasterVendor();
            ClassConfig classConfig = new ClassConfig();
            TimberlineLinkContext context = new TimberlineLinkContext();
            List<ApmMasterVendor> apmMasterVendors = context.ApmMasterVendors.ToList();
            
            //List<ApmMasterVendor> listOfVendors = new List<ApmMasterVendor>();
            //string username = configclass.username();
            //string config = @"Data Source=VMORTL\SQLEXPRESS;Initial Catalog=TimberlineLink;User Id=ITMain;Password=M0rr1s0n1961; TrustServerCertificate=True";
            //using (SqlConnection connection = new SqlConnection(config))
            //{
            //    SqlCommand command = connection.CreateCommand();
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.CommandText = "spr_APM_Master_Vendor";
            //    SqlDataAdapter sqlda = new SqlDataAdapter(command);
            //    DataTable dtOE = new DataTable();

            //    connection.Open();
            //    sqlda.Fill(dtOE);
            //    connection.Close();
            //    foreach (DataRow dr in dtOE.Rows)
            //    {
            //        listOfVendors.Add(new ApmMasterVendor
            //        {
            //            Vendor = dr["Vendor"].ToString(),
            //            //Vendor = (dr["Vendor"] is not DBNull) ? dr["Vendor"].ToString() : null,
            //            //Name = (dr["Name"] is not DBNull) ? dr["Name"].ToString() : null,

            //        }); //list
            //    }//foreach
            //}//using
            return apmMasterVendors;
        }//GetViewVendor

    }//class
}//namespace
