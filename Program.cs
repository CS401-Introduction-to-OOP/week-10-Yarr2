
using System.Reflection.Metadata.Ecma335;

namespace Practice10;

class Program
{
    static void Main(string[] args)
    {
        // creating and adding characters and events to collection
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
        // end of adding
        bool running = true;
        while (running)
        {
            Console.Write("Input your command > ");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "quit":
                {
                    running = false;
                    break;
                }
                case "help":
                {
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!HELP!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("\n This is user friendly way of showing all avaliable commands here \n");
                    Console.WriteLine("help - shows this text to you\n");
                    Console.WriteLine("quit - to quit program");
                    Console.WriteLine("filterByRole - after it you need to type some role out of Dwarf,Bard,Elf,Healer,Warrior and it will get you all characters with such role");
                    Console.WriteLine("in case your role would not be in avaliable roles it will abort command");
                    Console.WriteLine("\nSortByMove - outputs sorted events based on move when they will be done\n");
                    Console.WriteLine("GetSTEvents - after this command you will need to input type of event you want to find and ");
                    Console.WriteLine("output will be all such events sorted by ChangeOfCharacteristic parameter\n");
                    break;
                }
                case "filterByRole": // for yield showcase
                {
                    Console.Write("Input role >");
                    string role = Console.ReadLine();
                    if (Role.TryParse(role, out Role newRole))
                    {
                        foreach (var character in party.FilterByRole(newRole))
                        {
                            Console.WriteLine(character);
                        }

                        break;
                    }
                    Console.WriteLine("Incorrect role name, aborting command");
                    break;
                }
                case "SortByMove":
                {
                    foreach (var someEvent in eventLog.SortByMove())
                    {
                        Console.WriteLine(someEvent);
                    }
                    break;
                }
                case "GetSTEvents": // for LINQ showcase
                {
                    Console.Write("Input event type >");
                    string eventType = Console.ReadLine();
                    foreach (var someEvent in eventLog.GetSpecificSortedEvents(eventType))
                    { 
                        Console.WriteLine(someEvent);
                    }
                    break;
                }
                

            }
            
        }
        
    }  
}