using ConsoleApp;
using ConsoleApp.Interactions;
using ConsoleApp.Strategies;

Prompt.AskUser("Bem vindo. Gostaria de jogar pedra, papel e tesoura?", [
    new (['s', 'S'], "Sim", SimHandler),
    new (['n', 'N'], "Não", () => Console.WriteLine("Ah, que pena. Adeus."))
]);


static void SimHandler()
{
    Console.Write("Nome: ");
    var p1 = new Player(Console.ReadLine());

    Prompt.AskUser("Muito bem. Faça sua escolha, e eu farei a minha.", [
        new (['1'], "Pedra", ()=> p1.SetStrategy(new Rock())),
        new (['2'], "Papel", ()=> p1.SetStrategy(new Paper())),
        new (['3'], "Tesoura", ()=> p1.SetStrategy(new Scissors()))
    ]);

    var p2 = new Player("Oswaldo");
    p2.SetStrategy(new Paper());

    var winner = new Game().Play(p1, p2);

    if (winner is null)
        Console.WriteLine("Empate!");
    else
        Console.WriteLine(winner.Name + " venceu!");
}
