using System.Collections;
using System.Collections.Generic;

namespace P_Momento
{
    public class GameHistory
    {
        public Stack<HeroMemento> History { get; private set; }

        public GameHistory()
        {
            History = new Stack<HeroMemento>();
        }
    }
}