using System;

namespace P_Momento
{
    public class Hero
    {
        private int patrons = 10;
        private int lives = 5;

        public void Shoot()
        {
            if (patrons > 0)
            {
                patrons--;
                Console.WriteLine("We shoot. Almost {0} patrons", patrons);
            }
            else
            {
                Console.WriteLine("There are no more patrons");
            }
        }

        public HeroMemento SaveState()
        {
            Console.WriteLine("Saveing game. Params: {0} patrons, {1}lives",patrons,lives);
            return new HeroMemento(patrons, lives);
        }

        public void RestoreState(HeroMemento memento)
        {
            this.patrons = memento.Patronds;
            this.lives = memento.Lives;
            Console.WriteLine("Restore game. Params: {0} patrons, {1} lives", patrons, lives);
        }
    }
}