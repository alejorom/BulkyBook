using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDBContext _context;

        public ApplicationUserRepository(ApplicationDBContext context) : base(context)
        {
			_context = context;
        }

    }
}
