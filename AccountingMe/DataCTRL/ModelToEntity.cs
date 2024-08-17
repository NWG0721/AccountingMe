using AccountingMe.Models;
using AccountingMe.DataLayer.Entites;

namespace AccountingMe.DataCTRL
{
	public static class ModelToEntity
	{

		public static User UserToModel(AddUserModel uM)
		{
			if (String.IsNullOrEmpty(uM.Address))
			{
				uM.Address = "ندارد";
			}
			if (String.IsNullOrEmpty(uM.Email))
			{
				uM.Email = "ندارد";
			}
			if (String.IsNullOrEmpty(uM.Mobile))
			{
				uM.Email = "09**-***-****";
			}
			if (String.IsNullOrEmpty(uM.Image))
			{
				uM.Image = "NoPicteredPerson.png";
			}

			var _user = new User()
			{
				Id = uM.Id,
				Name = uM.Name,
				Address = uM.Address,
				Email = uM.Email,				
				Image = uM.Image,
				Mobile = uM.Mobile

			};

			return _user;
		}

		public static AddUserModel ModelToUser(User user)
		{
			var _userModel = new AddUserModel()
			{
				Id = user.Id,
				Name = user.Name,
				Address = user.Address,
				Email = user.Email,
				Image = user.Image,
				Mobile = user.Mobile

			};

			return _userModel;
		}

	}
}
