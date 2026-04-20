namespace EsFileN3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("numeri.txt"))
            {
                File.Create("numeri.txt");
            }
            List<int> numeri = new List<int>();
            string[] arrayTemporaneo = File.ReadAllLines("numeri.txt");
            int media;
            int somma = 0;
            for (int i = 0; i < arrayTemporaneo.Length; i++)
            {
                if (Convert.ToInt32(arrayTemporaneo[i] % 2 == 0))
                {
                    numeri.Add(Convert.ToInt32(arrayTemporaneo[i]));
                    somma += numeri[i];
                }
                Console.WriteLine("[" + i + "]");
            }
            media = somma / numeri.Count;
            Console.WriteLine(media);
        }
    }
}
