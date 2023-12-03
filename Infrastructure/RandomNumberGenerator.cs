using ProgazzGame.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgazzGame.Infrastructure
{
    public class RandomNumberGenerator : INumberGenerator
    {
        public int GenerateNumber(int start, int end)
        {
            Random random = new Random();
            return random.Next(start, end + 1);
        }
    }
}
