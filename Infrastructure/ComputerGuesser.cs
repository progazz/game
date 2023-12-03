using ProgazzGame.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgazzGame.Infrastructure
{
    public class ComputerGuesser : IGuesserPlayer
    {
        private int attemptsLeft;

        public ComputerGuesser(int attemptsLeft)
        {
            this.attemptsLeft = attemptsLeft;
        }

        public void GuessNumber(int numberToGuess)
        {
            var start = 0;
            var end = int.MaxValue;

            while (attemptsLeft > 0)
            {

                Random random = new Random();
                int competerNumber = random.Next(start, end);

                if (competerNumber == numberToGuess)
                {
                    Console.WriteLine("Компьютер угадал число");
                    return;
                }
                else
                {
                    if(competerNumber < numberToGuess)
                        end = numberToGuess;
                    else
                        start = numberToGuess;

                    attemptsLeft--;
                    Console.WriteLine($"Осталось попыток: {attemptsLeft}");
                }

            }

            Console.WriteLine($"Извините, у вас закончились попытки. Правильным номером было {numberToGuess}.");
        }


    }
}
