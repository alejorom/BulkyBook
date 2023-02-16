using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
		private ApplicationDBContext _context;

		public CompanyRepository(ApplicationDBContext context) : base(context)
        {
			_context = context;
        }


        public void Update(Company obj)
        {
			_context.Companies.Update(obj);
        }
    }
}
