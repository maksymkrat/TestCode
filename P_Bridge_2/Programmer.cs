namespace P_Bridge_2
{
    public abstract class Programmer
    {
        public Ilanguage Language { get; set; }

        public Programmer(Ilanguage language)
        {

            Language = language;
        }

        public virtual void DoWork()
        {
            Language.Build();
            Language.Execute();
            
        }
        
        public abstract void EarnMoney();
    }
}