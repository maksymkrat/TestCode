namespace P_Momento
{
    public class HeroMemento
    {
        public int Patronds { get; set; }
        public int Lives { get; set; }

        public HeroMemento(int patronds, int lives)
        {
            Patronds = patronds;
            Lives = lives;
        }
    }
}