using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgazzGame.Infrastructure.Interfaces
{
    public interface IGame
    {
        string Name { get; }
        string Description { get; }
        string HelloText { get; }

        void Play()
        { 
        }
    }
}
