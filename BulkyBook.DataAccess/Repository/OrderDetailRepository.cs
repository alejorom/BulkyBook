using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
	public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDBContext _context;

        public OrderDetailRepository(ApplicationDBContext context) : base(context)
        {
			_context = context;
        }


        public void Update(OrderDetail obj)
        {
			_context.OrderDetail.Update(obj);
        }
    }
}
