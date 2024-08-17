using System.ComponentModel.DataAnnotations;

namespace AccountingMe.Models
{
	public class AddUserModel
	{
		public int Id { get; set; }

		[Required(AllowEmptyStrings = false,ErrorMessage ="اسم خالیه گلم")]
		[Display(Name="نام")]
		public string Name { get; set; }

		[Required(AllowEmptyStrings = true)]
		[Display(Name = "شماره تلفن")]
		public string Mobile { get; set; }

		[Required(AllowEmptyStrings = true)]
		[Display(Name = "ایمیل")]
		[RegularExpression("/^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$/g",ErrorMessage ="ایمیلت درست نیست")]
		public string Email { get; set; }

		[Required(AllowEmptyStrings = true)]
		[Display(Name = "آدرس")]
		public string Address { get; set; }

		[Required(AllowEmptyStrings = true)]
		[Display(Name = "عکس نمایه")]
		public string Image { get; set; }
	}
}
