namespace Practice10;

public class Event
{
    public int MoveNumber { get; }
    public string Description { get; }
    public string TypeOfEvent { get; }
    public int ChangeOfCharacteristic { get; }

    public Event(int moveNumber, string description, string typeOfEvent, int changeOfCharacteristic)
    {
        MoveNumber = moveNumber;
        Description = description;
        TypeOfEvent = typeOfEvent;
        ChangeOfCharacteristic = changeOfCharacteristic;
    }

    public override string ToString()
    {
        return $"Event of type {TypeOfEvent} executed at move {MoveNumber}, does {Description} and changes by {ChangeOfCharacteristic}";
    }
}