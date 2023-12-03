using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgazzGame.Infrastructure.Interfaces
{
    public interface INumberGenerator
    {

        int GenerateNumber(int start, int end);
    }
}
