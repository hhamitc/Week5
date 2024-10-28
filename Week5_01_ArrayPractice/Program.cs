public class Program
{
    private static void Main(string[] args)
    {

        int[] tamSayilar = new int[10]; //10 Adet tam sayı içerecek bir dizi oluşturdum.
        Random rnd = new Random();// Bu sayıları rast gele üretmek istediğim için random sınıfından bir değişken oluşturdum.


        for (int i = 0; i < tamSayilar.Length; i++) //Dizinin elemanlarını rastgele oluşturduğum rnd değişkeniyle üretip tanımladım.
        {
            tamSayilar[i] = rnd.Next(1, 121);
        }

        foreach (int i in tamSayilar)//Diziyi konsola yazdırdım.
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("------------------------------");//Görüntüyü ayırmak için çizgi satırı ekledim.


        Array.Resize(ref tamSayilar, tamSayilar.Length + 1);// Dizinin boyutunu bir adet artırdım.


        Console.Write("Dizinin 11.Değerini giriniz: "); //Dizinin 11.Değerini kullanıcıdan istedim.
        tamSayilar[10] = int.Parse(Console.ReadLine());


        //Diziyi büyükten küçüğe yazdırmak için sort ve reverse metotlarını kullandım ve foreach ile yeniden yazdırdım.
        Array.Sort(tamSayilar);
        Array.Reverse(tamSayilar);

        foreach (var i in tamSayilar)
        {
            Console.WriteLine(i);
        }


        Console.ReadKey();
    }
}