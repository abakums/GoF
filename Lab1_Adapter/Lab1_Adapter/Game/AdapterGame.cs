using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Adapter
{
    class AdapterGame : IGame
    {
        Monet mot;
        public AdapterGame(Monet mt)
        {
            mot = mt;
        }
        public int Brosok()
        {
            return mot.BrosokM();
        }
    }
}
