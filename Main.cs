namespace TBTBBG;

public abstract class Program
{
    private static void Main(string[] args)
    {
        Character.NameChar();
        Character.GetRace();
        Character.GetStats();
        Character.RecClass(Character.SStr, Character.SDex, Character.SInt,Character.SWis, Character.SCha);
        Character.SelectClass();
        Character.DisplayCharacter();

        Battle.Combat();
    }
}
