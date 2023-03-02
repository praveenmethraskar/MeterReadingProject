using System.ComponentModel.DataAnnotations;

namespace MeterReadingProject.Models
{
	public class AddMetersModel
	{
		public int Meter_id { get; set; }

		[Required(ErrorMessage = "Required.")]
		public string MeterName { get; set; }

		[Required(ErrorMessage = "Required.")]
		public int BranchName { get; set; }

		[Required(ErrorMessage = "Required.")]
		public int RegionName { get; set; }

		[Required(ErrorMessage = "Required.")]
		public int ClusterName { get; set; }

    

    }

}
