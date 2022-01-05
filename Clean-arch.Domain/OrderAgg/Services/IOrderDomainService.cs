namespace Clean_arch.Domain.OrderAgg.Services
{
    public interface IOrderDomainService
    {
        bool IsProductNotExsist(long productId);
    }
}
