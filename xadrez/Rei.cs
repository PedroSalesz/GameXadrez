using System;
using Xadrezgame.tabuleiro;

namespace Xadrezgame.xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor)
            : base(tab,
                   cor) 
        
        { 
        }

        public override string ToString()
        {
            return "R";

        }
    }
}
