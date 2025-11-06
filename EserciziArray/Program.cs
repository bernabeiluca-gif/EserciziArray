namespace EserciziArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // es1
            Console.WriteLine("Dimmi quanti numeri random vuoi");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] numRandom = new int[N];
            Random rnd = new Random();
            for (int i = numRandom.Length - 1; i <= 0; i++)
            {
                numRandom[i] = rnd.Next(100, 201);
            }
            for (int i = 0; i < numRandom.Length; i++)
            {
                Console.WriteLine(numRandom[i] + "-");
            }
            for (int i = numRandom.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numRandom[i]);
            }
            // es2
            int[] indiciPari = { 4, 7, 8, 2, 9 };
            for (int i=0;i< indiciPari.Length; i++)
            {
                if(i%2==0)
                {
                    Console.Write("[" +  indiciPari[i] + "]");
                }
            }
            Console.WriteLine();
            // es3
            int[] numeriDispari = { 4, 7, 8, 2, 9 };
            for(int i=0;i<= numeriDispari.Length;i++)
            {
                if (numeriDispari[i] % 2 ==1)
                {
                    Console.Write("[" +  numeriDispari[i] + "]");   
                }
            }
            // es6
            int[] vettore1 = { 4, 8, 6, 5, 9, 7 };
            int x = 7, contamaggiore = 0, contaminore = 0;
            for (int i=0;  i< vettore1.Length; i++)
            {
                if(vettore1[i]<x)
                {
                    contaminore = contamaggiore + 1;
                }
                else
                {
                    contamaggiore = contamaggiore + 1;
                }
            }
            int[] vettore2 = new int[contaminore];
            int[] vettore3 = new int[contamaggiore];
            int indicemaggiore = 0, indiceminore = 0;
            for(int i=0;i< vettore1.Length;i++)
            {
                if(vettore1[i]<x)
                {
                    vettore2[indiceminore] = vettore1[i];
                    indiceminore = indiceminore + 1;
                }
                else
                {
                    vettore3[indicemaggiore] = vettore1[i];
                    indicemaggiore = indicemaggiore + 1;
                }
            }
            for(int i=0;i<=vettore2.Length;i++)
            {
                Console.Write($"[{vettore2[i]}]");
            }
            Console.WriteLine();
            for(int i=0; i<=vettore3.Length;i++)
            {
                Console.Write($"[{vettore3[i]}]");
            }
        }
    }
}


