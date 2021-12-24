namespace Clean_arch.Application.Orders.DTOs;

public class OrderDto
{
    public long Id { get;  set; }
    public long ProductId { get;  set; }
    public int Count { get;  set; }
    public int Price { get;  set; }
}
public class AddOrderDto
{
    public long ProductId { get;  set; }
    public int Count { get;  set; }
    public int Price { get;  set; }
}
public class FinallyOrderDto
{
    public long OrderId { get; set; }

}