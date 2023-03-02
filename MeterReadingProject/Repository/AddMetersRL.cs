using MeterReadingProject.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

namespace MeterReadingProject.Repository
{
    public class AddMetersRL : IAddMetersRL
    {
        string dbpath = "Data Source=DESKTOP-6SI061U;Initial Catalog=MeterReading;Integrated Security=True";

        SqlConnection sqlConnection;

        public AddMetersRL(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public AddMetersModel AddMeters(AddMetersModel addMeters)
        {
            try
            {
                sqlConnection = new SqlConnection(dbpath);
                SqlCommand command = new SqlCommand("SP_AddMeters", sqlConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                sqlConnection.Open();
                
                command.Parameters.AddWithValue("@MeterName", addMeters.MeterName);
                command.Parameters.AddWithValue("@Branch_id", addMeters.BranchName);
                command.Parameters.AddWithValue("@Region_id", addMeters.RegionName);
                command.Parameters.AddWithValue("@cluster_id", addMeters.ClusterName);

                command.ExecuteNonQuery();
                return addMeters;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

    }
}
