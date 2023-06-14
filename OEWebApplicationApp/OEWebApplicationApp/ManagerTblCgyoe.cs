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
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace OEWebApplicationApp.Models
{
    // TODO: insert proper connection string
    public partial class ManagerTblCgyoe
    {
        ClassFunctions function = new();
        ClassConfig configclass = new();

        /*GET REQUEST=================================================================================================================*/
        public List<TblCgyoeModel> GetViewOERequest(string id)
            {
                ClassConfig classConfig = new ClassConfig();
                List<TblCgyoeModel> listOfOERequest = new List<TblCgyoeModel>();
                string username = configclass.username();
                if (id == null) { id = "All"; };
                string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(config))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spr_CGYGetRequesterOEStatus";
                    command.Parameters.AddWithValue("@RequestedBy", username);
                    command.Parameters.AddWithValue("@Status", id);
                SqlDataAdapter sqlda = new SqlDataAdapter(command);
                    DataTable dtOE = new DataTable();
                    connection.Open();
                    sqlda.Fill(dtOE);
                    connection.Close();
                    foreach (DataRow dr in dtOE.Rows)
                    {
                        listOfOERequest.Add(new TblCgyoeModel
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
                            //Attachment = (dr["Attachment"] is not DBNull) ? (byte[])dr["Attachment"] : null,
                            Timestamp = (dr["Timestamp"] is not DBNull) ? Convert.ToDateTime(dr["Timestamp"]) : null,

                        });//list
                    }//foreach
                }//using
                return listOfOERequest;
        }//GetViewOERequest

        /*GET REQUEST BY ID===========================================================================================================================*/
        public List<TblCgyoeModel> GetViewOERequestById(int id)
        {
            ClassConfig classConfig = new ClassConfig();
            List<TblCgyoeModel> listOfOERequest = new List<TblCgyoeModel>();
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
                    listOfOERequest.Add(new TblCgyoeModel
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
                        //Attachment = (dr["Attachment"] is not DBNull) ? (byte[])dr["Attachment"] : null,
                        Timestamp = (dr["Timestamp"] is not DBNull) ? Convert.ToDateTime(dr["Timestamp"]) : null,

                    });//list
                }//foreach
            }//using
            return listOfOERequest;
        }//GetViewOERequest


        /*UPDATE===========================================================================================================================*/
        public bool UpdateRequest(int id, TblCgyoeModel request)
        {
            ClassConfig configclass = new();
            int i = 0;
            ClassConfig classConfig = new ClassConfig();
            List<TblCgyoeModel> listOfOERequest = new List<TblCgyoeModel>();
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

                connection.Open();
                i = command.ExecuteNonQuery();
                connection.Close();
                if (i > 0)
                { 
                    return true; 
                }
                else 
                { 
                    return false; 
                }
            }//using

        }//UpdateRequest

        /*DELETE===========================================================================================================================*/
        public string Delete(int id)
        {
            string username = configclass.username();
            string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";
            string ? result = "";
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
        public bool createProduct(TblCgyoeModel request)
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
                command.Parameters.AddWithValue("@GSTIncluded", request.Gstincluded);
                command.Parameters.AddWithValue("@Budgeted", request.Budgeted);
                command.Parameters.AddWithValue("@AutoApproved", request.AutoApproved);
                //command.Parameters.AddWithValue("@Request", request.Request);
                if (request.Request != null) { command.Parameters.AddWithValue("@Request", request.Request); } else { command.Parameters.AddWithValue("@Request", DBNull.Value); };
                command.Parameters.AddWithValue("@PurchaseDate", request.PurchaseDate);
                command.Parameters.AddWithValue("@ApprovedBy", request.ApprovedBy);
                command.Parameters.AddWithValue("@Status", request.Status);
                //command.Parameters.AddWithValue("@Reason", request.Reason);
                if (request.Reason != null) { command.Parameters.AddWithValue("@Reason", request.Reason); } else { command.Parameters.AddWithValue("@Reason", DBNull.Value); };
                connection.Open();
                i = command.ExecuteNonQuery();
                connection.Close();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }//using
        }//createProduct



        /*DROP DOWN LISTS ===========================================================================================================================*/
        public List<SelectListItem> BudgetList()
        {
            List<SelectListItem> Items = new List<SelectListItem>();
            SelectListItem item1 = new SelectListItem() { Text = "Not Budgeted", Value = "false", Selected = true };
            SelectListItem item2 = new SelectListItem() { Text = "Budgeted", Value = "true", Selected = false };
            Items.Add(item1);
            Items.Add(item2);
            return Items;
        }
        public List<SelectListItem> AutoApproveList()
        {
            List<SelectListItem> autoApproved = new List<SelectListItem>();
            SelectListItem autoApproved1 = new SelectListItem() { Text = "Not AutoApproved", Value = "false", Selected = true };
            SelectListItem autoApproved2 = new SelectListItem() { Text = "AutoApproved", Value = "true", Selected = false };
            autoApproved.Add(autoApproved1);
            autoApproved.Add(autoApproved2);
            return autoApproved;
        }
        public List<SelectListItem> StatusList()
        {
            List<SelectListItem> status = new List<SelectListItem>();
            SelectListItem status1 = new SelectListItem() { Text = "Not Approved", Value = "Not Approved", Selected = true };
            SelectListItem status2 = new SelectListItem() { Text = "Approved", Value = "Approved", Selected = false };
            status.Add(status1);
            status.Add(status2);
            return status;
        }
        public List<SelectListItem> GstList()
        {
            List<SelectListItem> gstInc = new List<SelectListItem>();
            SelectListItem gstInc1 = new SelectListItem() { Text = "GST Not Inc", Value = "false", Selected = true };
            SelectListItem gstInc2 = new SelectListItem() { Text = "GST Inc", Value = "true", Selected = false };

            gstInc.Add(gstInc1);
            gstInc.Add(gstInc2);

            return gstInc;
        }


        //APPROVAL SECTION=======================================================================================================================
        /*GET APPROVAL REQUEST=================================================================================================================*/
        public List<TblCgyoeModel> GetViewApproverOERequest(string id)
        {
            ClassConfig classConfig = new ClassConfig();
            List<TblCgyoeModel> listOfOERequest = new List<TblCgyoeModel>();
            string username = configclass.username();
            if (id == null) { id = "All"; };
            string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(config))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spr_CGYGetApproverOEStatus";
                command.Parameters.AddWithValue("@RequestedBy", username);
                command.Parameters.AddWithValue("@Status", id);
                SqlDataAdapter sqlda = new SqlDataAdapter(command);
                DataTable dtOE = new DataTable();
                connection.Open();
                sqlda.Fill(dtOE);
                connection.Close();
                foreach (DataRow dr in dtOE.Rows)
                {
                    listOfOERequest.Add(new TblCgyoeModel
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
                        //Budgeted = dr["Budgeted"] is DBNull ? (bool?) null: (bool)dr["Budgeted"],
                        //AutoApproved = dr["AutoApproved"] is DBNull ? (bool?) null: (bool)dr["AutoApproved"],
                        Request = (dr["Request"] is not DBNull) ? dr["Request"].ToString() : null,
                        PurchaseDate = Convert.ToDateTime(dr["PurchaseDate"]),
                        ApprovedBy = (dr["ApprovedBy"] is not DBNull) ? dr["ApprovedBy"].ToString() : null,
                        ApprovedDate = (dr["ApprovedDate"] is not DBNull) ? Convert.ToDateTime(dr["ApprovedDate"]) : null,
                        Status = (dr["Status"] is not DBNull) ? dr["Status"].ToString() : null,
                        Reason = (dr["Reason"] is not DBNull) ? dr["Reason"].ToString() : null,
                        //Attachment = (dr["Attachment"] is not DBNull) ? (byte[])dr["Attachment"] : null,
                        Timestamp = (dr["Timestamp"] is not DBNull) ? Convert.ToDateTime(dr["Timestamp"]) : null,

                    });//list
                }//foreach
            }//using
            return listOfOERequest;
        }//GetViewOERequest

        /*GET REQUEST BY ID===========================================================================================================================*/
        public List<TblCgyoeModel> GetViewOEById(int id)
        {
            ClassConfig classConfig = new ClassConfig();
            List<TblCgyoeModel> listOfOERequest = new List<TblCgyoeModel>();
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
                    listOfOERequest.Add(new TblCgyoeModel
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
                        //Attachment = (dr["Attachment"] is not DBNull) ? (byte[])dr["Attachment"] : null,
                        Timestamp = (dr["Timestamp"] is not DBNull) ? Convert.ToDateTime(dr["Timestamp"]) : null,

                    });//list
                }//foreach
            }//using
            return listOfOERequest;
        }//GetViewOERequest

        /*APPROVE===========================================================================================================================*/
        public bool ApproveRequest(int id, TblCgyoeModel request)
        {
            ClassConfig configclass = new();
            int i = 0;
            ClassConfig classConfig = new ClassConfig();
            List<TblCgyoeModel> listOfOERequest = new List<TblCgyoeModel>();
            string username = configclass.username();
            string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(config))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spr_CGYApproveOE";

                command.Parameters.AddWithValue("@RequestId", request.RequestId);
                if (request.Request != null) { command.Parameters.AddWithValue("@Request", request.Request); } else { command.Parameters.AddWithValue("@Request", DBNull.Value); };
                if (request.Reason != null) { command.Parameters.AddWithValue("@Reason", request.Reason); } else { command.Parameters.AddWithValue("@Reason", DBNull.Value); };
                //if (request.ApprovedDate != null) { command.Parameters.AddWithValue("@ApprovedDate", request.ApprovedDate); } else { command.Parameters.AddWithValue("@ApprovedDate", DBNull.Value); };
                if (request.Status != null) { command.Parameters.AddWithValue("@Status", request.Status); } else { command.Parameters.AddWithValue("@Status", DBNull.Value); };
                
                connection.Open();
                i = command.ExecuteNonQuery();
                connection.Close();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }//using
        }//UpdateRequest

    }//class
}//namespace
