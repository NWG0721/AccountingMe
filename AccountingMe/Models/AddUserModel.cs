using System.ComponentModel.DataAnnotations;

namespace AccountingMe.Models
{
	public class AddUserModel
	{
		public int Id { get; set; }

		[Required(AllowEmptyStrings = false,ErrorMessage ="اسم خالیه گلم")]
		[Display(Name="نام")]
		public string Name { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "شماره تلفن خالیه گلم")]
		[Display(Name = "شماره تلفن")]
		public string Mobile { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "ایمیل خالیه گلم")]
		[Display(Name = "ایمیل")]
		public string Email { get; set; }

		[Required(AllowEmptyStrings = false)]
		public string Address { get; set; }

		[Required(AllowEmptyStrings = true)]
		public string Image { get; set; }
	}
}
