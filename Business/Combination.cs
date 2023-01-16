namespace lottery
{
    public class Combination
    { 
        public int[] numeros;
        public int quantidade;
        public int[] resultado;
        public int count = 0;
    
        public void busca(int inicio, int fim, int profundidade){
    
        if ( (profundidade + 1) >= quantidade)
            for(int x = inicio; x <= fim; x++){
                resultado[profundidade] = numeros[x];
                // faz alguma coisa com um dos resultados possiveis
                count++;

                Console.Write("[" + (count < 10 ? "0" + count : count) + "] ");

                foreach(var s in resultado)
                {
                    Console.Write(s + " ");
                }

                Console.Write("\n");
                //Console.WriteLine("[" + (count < 10 ? "0" + count : count) + "] " + resultado[0] + ", " + resultado[1] + ", " + resultado[2] + ", " + resultado[3] + ", " + resultado[4] + ", " + resultado[5]);
            }
        else
            for(int x = inicio; x <= fim; x++){
                resultado[profundidade] = numeros[x];
                busca(x + 1,fim + 1,profundidade + 1);
            }
        }
    }
}