
using System.Reflection.Metadata.Ecma335;

namespace Practice10;

class Program
{
    static void Main(string[] args)
    {
        var character1 = new Character("Yarema",Role.Dwarf,200,900,level:3);
        var character2 = new Character("Rostik",Role.Bard,60,100);
        var character3 = new Character("Anna",Role.Elf,120,1200);
        var character4 = new Character("Grisha",Role.Healer,100,1500,level:6);
        var character5 = new Character("Petro",Role.Dwarf,200,600,state:State.Passive);

        
        var party = new Party();
        party.AddCharacter(character1);
        party.AddCharacter(character2);
        party.AddCharacter(character3);
        party.AddCharacter(character4);
        party.AddCharacter(character5);
        
        
        var event1 = new Event(4, "Kill monster", "Fight", 10);
        var event2 = new Event(1, "Help teammate", "Heal", 30);
        var event3 = new Event(3, "Steal black box", "Steal", -15);
        var event4 = new Event(1, "Steal sword", "Steal", 20);
        var event5 = new Event(8, "Help bard", "Heal", 10);

        var eventLog = new EventLog();
        eventLog.AddEvent(event1);
        eventLog.AddEvent(event2);
        eventLog.AddEvent(event3);
        eventLog.AddEvent(event4);
        eventLog.AddEvent(event5);
        
        // testing 'yield' methods 
        foreach (var character in party)// to get all active characters
        {
            Console.WriteLine(character.Name);
        }

        foreach (var someEvent in eventLog)
        {
            Console.WriteLine($"{someEvent.MoveNumber},{someEvent.TypeOfEvent}");
        }
        // testing linq methods
    }  
}