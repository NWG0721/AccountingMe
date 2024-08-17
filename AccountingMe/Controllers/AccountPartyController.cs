using DataLayer;
using DataLayer.Context;
using Humanizer;
using Microsoft.AspNetCore.Mvc;

namespace AccountingMe.Controllers
{
	[Route("Parties")]
	public class AccountPartyController : Controller
	{
		private AccountingAppDBContext _dbContext;
		private UnitOfWork _db;

		public AccountPartyController(AccountingAppDBContext dbContext)
		{
			_dbContext = dbContext;
			_db = new UnitOfWork(_dbContext);
		}


		public IActionResult Index()
		{
			var data = _db.UsersRepository.Select();
			return View(data);

		}

		[Route("Delete/{id}")]
		public IActionResult Delete(int id)
		{
			_db.UsersRepository.Delete(id);
			_db.Save();
			return View(nameof(Index));
		}
	}
}
