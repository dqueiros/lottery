namespace lottery
{
    public class Quina : Bet
    {
        public const int NUMBERS_AVAILABLE = 80;
        public Quina()
            : base(NUMBERS_AVAILABLE, null)
        {
            this.minimumAndMaximumbet = Tuple.Create(5, 7);
            this.gameName = "Quina";
        }

        public override void showGameName()
        {
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*                               QUINA                                   *");
            Console.WriteLine("*************************************************************************");
        }

        public override double valueOfBets()
        {
            switch(numbersByGame) 
            {
                case 5: return 2.00;
                case 6: return 12.00;
                case 7: return 42.00;
                case 8: return 112.00;
                case 9: return 252.00;
                case 10: return 504.00;
                case 11: return 924.00;
                case 12: return 1584.00;
                case 13: return 2574.00;
                case 14: return 4004.00;
                case 15: return 6006.00;
                default: return 0.0;
            }
        }
    }
}