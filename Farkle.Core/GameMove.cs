using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farkle.Core
{
    public enum GameMove
    {
        Bank,
        Roll,
        NextPlayer // automatic after Bank, requried after Farkle is rolled
    }
    
}
