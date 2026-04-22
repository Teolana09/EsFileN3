namespace EsFileN3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime ora = DateTime.Now;
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
                if (Convert.ToInt32(arrayTemporaneo[i]) % 2 != 0)
                {
                    numeri.Add(Convert.ToInt32(arrayTemporaneo[i]));
                    Console.WriteLine("[" + i + "]");

                }
                
            }

            foreach (int j in numeri)
            {
                somma += j;
            }
            media = somma / numeri.Count;
            Console.WriteLine(media);
            //es 4
            if (!File.Exists("accesso.txt"))
            {
                File.Create("accesso.txt");
            }
            using (StreamWriter sw = new StreamWriter("accesso.txt", true))
            {
                sw.WriteLine("Sessione Utente Avviato evento: " + ora);
            }

            //es 5
            string cartella = "alert.txt";
            string File2 =  "log_sistema.txt";
            List<string> list = new List<string>();


            using (StreamReader sr = new StreamReader("log_sistema.txt"))
            {
                string riga = sr.ReadLine();
                while (riga != null)
                {
                    list.Add(riga);
                    riga = sr.ReadLine();
                }

            }
            if (!File.Exists(cartella))
            {
                File.Create(cartella);
            }
            for (int i = list.Count; i > 0; i--)
            {
                if (list.Contains("CRITICAL"))
                {
                    using (StreamWriter sw = new StreamWriter(cartella, true))
                    {
                        for (int j = 0; j < list.Count; j++)
                        {
                            sw.WriteLine("Registrato evento: " + list[j]);
                        }
                    }
                }
            }
            
        }
    }
}
