namespace Practice10;

public class Event
{
    public int MoveNumber { get; }
    public string Description { get; }
    public string TypeOfEvent { get; }
    public string? ChangeOfCharacteristic { get; }

    public Event(int moveNumber, string description, string typeOfEvent, string changeOfCharacteristic)
    {
        MoveNumber = moveNumber;
        Description = description;
        TypeOfEvent = typeOfEvent;
        ChangeOfCharacteristic = changeOfCharacteristic;
    }
}