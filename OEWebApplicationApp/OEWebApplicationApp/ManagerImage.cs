using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting.Internal;
using OEWebApplicationApp.Models;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OEWebApplicationApp
{
    public class ManagerImage
    {
        // TODO: insert proper connection string

        //GET ALL IMAGES PER REQUEST ID============================================================================================================
        public List<ImageModel> GetImages(string id)
        {
            List<ImageModel> listOfOERequest = new List<ImageModel>();
            string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(config))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spr_GetImages";
                command.Parameters.AddWithValue("@RequestId", id);
                SqlDataAdapter sqlda = new SqlDataAdapter(command);
                DataTable dtOE = new DataTable();
                connection.Open();
                sqlda.Fill(dtOE);
                connection.Close();
                foreach (DataRow dr in dtOE.Rows)
                {
                    listOfOERequest.Add(new ImageModel
                    {
                        RequestId = Convert.ToInt32(dr["RequestId"]),
                        FileName = (dr["FileName"] is not DBNull) ? dr["FileName"].ToString() : null,
                        Path = (dr["Path"] is not DBNull) ? dr["Path"].ToString() : null,
                        Location = (dr["Location"] is not DBNull) ? dr["Location"].ToString() : null,
                        InsertDate = Convert.ToDateTime(dr["InsertDate"]),

                    });//list
                }//foreach
            }//using
            return listOfOERequest;
        }//GetImages
         //GET ONE IMAGES PER FILE NAME============================================================================================================
        public List<ImageModel> GetImage(string id)
        {
            List<ImageModel> listOfOERequest = new List<ImageModel>();
            string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(config))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spr_GetImage";
                command.Parameters.AddWithValue("@FileName", id);
                SqlDataAdapter sqlda = new SqlDataAdapter(command);
                DataTable dtOE = new DataTable();
                connection.Open();
                sqlda.Fill(dtOE);
                connection.Close();
                foreach (DataRow dr in dtOE.Rows)
                {
                    listOfOERequest.Add(new ImageModel
                    {
                        RequestId = Convert.ToInt32(dr["RequestId"]),
                        FileName = (dr["FileName"] is not DBNull) ? dr["FileName"].ToString() : null,
                        Path = (dr["Path"] is not DBNull) ? dr["Path"].ToString() : null,
                        Location = (dr["Location"] is not DBNull) ? dr["Location"].ToString() : null,
                        InsertDate = Convert.ToDateTime(dr["InsertDate"]),

                    });//list
                }//foreach
            }//using
            return listOfOERequest;
        }//GetImages

        //UPDATE IMAGE===========================================================================================================================
        public bool UpdateImageTbl(string filename, string path, ImageModel model)
        {

            string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";
            int i = 0;
            using (SqlConnection connection = new SqlConnection(config))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spr_UploadImages";
                string fileNameWithPath = path;
                command.Parameters.AddWithValue("@RequestId", model.RequestId);
                if (filename != null) { command.Parameters.AddWithValue("@FileName", filename); } else { command.Parameters.AddWithValue("@FileName", DBNull.Value); };
                if (fileNameWithPath != null) { command.Parameters.AddWithValue("@Path", fileNameWithPath); } else { command.Parameters.AddWithValue("@Path", DBNull.Value); };
                if (model.Location != null) { command.Parameters.AddWithValue("@Location", model.Location); } else { command.Parameters.AddWithValue("@Location", DBNull.Value); };

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
        }//UpdateImageTbl

        //DELETE IMAGE========================================================================================================================

        public string DeleteImage(string filePath, ImageModel imageModel)
        {
            string value = "Success";
            if (filePath != null) 
            {
                //DELETE FILE FROM SYSTEM===================================
                File.Delete(filePath);

                //DELETE FILE FROM INDEX====================================
                string? result = "";
                string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(config))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spr_DeleteImage";
                    if (filePath != null) { command.Parameters.AddWithValue("@FileName", imageModel.FileName); } else { command.Parameters.AddWithValue("@FileName", DBNull.Value); };
                    command.Parameters.Add("@OutputMessage", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    connection.Open();
                    command.ExecuteNonQuery();
                    result = command.Parameters["@OutputMessage"].Value.ToString();
                    connection.Close();
                }//using
                return value;
            }
            else
            {
                value = "Failure";
                return value;
            }
        }
    }//class
}//namespace
