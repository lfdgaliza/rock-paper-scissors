namespace ConsoleApp.Strategies.Abstract;
public interface IStrategy
{
    bool Beats(IStrategy strategy);
}
