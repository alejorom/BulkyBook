using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
	public class CoverTypeController : Controller
	{
		private readonly IUnitOfWork _unitOfWok;

		public CoverTypeController(IUnitOfWork unitOfWork)
		{
			_unitOfWok = unitOfWork;
		}
		public IActionResult Index()
		{
			IEnumerable<CoverType> CoverTypeList = _unitOfWok.CoverType.GetAll();
			return View(CoverTypeList);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(CoverType coverType)
		{
			if (ModelState.IsValid)
			{
				_unitOfWok.CoverType.Add(coverType);
				_unitOfWok.Save();
				TempData["Success"] = "CoverType created successfully!";
				return RedirectToAction("Index");
			}
			return View(coverType);
		}

		public IActionResult Edit(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			var coverType = _unitOfWok.CoverType.GetFirstOrDefault(u => u.Id == id);
			if (coverType == null)
			{
				return NotFound();
			}

			return View(coverType);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(CoverType coverType)
		{
			if (ModelState.IsValid)
			{
				_unitOfWok.CoverType.Update(coverType);
				_unitOfWok.Save();
				TempData["Success"] = "CoverType updated successfully!";
				return RedirectToAction("Index");
			}
			return View(coverType);
		}

		public IActionResult Delete(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			var coverType = _unitOfWok.CoverType.GetFirstOrDefault(u => u.Id == id);
			if (coverType == null)
			{
				return NotFound();
			}

			return View(coverType);
		}

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public IActionResult DeletePost(int? id)
		{
			var coverType = _unitOfWok.CoverType.GetFirstOrDefault(u => u.Id == id);
			if (coverType == null)
			{
				return NotFound();
			}
			_unitOfWok.CoverType.Remove(coverType);
			_unitOfWok.Save();
			TempData["Success"] = "CoverType deleted successfully!";
			return RedirectToAction(nameof(Index));
		}
	}
}
