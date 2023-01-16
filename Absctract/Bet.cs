namespace lottery
{
    public abstract class Bet
    {
        public Bet(int numbersAvailable, int? minNumbersAvailable){
            this.numbersAvailable = numbersAvailable;
            this.minNumbersAvailable = minNumbersAvailable ?? 1;

            this.listGuesses = new List<List<int>>();
        }

        protected int minNumbersAvailable { get; set; }
        public int numbersByGame { get; set; }
        private int numbersAvailable { get; set; }
        public int gameAmount { get; set; }
        public int amountSurprise { get; set; }
        private List<List<int>> listGuesses;
        public Tuple<int, int> minimumAndMaximumbet;
        public string gameName { get; set; }
        public bool haveMirror { get; set; } // aposta ESPELHO da LOTOMANIA


        public abstract void showGameName();
        public abstract double valueOfBets();
        public void surprise() {
            Random random = new Random();
            HashSet<int> hashGuesses = new HashSet<int>();

            int line = 0;

            while(true)
            {

                while(true)
                {
                    hashGuesses.Add(random.Next(minNumbersAvailable,this.numbersAvailable));

                    if(hashGuesses.Count() == this.numbersByGame){
                        break;
                    }
                }

                List<int> listSort = hashGuesses.OrderBy(p => p).ToList();
                this.listGuesses.Add(listSort);
                hashGuesses.Clear();


                // aposta ESPELHO da LOTOMANIA - inicio
                if(haveMirror){
                    for (int number = 0; number <= numbersAvailable; number++)
                    {
                        if(!listSort.Contains(number)){
                            hashGuesses.Add(number);
                        }
                    }

                    this.listGuesses.Add(hashGuesses.OrderBy(p => p).ToList());
                    hashGuesses.Clear();
                }
                // aposta ESPELHO da LOTOMANIA - Fim
                
                if(line == this.gameAmount - 1){
                    break;
                }

                line++;

            }
        }
        public void showBet()
        {
            int number = 1;
            foreach(var guess in listGuesses)
            {
                Console.WriteLine(String.Format("[{0}] {1} {2}", number, string.Join(" ", guess), haveMirror && (number % 2 == 0) ? " - ES" : "" ));
                number++;
            }
        }
        public bool ValidadeMinimumAndMaximumbet()
        {
            return !(this.numbersByGame >= this.minimumAndMaximumbet.Item1 
            && this.numbersByGame <= this.minimumAndMaximumbet.Item2);
        }
        public void showGameTotal()
        {
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(string.Format("Total: R$ {0:0.00}", (this.valueOfBets() * listGuesses.Count()) ));
        }
    }
}

