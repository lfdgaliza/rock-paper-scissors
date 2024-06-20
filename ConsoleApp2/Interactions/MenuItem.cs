namespace ConsoleApp.Interactions;
public record MenuItem(IReadOnlyCollection<char> KeyChars, string Description, Action Action)
{
    public override string ToString() => KeyChars.First() + " - " + Description;
}