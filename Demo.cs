public class InvoceServices
{

    public void Remove( int invoceID)
    {
        using (var invoceRepository = new InvoiceREepository())
        {
            var removed = invoceRepository.Remove(invoceID);

            if (removed)
            {
                var notifier = new EmailNotifier();
                notifier.NotifyAdmin($"Invoice {invoceID} removed");
            }
            
        }
        
    }
    
}


public class InvoceServices : IInvoceServices
{
    private readonly IInvoceRepository _invoceRepository;
    private readonly INotifier _notifier;

    public InvoceServices (IInvoceRepository invoceRepository, INotifier notifier)
    {
        _invoceRepository = invoceRepository;
        _notifier = notifier;
    }

    public void Remove( int invoceID)
    {
        var removed = _invoceRepository.Remove(invoceID);
        
        if (removed)
        {
            _notifier.NotifyAdmin($"Invoice {invoceID} removed");
        }
    }

}


