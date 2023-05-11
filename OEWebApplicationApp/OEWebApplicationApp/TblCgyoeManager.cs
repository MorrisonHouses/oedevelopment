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
using System.Drawing;

namespace OEWebApplicationApp.Models
{

    public partial class TblCgyoeManager
    {
        ClassFunctions function = new();
        ClassConfig configclass = new();


        /*GET REQUEST=================================================================================================================*/
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
                            Gstincluded = dr["GSTIncluded"] is DBNull ? (bool?) null: (bool)dr["GSTIncluded"],
                            //Budgeted = dr["Budgeted"] is DBNull ? (bool?) null: (bool)dr["Budgeted"],
                            //AutoApproved = dr["AutoApproved"] is DBNull ? (bool?) null: (bool)dr["AutoApproved"],
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

        /*GET REQUEST BY ID===========================================================================================================================*/
        public List<TblCgyoe> GetViewOERequestById(int id)
        {
            ClassConfig classConfig = new ClassConfig();
            List<TblCgyoe> listOfOERequest = new List<TblCgyoe>();
            string username = configclass.username();
            string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(config))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spr_CGYGetRequestOEById";
                command.Parameters.AddWithValue("@RequestId", id);
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
                        Gstincluded = dr["GSTIncluded"] is DBNull ? (bool?)null : (bool)dr["GSTIncluded"],
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


        /*UPDATE===========================================================================================================================*/
        public bool UpdateRequest(int id, TblCgyoe request)
        {
            ClassConfig configclass = new();
            int i = 0;
            ClassConfig classConfig = new ClassConfig();
            List<TblCgyoe> listOfOERequest = new List<TblCgyoe>();
            string username = configclass.username();
            string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(config))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spr_CGYUpdateOE";

                command.Parameters.AddWithValue("@RequestId", request.RequestId);
                if (request.Request != null) { command.Parameters.AddWithValue("@Request", request.Request); } else { command.Parameters.AddWithValue("@Request", DBNull.Value); };
                if (request.Reason != null) { command.Parameters.AddWithValue("@Reason", request.Reason); } else { command.Parameters.AddWithValue("@Reason", DBNull.Value); };

                //command.Parameters.AddWithValue("@RequestId", request.RequestId);
                //if (request.Vendor != null) { command.Parameters.AddWithValue("@Vendor", request.Vendor); } else { command.Parameters.AddWithValue("@Vendor", DBNull.Value); };
                //if (request.VendorName != null) { command.Parameters.AddWithValue("@VendorName", request.VendorName); } else { command.Parameters.AddWithValue("@VendorName", DBNull.Value); };
                //command.Parameters.AddWithValue("@RequestedBy", username);
                //if (request.Glaccount != null) { command.Parameters.AddWithValue("@GLAccount", request.Glaccount); } else { command.Parameters.AddWithValue("@GLAccount", DBNull.Value); };
                //if (request.AutoApproveThreshold != null) { command.Parameters.AddWithValue("@AutoApproveThreshold", request.AutoApproveThreshold); } else { command.Parameters.AddWithValue("@AutoApproveThreshold", DBNull.Value); };
                //if (request.Amount != null) { command.Parameters.AddWithValue("@Amount", request.Amount); } else { command.Parameters.AddWithValue("@Amount", DBNull.Value); };
                //if (request.Gstamount != null) { command.Parameters.AddWithValue("@GSTAmount", request.Gstamount); } else { command.Parameters.AddWithValue("@GSTAmount", DBNull.Value); };
                //if (request.TotalAmount != null) { command.Parameters.AddWithValue("@TotalAmount", request.TotalAmount); } else { command.Parameters.AddWithValue("@TotalAmount", DBNull.Value); };
                //if (request.Gstincluded != null) { command.Parameters.AddWithValue("@GSTIncluded", request.Gstincluded); } else { command.Parameters.AddWithValue("@GSTIncluded", DBNull.Value); };
                //if (request.Budgeted != null) { command.Parameters.AddWithValue("@Budgeted", request.Budgeted); } else { command.Parameters.AddWithValue("@Budgeted", DBNull.Value); };
                //if (request.AutoApproved != null) { command.Parameters.AddWithValue("@AutoApproved", request.AutoApproved); } else { command.Parameters.AddWithValue("@AutoApproved", DBNull.Value); };
                //if (request.Request != null) { command.Parameters.AddWithValue("@Request", request.Request); } else { command.Parameters.AddWithValue("@Request", DBNull.Value); };
                //if (request.PurchaseDate != null) { command.Parameters.AddWithValue("@PurchaseDate", request.PurchaseDate); } else { command.Parameters.AddWithValue("@PurchaseDate", DBNull.Value); };
                //if (request.ApprovedBy != null) { command.Parameters.AddWithValue("@ApprovedBy", request.ApprovedBy); } else { command.Parameters.AddWithValue("@ApprovedBy", DBNull.Value); };
                //if (request.ApprovedDate != null) { command.Parameters.AddWithValue("@ApprovedDate", request.ApprovedDate); } else { command.Parameters.AddWithValue("@ApprovedDate", DBNull.Value); };
                //if (request.Status != null) { command.Parameters.AddWithValue("@Status", request.Status); } else { command.Parameters.AddWithValue("@Status", DBNull.Value); };
                //if (request.Reason != null) { command.Parameters.AddWithValue("@Reason", request.Reason); } else { command.Parameters.AddWithValue("@Reason", DBNull.Value); };
                //if (request.Attachment != null) { command.Parameters.AddWithValue("@Attachment", request.Attachment); } else { command.Parameters.AddWithValue("@Attachment", DBNull.Value); };
                //if (request.Attachment != null) { command.Parameters.AddWithValue("@Attachment", request.Attachment); } else { command.Parameters.Add("@Attachment", SqlDbType.VarBinary, -1).Value = DBNull.Value; };
                //if (request.Timestamp != null) { command.Parameters.AddWithValue("@Timestamp", request.Timestamp); } else { command.Parameters.AddWithValue("@Timestamp", DBNull.Value); };

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }//using
            if (i > 0)
            { return true; }
            else { return false; }
        }//UpdateRequest

        /*DELETE===========================================================================================================================*/
        public string Delete(int id)
        {
            string username = configclass.username();
            string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";
            string result = "";
            using (SqlConnection connection = new SqlConnection(config))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spr_CGYDeleteOE";
                command.Parameters.AddWithValue("@RequestID", id);
                command.Parameters.Add("@OutputMessage", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                connection.Open();
                command.ExecuteNonQuery();
                result = command.Parameters["@OutputMessage"].Value.ToString();
                connection.Close();
            }//using
            return result;
        }//delete

        /*INSERT===========================================================================================================================*/
        public bool createProduct(TblCgyoe request)
        {
            string username = configclass.username();
            string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";
            int i = 0;
            using (SqlConnection connection = new SqlConnection(config))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spr_CGYInsertOE";
                command.Parameters.AddWithValue("@Vendor", request.Vendor);
                command.Parameters.AddWithValue("@VendorName", request.VendorName);
                command.Parameters.AddWithValue("@RequestedBy", username);
                command.Parameters.AddWithValue("@GLAccount", request.Glaccount);
                command.Parameters.AddWithValue("@Amount", request.@Amount);
                command.Parameters.AddWithValue("@GSTAmount", request.Gstamount);
                command.Parameters.AddWithValue("@TotalAmount", request.TotalAmount);
                command.Parameters.AddWithValue("@Budgeted", request.Budgeted);
                command.Parameters.AddWithValue("@Request", request.Request);
                command.Parameters.AddWithValue("@PurchaseDate", request.PurchaseDate);
                command.Parameters.AddWithValue("@Status", request.Status);
                command.Parameters.AddWithValue("@Reason", request.Reason);
                connection.Open();
                i = command.ExecuteNonQuery();
                connection.Close();
            }//using
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//createProduct




    }//class
}//namespace
