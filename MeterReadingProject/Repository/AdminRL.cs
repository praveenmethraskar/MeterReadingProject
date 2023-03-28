using MeterReadingProject.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;

namespace MeterReadingProject.Repository
{
    public class AdminRL : IAdminRL
    {

        string dbpath = "Data Source=DESKTOP-6SI061U;Initial Catalog=MeterReading;Integrated Security=True";

        SqlConnection sqlConnection;
        public AdminRL(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }


        public string AdminLogin(LoginModel loginModel)
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
                        string query = "SELECT users_id FROM users WHERE mail = '" + result + "'";
                        SqlCommand cmd = new SqlCommand(query, sqlConnection);
                        var EmployeeId = cmd.ExecuteScalar();
                        var token = GenerateSecurityToken(loginModel.Email, EmployeeId.ToString());
                        return token;
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


        private string GenerateSecurityToken(string Email, string users_id)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[] {
                new Claim(ClaimTypes.Role,"Admin"),
                new Claim(ClaimTypes.Email,Email),
                new Claim("users_id",users_id.ToString())
            };
            var token = new JwtSecurityToken(Configuration["JWT:key"],
              Configuration["JWT:key"],
              claims,
              expires: DateTime.Now.AddMinutes(60),
              signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}
