namespace lottery
{
    public class Lotofacil : Bet
    {
        public const int NUMBERS_AVAILABLE = 25;
        public Lotofacil()
            : base(NUMBERS_AVAILABLE, null)
        {
            this.minimumAndMaximumbet = Tuple.Create(15, 18);
            this.gameName = "Lotofácil";
        }

        public override void showGameName()
        {
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*                              LOTOFÁCIL                                *");
            Console.WriteLine("*************************************************************************");
        }

        public override double valueOfBets()
        {
            switch(numbersByGame) 
            {
                case 15: return 2.50;
                case 16: return 40.00;
                case 17: return 340.00;
                case 18: return 2040.00;
                case 19: return 9690.00;
                case 20: return 38760.00;
                default: return 0.0;
            }
        }
    }
}