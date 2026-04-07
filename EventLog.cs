using System.Collections;

namespace Practice10;

public class EventLog : IEnumerable<Event>
{
    private List<Event> _events = new List<Event>();

    public void AddEvent(Event inputEvent)
    {
        _events.Add(inputEvent);
    }

    public void RemoveCharacter(Event inputEvent)
    {
        _events.Remove(inputEvent);
    }

    public IEnumerable<Event> SortByMove()
    {
        return _events.OrderBy(n => n.MoveNumber);
    }
    public IEnumerable<Event> GetSpecificSortedEvents(string eventType)
    {
        return _events
            .Where(n => n.TypeOfEvent == eventType)
            .OrderBy(n => n.ChangeOfCharacteristic);
    }

    public IEnumerable<Event> GetEventsOfType(string type)
    {
        foreach (var someEvent in _events)
        {
            if (someEvent.TypeOfEvent == type) yield return someEvent;
        }
    }

    public IEnumerator<Event> GetEnumerator()
    {
        return _events.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}