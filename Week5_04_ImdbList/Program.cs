using Week5_04_ImdbList;

public class Program
{
    public static void Main(string[] args)
    {
        List<Movie> MovieList = new List<Movie>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Eklemek İstediğiniz Film adını giriniz:  ");

            string name = Console.ReadLine();

            double rating;
            Console.Write("Puanını giriniz: ");


            while (!double.TryParse(Console.ReadLine(), out rating) || !(rating >= 0 && rating <= 10))
            {
                Console.WriteLine("Geçerli bir puan giriniz.");
            }


            Movie movie = new Movie(name, rating);
            MovieList.Add(movie);

            Console.WriteLine("Başarıyla Eklendi.");

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Yeni bir film eklemek için 1 çıkmak için 2 değerini girin.");

            int addNew;

            while (!int.TryParse(Console.ReadLine(), out addNew) || !(addNew == 1 || addNew == 2))
            {
                Console.WriteLine("Hatalı giriş!! \nYeni bir film eklemek için 1 çıkmak için 2 değerini girin.");
            }

            if (addNew == 1)
            {
                continue;
            }
            else if (addNew == 2)
            {

                Console.Clear();
                DisplayFullList();
                Console.WriteLine("-------------------");
                DisplayListInRangeOf(4, 9);
                Console.WriteLine("-------------------");
                DisplayListStartsBy("A");
                Console.ReadKey();
                return;
            }

        }

        void DisplayFullList()
        {
            Console.WriteLine("----- Filmler Tam Liste -----");
            foreach (var movie in MovieList)
            {
                Console.WriteLine($"Film Adı: {movie.Name}, IMDB Puanı: {movie.Rating}");
            }
        }


        void DisplayListInRangeOf(double floorRating, double cealingRating)
        {
            Console.WriteLine($"----- Puanı {floorRating} - {cealingRating} Arasındaki Filmler  -----");
            foreach (var movie in MovieList)
            {
                if (movie.Rating >= floorRating && movie.Rating <= cealingRating)
                {
                    Console.WriteLine($"Film Adı: {movie.Name}, IMDB Puanı: {movie.Rating}");
                }

            }
        }

        void DisplayListStartsBy(string letter)
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



        Console.ReadKey();
    }
}