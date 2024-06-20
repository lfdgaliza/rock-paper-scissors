namespace ConsoleApp;
public class Game
{
    internal Player? Play(Player p1, Player p2)
    {
        if (p1.Strategy.GetType() == p2.Strategy.GetType())
            return null;

        if (p1.Strategy.Beats(p2.Strategy))
            return p1;

        return p2;
    }
}
