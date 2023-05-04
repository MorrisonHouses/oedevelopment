using Microsoft.Data.SqlClient;
using OEWebApplicationApp.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using Microsoft.Extensions.Configuration;
using ConfigurationManager = System.Configuration.ConfigurationManager;
using Microsoft.Web.Administration;
using Configuration = System.Configuration.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace OEWebApplicationApp.Models
{

    public partial class TblCgyoeManager
    {
        ClassFunctions function = new();
        ClassConfig configclass = new();


        /*get request by logged in user=================================================================================================================*/
        public List<TblCgyoe> GetViewOERequest()
            {
                ClassConfig classConfig = new ClassConfig();
                List<TblCgyoe> listOfOERequest = new List<TblCgyoe>();
                string username = configclass.username();
                string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(config))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spr_CGYGetRequesterOE";
                    command.Parameters.AddWithValue("@RequestedBy", username);
                    SqlDataAdapter sqlda = new SqlDataAdapter(command);
                    DataTable dtOE = new DataTable();

                    connection.Open();
                    sqlda.Fill(dtOE);
                    connection.Close();
                    foreach (DataRow dr in dtOE.Rows)
                    {
                        listOfOERequest.Add(new TblCgyoe
                        {
                            RequestId = Convert.ToInt32(dr["RequestId"]),
                            Vendor = (dr["Vendor"] is not DBNull) ? dr["Vendor"].ToString() : null,
                            VendorName = (dr["VendorName"] is not DBNull) ? dr["VendorName"].ToString() : null,
                            RequestedBy = (dr["RequestedBy"] is not DBNull) ? dr["RequestedBy"].ToString() : null,
                            Glaccount = (dr["Glaccount"] is not DBNull) ? dr["Glaccount"].ToString() : null,
                            AutoApproveThreshold = (dr["AutoApproveThreshold"] is not DBNull) ? Convert.ToInt32(dr["AutoApproveThreshold"]) : null,
                            Amount = (dr["Amount"] is not DBNull) ? Convert.ToInt32(dr["Amount"]) : null,
                            Gstamount = (dr["Gstamount"] is not DBNull) ? Convert.ToInt32(dr["Gstamount"]) : null,
                            TotalAmount = (dr["TotalAmount"] is not DBNull) ? Convert.ToInt32(dr["TotalAmount"]) : null,
                            Gstincluded = dr["TotalAmount"] is DBNull ? (bool?) null: (bool)dr["TotalAmount"],
                            Budgeted = dr["Budgeted"] is DBNull ? (bool?) null: (bool)dr["Budgeted"],
                            AutoApproved = dr["AutoApproved"] is DBNull ? (bool?) null: (bool)dr["AutoApproved"],
                            Request = (dr["Request"] is not DBNull) ? dr["Request"].ToString() : null,
                            PurchaseDate = Convert.ToDateTime(dr["PurchaseDate"]),
                            ApprovedBy = (dr["ApprovedBy"] is not DBNull) ? dr["ApprovedBy"].ToString() : null,
                            ApprovedDate = (dr["ApprovedDate"] is not DBNull) ? Convert.ToDateTime(dr["ApprovedDate"]) : null,
                            Status = (dr["Status"] is not DBNull) ? dr["Status"].ToString() : null,
                            Reason = (dr["Reason"] is not DBNull) ? dr["Reason"].ToString() : null,
                            Attachment = (dr["Attachment"] is not DBNull) ? (byte[])dr["Attachment"] : null,
                            Timestamp = (dr["Timestamp"] is not DBNull) ? Convert.ToDateTime(dr["Timestamp"]) : null,

                        });//list
                    }//foreach
                }//using
                return listOfOERequest;
        }//GetViewOERequest

        /*get request by id===========================================================================================================================*/
        public List<TblCgyoe> GetViewOERequestById(int requestId)
        {
            ClassConfig classConfig = new ClassConfig();
            List<TblCgyoe> listOfOERequest = new List<TblCgyoe>();
            string username = configclass.username();
            string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(config))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spr_CGYGetRequesterOE";
                command.Parameters.AddWithValue("@RequestId", username);
                SqlDataAdapter sqlda = new SqlDataAdapter(command);
                DataTable dtOE = new DataTable();

                connection.Open();
                sqlda.Fill(dtOE);
                connection.Close();
                foreach (DataRow dr in dtOE.Rows)
                {
                    listOfOERequest.Add(new TblCgyoe
                    {
                        RequestId = Convert.ToInt32(dr["RequestId"]),
                        Vendor = (dr["Vendor"] is not DBNull) ? dr["Vendor"].ToString() : null,
                        VendorName = (dr["VendorName"] is not DBNull) ? dr["VendorName"].ToString() : null,
                        RequestedBy = (dr["RequestedBy"] is not DBNull) ? dr["RequestedBy"].ToString() : null,
                        Glaccount = (dr["Glaccount"] is not DBNull) ? dr["Glaccount"].ToString() : null,
                        AutoApproveThreshold = (dr["AutoApproveThreshold"] is not DBNull) ? Convert.ToInt32(dr["AutoApproveThreshold"]) : null,
                        Amount = (dr["Amount"] is not DBNull) ? Convert.ToInt32(dr["Amount"]) : null,
                        Gstamount = (dr["Gstamount"] is not DBNull) ? Convert.ToInt32(dr["Gstamount"]) : null,
                        TotalAmount = (dr["TotalAmount"] is not DBNull) ? Convert.ToInt32(dr["TotalAmount"]) : null,
                        Gstincluded = dr["TotalAmount"] is DBNull ? (bool?)null : (bool)dr["TotalAmount"],
                        Budgeted = dr["Budgeted"] is DBNull ? (bool?)null : (bool)dr["Budgeted"],
                        AutoApproved = dr["AutoApproved"] is DBNull ? (bool?)null : (bool)dr["AutoApproved"],
                        Request = (dr["Request"] is not DBNull) ? dr["Request"].ToString() : null,
                        PurchaseDate = Convert.ToDateTime(dr["PurchaseDate"]),
                        ApprovedBy = (dr["ApprovedBy"] is not DBNull) ? dr["ApprovedBy"].ToString() : null,
                        ApprovedDate = (dr["ApprovedDate"] is not DBNull) ? Convert.ToDateTime(dr["ApprovedDate"]) : null,
                        Status = (dr["Status"] is not DBNull) ? dr["Status"].ToString() : null,
                        Reason = (dr["Reason"] is not DBNull) ? dr["Reason"].ToString() : null,
                        Attachment = (dr["Attachment"] is not DBNull) ? (byte[])dr["Attachment"] : null,
                        Timestamp = (dr["Timestamp"] is not DBNull) ? Convert.ToDateTime(dr["Timestamp"]) : null,

                    });//list
                }//foreach
            }//using
            return listOfOERequest;
        }//GetViewOERequest


        /*new request===========================================================================================================================*/

    }//class
}//namespace
