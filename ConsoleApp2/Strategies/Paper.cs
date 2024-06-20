using ConsoleApp.Strategies.Abstract;

namespace ConsoleApp.Strategies;
public class Paper : IStrategy
{
    public bool Beats(IStrategy strategy) => strategy is Rock;
}
