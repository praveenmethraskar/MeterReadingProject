using MeterReadingProject.Models;

namespace MeterReadingProject.Repository
{
    public interface IAdminRL
    {
        public string AdminLogin(LoginModel loginModel);
    }
}
