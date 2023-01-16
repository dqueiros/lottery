namespace lottery
{
    public class MegaSena : Bet
    {
        public const int NUMBERS_AVAILABLE = 60;
        //public Tuple<int, int> minimumAndMaximumbet;
        public MegaSena()
            : base(NUMBERS_AVAILABLE, null)
        {
            this.minimumAndMaximumbet = Tuple.Create(6, 15);
            this.gameName = "Mega Sena";
        }

        public override void showGameName()
        {
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*                              MEGA SENA                                *");
            Console.WriteLine("*************************************************************************");
        }

        public override double valueOfBets()
        {
            switch(numbersByGame) 
            {
                case 6: return 4.50;
                case 7: return 31.50;
                case 8: return 126.00;
                case 9: return 378.00;
                case 10: return 945.00;
                case 11: return 2079.00;
                case 12: return 4158.00;
                case 13: return 7722.00;
                case 14: return 13513.50;
                case 15: return 22522.50;
                default: return 0.0;
            }
        }
    }
}