using MeterReadingProject.Models;
using System.Collections.Generic;

namespace MeterReadingProject.Repository
{
    public interface IEmployeeRL
    {
        public EmployeeRegistrationModel Registration(EmployeeRegistrationModel employee);
		public EmployeeRegistrationModel UserLogin(LoginModel loginModel);

		public IEnumerable<AddMetersModel> GetAllMeters();

        public MetersReadingData EnterMetersReading(MetersReadingData enterMetersReadings);
        public MetersReadingData UpdateMeterReading(MetersReadingData enterMetersReadings);
        public IEnumerable<MetersReadingData> GetAllMetersReadings(string branch_name);
        //public IEnumerable<MetersReadingData> GetAllMetersReadings(string BranchName1);
        public IEnumerable<MetersReadingData> GetAllMetersReading();
        public IEnumerable<MetersReadingData> ShowReport(string BranchName1, int MeterName);

        public IEnumerable<MetersReadingData> ShowReport1(int MeterName);

    }
}
