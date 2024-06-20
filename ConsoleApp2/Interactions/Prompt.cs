namespace ConsoleApp.Interactions;

public static class Prompt
{
    public static void AskUser(string prompt, IReadOnlyCollection<MenuItem> menuItems)
    {
        Console.Clear();
        Console.WriteLine(prompt);
        Console.Write(string.Join(", ", menuItems));
        Console.Write(": ");

        var actionDictionary = menuItems
            .SelectMany(item => item.KeyChars.Select(c => new { KeyChar = c, item.Action }))
            .ToDictionary(pair => pair.KeyChar, pair => pair.Action);

        ConsoleKeyInfo escolha;

        do escolha = Console.ReadKey(true);
        while (!actionDictionary.ContainsKey(escolha.KeyChar));

        Console.Clear();

        actionDictionary[escolha.KeyChar]();
    }
}