using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
	public class CategoryRepository : Repository<Category>, ICategoryRepository
	{
		private ApplicationDBContext _context;

		public CategoryRepository(ApplicationDBContext context) : base(context)
		{
			_context = context;
		}

		public void Update(Category obj)
		{
			_context.Categories.Update(obj);
		}
	}
}
