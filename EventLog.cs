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


    public IEnumerator<Event> GetEnumerator()
    {
        return _events.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}