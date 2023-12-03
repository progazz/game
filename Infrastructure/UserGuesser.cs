using ProgazzGame.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgazzGame.Infrastructure
{

    public class UserGuesser : IGuesserPlayer
    {
        private int attemptsLeft;

        public UserGuesser(int maxAttempts)
        {
            this.attemptsLeft = maxAttempts;
        }

        public void GuessNumber(int numberToGuess)
        {
            while (attemptsLeft > 0)
            {
                Console.Write("Введите свое число:");
                if (int.TryParse(Console.ReadLine(), out int userGuess))
                {
                    if (userGuess == numberToGuess)
                    {
                        Console.WriteLine("Поздравляю! Вы угадали с числом.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(userGuess < numberToGuess ? "Слишком маленькое. Пробовать снова." : "Слишком большое. Пробовать снова.");
                        attemptsLeft--;
                        Console.WriteLine($"Осталось попыток: {attemptsLeft}");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите действительный номер.");
                }
            }

            Console.WriteLine($"Извините, у вас закончились попытки. Правильным номером было {numberToGuess}.");
        }
    }
    }

