using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal interface IUserInteraction
    {
        int Input {  get; } 
        bool Continue { get; }
    }
}
