using ConsoleApp.Strategies.Abstract;

namespace ConsoleApp.Strategies;
public class Rock : IStrategy
{
    public bool Beats(IStrategy strategy) => strategy is Scissors;
}
