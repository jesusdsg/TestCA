namespace Domain.Primitives;


public abstract class AggregateRoot
{
    private readonly List<DomainEvent> _domaintEvents = new();

    //Get the collections of events in domain
    public ICollection<DomainEvent> GetDomainEvents() => _domaintEvents;

    //Run Domain events
    protected void Raise(DomainEvent domainEvent)
    {
        _domaintEvents.Add(domainEvent);
    }
}