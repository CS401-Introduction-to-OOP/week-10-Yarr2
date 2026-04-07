namespace Practice10;

public enum Role
{
    Warrior,
    Bard,
    Healer,
    Elf,
    Dwarf
}
public enum State
{
    Active,
    Passive
}

public class Character
{
    public string Name { get; }
    public Role Role { get; }
    public int Level { get; }
    public uint HitPoints { get; }
    public double AmountGold { get; }
    public State State { get; }

    public Character(string name, Role role, uint hitPoints, double amountGold, State state =  State.Active, int level = 1)
    {
        Name = name;
        Role = role;
        HitPoints = hitPoints;
        AmountGold = amountGold;
        State = state;
    }
    

}