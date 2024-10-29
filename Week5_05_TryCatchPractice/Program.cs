public class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            // Ekranı temizle
            Console.Clear();
            try
            {
                // Kullanıcıdan bir sayı girmesini iste
                Console.WriteLine("Lütfen bir sayı girin. (Saçmalamak serbest)");
                int sayi = Convert.ToInt32(Console.ReadLine());

                // Girilen sayının karesini hesapla
                int karesi = (int)Math.Pow(sayi, 2);

                // Sonucu ekrana yazdır
                Console.WriteLine(karesi);
                break; // Başarılı giriş yapıldığında döngüden çık

            }
            catch (Exception ex)
            {
                // Hatalı giriş yapıldığında hata mesajı göster
                Console.WriteLine("Hatalı bir giriş yaptınız.");
                Console.ReadKey(); // Kullanıcının bir tuşa basmasını bekle
            }
        }

        // Başarılı giriş yapıldığında ekrana mesaj yazdır
        Console.WriteLine("Başarılı.");

        // Programın sonlanmasını bekle
        Console.ReadLine();
    }
}