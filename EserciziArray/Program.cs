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
        }
    }
}


