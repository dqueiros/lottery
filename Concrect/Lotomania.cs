namespace lottery
{
    public class Lotomania : Bet
    {
        public const int NUMBERS_AVAILABLE = 99;
        public Lotomania()
            : base(NUMBERS_AVAILABLE, 0)
        {
            this.minimumAndMaximumbet = Tuple.Create(1, 50);
            this.gameName = "Lotomania";
        }

        public override void showGameName()
        {
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*                              LOTOMANIA                                *");
            Console.WriteLine("*************************************************************************");
        }

        public override double valueOfBets()
        {
            switch(numbersByGame) 
            {
                case 50: return 2.50;
                default: return 0.0;
            }
        }
    }
}