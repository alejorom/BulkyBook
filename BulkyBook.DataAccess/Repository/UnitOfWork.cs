using BulkyBook.DataAccess.Repository.IRepository;

namespace BulkyBook.DataAccess.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private ApplicationDBContext _context;

		public UnitOfWork(ApplicationDBContext context)
		{
			_context = context;
			Category = new CategoryRepository(_context);
			CoverType = new CoverTypeRepository(_context);
		}

		public ICategoryRepository Category { get; private set; }

		public ICoverTypeRepository CoverType { get; private set; }

		public void Save()
		{
			_context.SaveChanges();
		}
	}
}
