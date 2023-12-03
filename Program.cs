using ProgazzGame.Infrastructure;
using ProgazzGame.Infrastructure.Interfaces;

class Program
{
    static void Main()
    {
        INumberGenerator numberGenerator = new RandomNumberGenerator();
        IGuesserPlayer guesser = new UserGuesser(maxAttempts: 5);

        IGame game = new Game(numberGenerator, guesser);

        game.Play();

        Console.ReadLine();
    }
}