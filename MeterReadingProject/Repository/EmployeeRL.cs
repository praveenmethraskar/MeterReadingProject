using MeterReadingProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MeterReadingProject.Repository
{
    public class EmployeeRL : IEmployeeRL
    {
        string dbpath = "Data Source=DESKTOP-6SI061U;Initial Catalog=MeterReading;Integrated Security=True";

        SqlConnection sqlConnection;


        public EmployeeRL(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
		public List<AddMetersModel> meterlist = new List<AddMetersModel>();
        public List<MetersReadingData> meterreadings = new List<MetersReadingData>();
        //SqlDataReader reader;
        public EmployeeRegistrationModel Registration(EmployeeRegistrationModel employee)
        {
            try
            {
                sqlConnection = new SqlConnection(dbpath);
                SqlCommand command = new SqlCommand("SP_Register", sqlConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;


                sqlConnection.Open();

                // command.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                command.Parameters.AddWithValue("@emp_code", employee.Emp_Code);
                command.Parameters.AddWithValue("@emp_name", employee.Name);
                command.Parameters.AddWithValue("@mail", employee.Email);
                command.Parameters.AddWithValue("@password", employee.Password);
                command.Parameters.AddWithValue("@confirmpassword", employee.ConfirmPassword);
                command.Parameters.AddWithValue("@emp_designation", employee.Emp_designation);
                command.Parameters.AddWithValue("@Branch_id", employee.BranchName);
                command.Parameters.AddWithValue("@Region_id", employee.RegionName);
                command.Parameters.AddWithValue("@cluster_id", employee.ClusterName);
                command.Parameters.AddWithValue("@RoleId", employee.Role);

                command.ExecuteNonQuery();
                return employee;
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


        public EmployeeRegistrationModel UserLogin(LoginModel loginModel)
        {
            sqlConnection = new SqlConnection(dbpath);
            using (sqlConnection)
            {
                try
                {
                    SqlCommand command = new SqlCommand("EmployeeLogin", sqlConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    sqlConnection.Open();
                    command.Parameters.AddWithValue("@mail", loginModel.Email);
                    command.Parameters.AddWithValue("@password", loginModel.Password);

                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string query = "SELECT * FROM users inner join Branch on  users.Branch_id = Branch.id inner join tbl_Role on users.RoleId = tbl_Role.RoleId WHERE mail = '" + result + "'";
                        SqlCommand cmd = new SqlCommand(query, sqlConnection);
						SqlDataReader reader = cmd.ExecuteReader();
                            //var EmployeeId = cmd.ExecuteScalar();
						EmployeeRegistrationModel objregistration = new EmployeeRegistrationModel();
                        while(reader.Read())
                        {
                            objregistration.users_id = Convert.ToInt32(reader["users_id"]);
							objregistration.Email = reader["mail"].ToString();
                            objregistration.Password = reader["password"].ToString();
                            objregistration.BranchName = Convert.ToInt32(reader["Branch_id"]);
                            objregistration.Role = Convert.ToInt32(reader["RoleId"]);
                            objregistration.branch_name = reader["branch_name"].ToString();
                            objregistration.RoleName = reader["Role"].ToString();

                        }
                        //var token = GenerateSecurityToken(loginModel.Email, EmployeeId.ToString());
                        //return token;
                        return objregistration;
					}
                    else
                    {
                        return null;
                    }
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

        //private string GenerateSecurityToken(string Email, string users_id)
        //{
        //    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:key"]));
        //    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        //    var claims = new[] {
        //        new Claim(ClaimTypes.Role,"Employee"),
        //        new Claim(ClaimTypes.Email,Email),
        //        new Claim("users_id",users_id.ToString())
        //    };
        //    var token = new JwtSecurityToken(Configuration["JWT:key"],
        //      Configuration["JWT:key"],
        //      claims,
        //      expires: DateTime.Now.AddMinutes(60),
        //      signingCredentials: credentials);
        //    return new JwtSecurityTokenHandler().WriteToken(token);
        //}


		public IEnumerable<AddMetersModel> GetAllMeters()
		{
			sqlConnection = new SqlConnection(dbpath);
			try
			{
				SqlCommand command = new SqlCommand("GetAllMeters", sqlConnection);
				command.CommandType = System.Data.CommandType.StoredProcedure;

			    sqlConnection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.HasRows)
				{
					while (reader.Read())
					{
						meterlist.Add(new AddMetersModel
					    {
							Meter_id = Convert.ToInt32(reader["id"]),
							MeterName = reader["MeterName"].ToString(),
							BranchName = Convert.ToInt32(reader["Branch_id"]),
							RegionName = Convert.ToInt32(reader["Region_id"]),
							ClusterName = Convert.ToInt32(reader["cluster_id"]),
							
						});
					}
					return meterlist;
				}
				else
				{
					return null;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				sqlConnection.Close();
			}
		}

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
                command.Parameters.AddWithValue("@branchid", enterMetersReadings.BranchName);
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

        public MetersReadingData UpdateMeterReading(MetersReadingData enterMetersReadings)
        {
            try
            {
                sqlConnection = new SqlConnection(dbpath);
                SqlCommand command = new SqlCommand("UpdateItem", sqlConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                sqlConnection.Open();
                command.Parameters.AddWithValue("@id", enterMetersReadings.id);
                command.Parameters.AddWithValue("@Mdate", enterMetersReadings.date);
                command.Parameters.AddWithValue("@MeterName", enterMetersReadings.MeterName);
                command.Parameters.AddWithValue("@Reading", enterMetersReadings.MeterReading);
                command.Parameters.AddWithValue("@branchid", enterMetersReadings.BranchName);
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


        public IEnumerable<MetersReadingData> GetAllMetersReadings(string BranchName1)
        {
            
            sqlConnection = new SqlConnection(dbpath);
            try
            {
                SqlCommand command = new SqlCommand("GetAllMetersReadings", sqlConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                

                sqlConnection.Open();
                command.Parameters.AddWithValue("branch_name", BranchName1);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        meterreadings.Add(new MetersReadingData
                        {
                            id = Convert.ToInt32(reader["id"]),
                            date = reader["Mdate"].ToString(),
                            //MeterName = Convert.ToInt32(reader["MeterName"]),
                            MeterName1 = reader["MeterName"].ToString(),
                            MeterReading = reader["Reading"].ToString(),
                            BranchName1 = reader["branch_name"].ToString(),

                        });
                    }
                    return meterreadings;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

    }
}
