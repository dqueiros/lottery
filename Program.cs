namespace lottery
{
    class Program
    {
        static void Main(string[] args)
        {

            bool newGame = false;

            do
            {
            
                Bet bet;
                int game = 0;
                int typeBet = 0;

                Console.WriteLine("Menu:");
                Console.WriteLine("[1] - Mega Sena");
                Console.WriteLine("[2] - Quina");
                Console.WriteLine("[3] - Lotomania");
                Console.WriteLine("[4] - Lotofácil");
                Console.WriteLine("[5] - Dupla Sena");
                
                do
                {
                    Console.Write("\n");
                    Console.Write("Escolha um jogo: ");
                    game = int.Parse(Console.ReadLine());
                } while(!(game >= 1 && game <= 5));

                if(game == Convert.ToInt16(Game.MegaSena)){
                    bet = new MegaSena();
                } else if(game == Convert.ToInt16(Game.Quina)){
                    bet = new Quina();
                } else if(game == Convert.ToInt16(Game.Lotomania)){
                    bet = new Lotomania();
                } else if(game == Convert.ToInt16(Game.Lotofacil)){
                    bet = new Lotofacil();
                } else {
                    bet = new DuplaSena();
                }

                Console.Write("\n");
                Console.WriteLine("Tipo de Aposta: ");
                Console.WriteLine("[1] - Surpresinha");
                Console.WriteLine("[2] - Combinada");

                do
                {
                    Console.Write("\n");
                    Console.Write("Escolha um tipo de jogo: ");
                    typeBet = int.Parse(Console.ReadLine());
                } while(!(typeBet >= 1 && typeBet <= 2));

                Console.Clear();

                if(typeBet == 1){
                    surprise(bet);
                }
                else{
                    combined(bet, game);
                }
                
                Console.Write("\n");
                Console.Write($"Nova aposta (Y/N): ");
                
                if(Console.ReadLine().ToUpper() == "Y")
                    newGame = true;
                else
                    newGame = false;
         
                if(newGame)
                    Console.Clear();
                
            } while(newGame);

            
        }

        public static void surprise(Bet bet){
            do
            {
                Console.Write($"Informe quantos números(entre {bet.minimumAndMaximumbet.Item1} a {bet.minimumAndMaximumbet.Item2}) será a sua aposta da {bet.gameName}: ");
                bet.numbersByGame = int.Parse(Console.ReadLine());
            } while(bet.ValidadeMinimumAndMaximumbet());

            do
            {
                Console.Write("\n");
                Console.Write($"Quantos jogos de {bet.numbersByGame} números tem a sua aposta da {bet.gameName}: ");
                bet.gameAmount = int.Parse(Console.ReadLine());
            } while(false);

            if(bet.gameName == Game.Lotomania.ToString())
            {
                Console.Write("\n");
                Console.Write($"Tem aposta espelho (Y/N): ");
                bet.haveMirror = Console.ReadLine().ToUpper() == "Y" ? true : false;
            }

            Console.Clear();

            bet.surprise();
            bet.showGameName();
            Console.Write("\n");
            bet.showBet();
            Console.Write("\n");
            bet.showGameTotal();
        }
        public static void combined(Bet bet, int game){
        
            Combination combination = new Combination();

            Console.Write("Informe a Quantidade de números que serão agrupados: ");
            int subsetElements = int.Parse(Console.ReadLine());

            Console.Write("\n");
            Console.Write("Informe a Quantos de números serão usados na combinação: ");
            int numberOfNumbers = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            combination.numeros = new int[numberOfNumbers];

            int count = 1;

            for (int i = 0; i < combination.numeros.Length; i++)
            {
                Console.Write(string.Format(@"Informe o {0} : ", count));
                combination.numeros[i] = int.Parse(Console.ReadLine());
                count++;
            }

            combination.quantidade = subsetElements;
            combination.resultado = new int[subsetElements];
        
            Console.Clear();

            bet.showGameName();
            Console.WriteLine("\n");

            combination.busca(0, (numberOfNumbers - subsetElements), 0);

            Console.WriteLine("\n");
            Console.WriteLine("Total de combinacoes: " + combination.count);

            double betAmount = 0.0;

            if(game == Convert.ToInt16(Game.MegaSena)){
                betAmount = Prices.megaSena(subsetElements);
            } else if(game == Convert.ToInt16(Game.Quina)){
                betAmount = Prices.quina(subsetElements);
            } else if(game == Convert.ToInt16(Game.Lotomania)){
                betAmount = Prices.lotomania(subsetElements);
            } else if(game == Convert.ToInt16(Game.Lotofacil)){
                betAmount = Prices.lotofacil(subsetElements);
            } else {
                betAmount = Prices.duplaSena(subsetElements);
            }

            double totalPayable = betAmount * combination.count;
            Console.WriteLine("Total a pagar: " + string.Format("{0:0.00}", totalPayable));
        }
    }
}

