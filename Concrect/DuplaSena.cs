namespace lottery
{
    public class DuplaSena : Bet
    {
        public const int NUMBERS_AVAILABLE = 50;
        public DuplaSena()
            : base(NUMBERS_AVAILABLE, null)
        {
            this.minimumAndMaximumbet = Tuple.Create(6, 15);
            this.gameName = "Dupla Sena";
        }

        public override void showGameName()
        {
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*                              DUPLA SENA                               *");
            Console.WriteLine("*************************************************************************");
        }

        public override double valueOfBets()
        {
            switch(numbersByGame) 
            {
                case 6: return 2.50;
                case 7: return 17.50;
                case 8: return 70.00;
                case 9: return 210.00;
                case 10: return 525.00;
                case 11: return 1155.00;
                case 12: return 2319.00;
                case 13: return 4290.00;
                case 14: return 7507.50;
                case 15: return 12512.50;
                default: return 0.0;
            }
        }
    }
}