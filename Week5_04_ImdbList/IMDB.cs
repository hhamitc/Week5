namespace Week5_04_ImdbList
{
    public class Movie
    {
        //Movie sınıfının Propertyleri tanımlandı
        public string Name { get; set; }
        public double Rating { get; set; }


        //Constructor oluşturuldu
        public Movie(string name, double rating)
        {
            Name = name;
            Rating = rating;
        }

    }




}
