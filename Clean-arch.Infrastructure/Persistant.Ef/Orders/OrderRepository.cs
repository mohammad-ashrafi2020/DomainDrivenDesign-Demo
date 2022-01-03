using Clean_arch.Domain.Orders;
using Clean_arch.Domain.Orders.Repository;
using Microsoft.EntityFrameworkCore;

namespace Clean_arch.Infrastructure.Persistant.Ef.Orders
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Order order)
        {
            _context.Add(order);
        }

        public async Task<Order> GetById(long id)
        {
            return await _context.Orders.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(Order order)
        {
            _context.Update(order);
        }
    }
}
