using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad = "Fatih";
            musteri.Soyad = "Çil";



            musteriManager.Add(musteri);
            musteriManager.Delete(musteri);
            musteriManager.Update(musteri);

        }
    }
}