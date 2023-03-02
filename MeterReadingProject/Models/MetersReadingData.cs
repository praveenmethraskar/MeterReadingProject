using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace MeterReadingProject.Models
{
	public class MetersReadingData
	{
		
		public int id { get; set; }	
		public string date { get; set; } 
		 
         public int MeterName { get; set; }
		public string MeterName1 { get; set; }
		public string MeterReading { get; set; }

        public int BranchName { get; set; }
        public string BranchName1 { get;set; }

	}
}
