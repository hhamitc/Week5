using Week5_04_ImdbList;

public class Program
{
    public static void Main(string[] args)
    {
        // Film listesini tutmak için bir liste oluşturuluyor
        List<Movie> movieList = new List<Movie>();

        while (true)
        {
            // Ekranı temizle
            Console.Clear();
            Console.WriteLine("Eklemek İstediğiniz Film adını giriniz:  ");

            // Kullanıcıdan film adını al
            string name = Console.ReadLine();

            double rating;
            Console.Write("Puanını giriniz: ");

            // Kullanıcıdan geçerli bir puan alana kadar döngü devam eder
            while (!double.TryParse(Console.ReadLine(), out rating) || !(rating >= 0 && rating <= 10))
            {
                Console.WriteLine("Geçerli bir puan giriniz.");
            }

            // Yeni bir film nesnesi oluştur ve listeye ekle
            Movie movie = new Movie(name, rating);
            movieList.Add(movie);

            Console.WriteLine("Başarıyla Eklendi.");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Yeni bir film eklemek için 1 çıkmak için 2 değerini girin.");

            int addNew;

            // Kullanıcıdan geçerli bir seçim alana kadar döngü devam eder
            while (!int.TryParse(Console.ReadLine(), out addNew) || !(addNew == 1 || addNew == 2))
            {
                Console.WriteLine("Hatalı giriş!! \nYeni bir film eklemek için 1 çıkmak için 2 değerini girin.");
            }

            // Kullanıcı 1 seçerse döngü devam eder, 2 seçerse program sonlanır ve listeler gösterilir
            if (addNew == 1)
            {
                continue;
            }
            else if (addNew == 2)
            {
                // Ekranı temizle ve listeleri göster
                Console.Clear();
                DisplayFullList(movieList);
                Console.WriteLine("-------------------");
                DisplayListInRangeOf(4, 9, movieList);
                Console.WriteLine("-------------------");
                DisplayListStartsBy("A", movieList);
                Console.ReadKey();
                return;
            }
        }

        Console.ReadKey();
    }

    // Tüm film listesini ekrana yazdırır
    public static void DisplayFullList(List<Movie> MovieList)
    {
        Console.WriteLine("----- Filmler Tam Liste -----");
        foreach (var movie in MovieList)
        {
            Console.WriteLine($"Film Adı: {movie.Name}, IMDB Puanı: {movie.Rating}");
        }
    }

    // Belirtilen puan aralığındaki filmleri ekrana yazdırır
    public static void DisplayListInRangeOf(double floorRating, double cealingRating, List<Movie> MovieList)
    {
        Console.WriteLine($"----- Puanı {floorRating} - {cealingRating} Arasındaki Filmler  -----");
        foreach (Movie movie in MovieList)
        {
            if (movie.Rating >= floorRating && movie.Rating <= cealingRating)
            {
                Console.WriteLine($"Film Adı: {movie.Name}, IMDB Puanı: {movie.Rating}");
            }
        }
    }

    // Belirtilen harf ile başlayan filmleri ekrana yazdırır
    public static void DisplayListStartsBy(string letter, List<Movie> MovieList)
    {
        Console.WriteLine($"----- İsmi {letter} ile başlayan Filmler  -----");
        foreach (var movie in MovieList)
        {
            if (movie.Name.StartsWith(letter.ToLower()) || movie.Name.StartsWith(letter.ToUpper()))
            {
                Console.WriteLine($"Film Adı: {movie.Name}, IMDB Puanı: {movie.Rating}");
            }
        }
    }


}