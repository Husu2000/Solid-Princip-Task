// See https://aka.ms/new-console-template for more information



public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        
    }
}

public class OrderProcessor
{
    private readonly ILogger _logger;
    public OrderProcessor(ILogger logger)
    {
        _logger = logger;
    }
    public void ProcessOrder(Order order)
    {
        
        _logger.Log("Order processed: " + order.Id);
    }
}
public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
}