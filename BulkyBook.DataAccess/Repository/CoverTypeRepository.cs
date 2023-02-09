using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private ApplicationDBContext _context;

        public CoverTypeRepository(ApplicationDBContext context) : base(context)
        {
			_context = context;
        }

        public void Update(CoverType obj)
        {
			_context.CoverTypes.Update(obj);
        }
    }
}
