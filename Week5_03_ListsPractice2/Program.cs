public class Program
{
    private static void Main(string[] args)
    {

        List<string> kahveler = new List<string>();

        //Mesaj gösterip kullancıdan kahve isimlerini talep etme
        Console.WriteLine("5 Adet Kahve İsmi Girinin: ");

        //Kahve isimlerini for döngüsü içinde kullanıcıdan alma.
        for (int i = 1; i <= 5; i++)
        {

            Console.ForegroundColor = ConsoleColor.Red; //Görselde istendiği şekilde consoldaki renk ayarı
            Console.Write($"Kahve {i}: ");

            Console.ForegroundColor = ConsoleColor.DarkGreen; //Görselde istendiği şekilde consoldaki renk ayarı
            string kahve = Console.ReadLine();

            kahveler.Add(kahve);
        }

        //Çıktı rengini ayarlayıp listeyi konsola yazdırma.
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Girilen Kahve İsimleri: ");

        foreach (var kahve in kahveler)
        {
            Console.WriteLine(kahve);
        }











        Console.ReadKey();
    }
}