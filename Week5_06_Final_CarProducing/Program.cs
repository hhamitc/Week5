using Week5_06_Final_CarProducing;

public class Program
{
    public static void Main(string[] args)
    {

        #region Giriş ve Üretim Talebi/Reddi
        List<Cars> CarList = new List<Cars>();//Araba listesi oluşturma.
        Console.WriteLine("------ HOŞ GELDİNİZ------");

        while (true)//Araba üretip üretmek istemediğini kontrol etme.
        {
            Console.Clear();
            Console.WriteLine("Yeni bir araba üretmek ister misiniz? (e/h)");
            string produce = Console.ReadLine().ToLower();
            if (produce == "e")
            {
                break;
            }
            if (produce == "h")
            {
                Console.WriteLine("Çıkış Yapılıyor.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Tekrar Deneyin");
            }
        }
    #endregion

    Produce:

        #region Üretim Aşaması
        //Üretim aşaması ve bilgilerin alınması.
        Cars car = new Cars();

        Console.Write("Aracın Seri Numarasını Girin: ");
        car.SerialNumber = Console.ReadLine();
        Console.Write("Aracın Markasını Girin: ");
        car.Brand = Console.ReadLine();
        Console.Write("Aracın Modelini Girin: ");
        car.Model = Console.ReadLine();
        Console.Write("Aracın Rengini Girin: ");
        car.Color = Console.ReadLine();

    ReTry:
        try
        {
            Console.Write("Aracın Kapı Sayısını Girin: ");
            car.DoorCount = Convert.ToByte(Console.ReadLine());

        }
        catch (Exception ex)
        {
            Console.WriteLine("Hatalı Giriş!! Tekrar deneyin.");
            goto ReTry;
        }
        Console.WriteLine("Üretim Tamamlandı.");
        CarList.Add(car);
        Console.WriteLine("Listeye Eklendi.");
        Console.WriteLine("--------------------------------------------------------");
        #endregion


        #region Yeniden üretim onay/ret ve yazdırma
        Console.WriteLine("Yeni bir araba üretmek ister misiniz? (e/h)");
        string reproduce = Console.ReadLine().ToLower();
        if (reproduce == "e") goto Produce;

        DisplayCarList(CarList);

        Console.ReadKey();
        #endregion
    }

    #region Yazdırma için metot 
    static void DisplayCarList(List<Cars> CarList) // Listeyi burada parametre olarak alın
    {
        Console.WriteLine("-------- Araba Listesi --------");
        foreach (var car in CarList)
        {
            Console.WriteLine($"Seri Numarası: {car.SerialNumber}, Marka: {car.Brand}, Model: {car.Model}, Renk: {car.Color}, Kapı Sayısı: {car.DoorCount}");
        }
    }
    #endregion












}