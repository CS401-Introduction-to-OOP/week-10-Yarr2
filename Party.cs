using System.Collections;

namespace Practice10;

public class Party: IEnumerable<Character>
{
    private List<Character> _characters = new List<Character>();
    
    public void AddCharacter(Character character)
    {
        _characters.Add(character);
    }

    public void RemoveCharacter(Character character)
    {
        _characters.Remove(character);
    }

    public IEnumerable<Character> GetActive()
    {
        foreach (var character in _characters)
        {
            if (character.State == State.Active) yield return character;
        }
    }
        
    
    public IEnumerator<Character> GetEnumerator()
    {
        foreach (var character in _characters)
        { 
            yield return character;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}