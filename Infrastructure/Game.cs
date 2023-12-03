using ProgazzGame.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgazzGame.Infrastructure
{
    public class Game : IGame
    {
        private readonly INumberGenerator numberGenerator;
        private readonly IGuesserPlayer guesser;

        public Game(INumberGenerator numberGenerator, IGuesserPlayer guesser)
        {
            this.numberGenerator = numberGenerator;
            this.guesser = guesser;
        }

        public string Name => "Угадай число";
        public string Description => "Игра в которой генерируется слуйчайно число" +
                                     "и игрок должен его отгадать";
        public string HelloText => "Добро пожаловать в игру \"Угадай число\"!";

        public void Play()
        {
            Console.WriteLine(HelloText);

            Console.Write("Введите минимальное число в диапазоне:");
            int minNumber = int.Parse(Console.ReadLine());

            Console.Write("Введите максимальное число в диапазоне:");
            int maxNumber = int.Parse(Console.ReadLine());

            int numberToGuess = numberGenerator.GenerateNumber(minNumber, maxNumber);

            Console.WriteLine($"Я сгенерировал число между {minNumber} и {maxNumber}. Попробуйте угадать его!");

            guesser.GuessNumber(numberToGuess);
        }
    }
}
