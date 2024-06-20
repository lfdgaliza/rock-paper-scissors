using ConsoleApp.Strategies.Abstract;

namespace ConsoleApp;
public class Player(string name)
{
    public string Name { get; } = name;
    public IStrategy? Strategy { get; set; }

    internal void SetStrategy(IStrategy strategy) => Strategy = strategy;
}
