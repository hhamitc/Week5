public class Program
{
    private static void Main(string[] args)
    {

        List<string> Visitors = new List<string>();//Visitors adlı listeyi oluşturuyoruz.


        //Listeye elemanları ekliyoruzç
        Visitors.Add("Şebnem Ferah");
        Visitors.Add("Bülent Ersoy");
        Visitors.Add("Ajda Pekkan");
        Visitors.Add("Ebru Gündeş");
        Visitors.Add("Hadise");
        Visitors.Add("Hande Yener");
        Visitors.Add("Tarkan");
        Visitors.Add("Funda Arar");
        Visitors.Add("Demet Akalın");

        Console.WriteLine("----- ZİYARETÇİLER ------");// Lİste öncesi başlık ekleme

        //Tüm ziyaretçilerin ekrana yazdırılması.
        foreach (var visitor in Visitors)
        {
            Console.WriteLine(visitor);
        }


        Console.ReadLine();
    }
}