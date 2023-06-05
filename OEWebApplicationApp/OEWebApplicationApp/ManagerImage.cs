using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting.Internal;
using OEWebApplicationApp.Models;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace OEWebApplicationApp
{
    public class ManagerImage
    {
        public bool UpdateRequest(string id, ImageModel request)
        {
            ClassConfig configclass = new();
            int i = 0;
            ClassConfig classConfig = new ClassConfig();
            List<ImageModel> listOfOERequest = new List<ImageModel>();
            string username = configclass.username();
            string config = @"Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True";

            string imagepath = request.ImageData.ToString();
            byte[] image = request.ImageData;
            string fileext = Path.GetFileName(imagepath);
            string path = Path.GetFullPath(imagepath);
            byte[] fileUpload = request.ImageData;

            using (SqlConnection connection = new SqlConnection(config))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spr_UploadImages";

                command.Parameters.AddWithValue("@RequestId", request.RequestId);
                command.Parameters.AddWithValue("@Name", request.Name);
                command.Parameters.AddWithValue("@Size", request.Size);
                command.Parameters.AddWithValue("@ImageData", request.ImageData);

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
