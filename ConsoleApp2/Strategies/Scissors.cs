using ConsoleApp.Strategies.Abstract;

namespace ConsoleApp.Strategies;
public class Scissors : IStrategy
{
    public bool Beats(IStrategy strategy) => strategy is Paper;
}