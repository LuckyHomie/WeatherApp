using System;
using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Models
{
	public class User
	{
		public int Id;
		public int RoleId { get; set; }
		public string Name { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public string EmailAddress { get; set; }
		[DataType(DataType.Date)]
		public DateTime RegistrationDate { get; set; }
	}
}

