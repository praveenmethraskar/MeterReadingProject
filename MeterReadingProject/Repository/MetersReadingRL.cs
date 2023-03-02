using MeterReadingProject.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

namespace MeterReadingProject.Repository
{
	public class MetersReadingRL : IMetersReadingRL
	{
		string dbpath = "Data Source=DESKTOP-6SI061U;Initial Catalog=MeterReading;Integrated Security=True";

		SqlConnection sqlConnection;

		public MetersReadingRL(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		public IConfiguration Configuration { get; }


		public MetersReadingData EnterMetersReading(MetersReadingData enterMetersReadings)
		{
			try
			{
				sqlConnection = new SqlConnection(dbpath);
				SqlCommand command = new SqlCommand("SP_MetersReading", sqlConnection);
				command.CommandType = System.Data.CommandType.StoredProcedure;

				sqlConnection.Open();

				command.Parameters.AddWithValue("@Mdate", enterMetersReadings.date);
				command.Parameters.AddWithValue("@MeterName", enterMetersReadings.MeterName);
                command.Parameters.AddWithValue("@Reading", enterMetersReadings.MeterReading);

                command.ExecuteNonQuery();
				return enterMetersReadings;
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
