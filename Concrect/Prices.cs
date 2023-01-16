namespace lottery
{
    public static class Prices
    {
        public static double megaSena(int numberOfNumbersPlayed)
        {
            switch(numberOfNumbersPlayed) 
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
        public static double quina(int numberOfNumbersPlayed)
        {
            switch(numberOfNumbersPlayed) 
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
        public static double lotomania(int numberOfNumbersPlayed)
        {
            switch(numberOfNumbersPlayed) 
            {
                case 50: return 2.50;
                default: return 0.0;
            }
        }
        public static double lotofacil(int numberOfNumbersPlayed)
        {
            switch(numberOfNumbersPlayed) 
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
        public static double duplaSena(int numberOfNumbersPlayed)
        {
            switch(numberOfNumbersPlayed) 
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