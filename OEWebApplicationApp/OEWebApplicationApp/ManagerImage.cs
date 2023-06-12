using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting.Internal;
using OEWebApplicationApp.Models;
using System.ComponentModel.DataAnnotations;
using System.Data;
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
                        Path = (dr["Path"] is not DBNull) ? dr["Path"].ToString() : null,
                        Location = (dr["Location"] is not DBNull) ? dr["Location"].ToString() : null,
                        InsertDate = Convert.ToDateTime(dr["InsertDate"]),

                    });//list
                }//foreach
            }//using
            return listOfOERequest;
        }//GetImages

        public bool UpdateImageTbl(string path, ImageModel model)
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

    }//class
}//namespace
