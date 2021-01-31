using System;

/*Bir oyun yazmak istiyorsunuz. Bu yazılım için backend kodlarını C# ile geliştirmeyi planlıyoruz. Yeni üye, satış ve
 kampanya yönetimi yapılması isteniyor. Nesnelere ait özellikleri istediğiniz gibi verebilirsiniz. Burada amaç yazdığınız
 kodun kalitesidir. Ödevde gereksinimleri tam anlamadığınız durum benim için önemli değil, kendinize göre mantık geliştirebilirsiniz.
 Dediğim gibi kod kalitesiyle ilgileniyoruz şu an :)

Gereksinimler

1. (tamam)    Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

2. (tamam)   Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

3.  (Tamam)   Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

4.  (tamam)   Satışlarda kampanya entegrasyonunu simule ediniz.

*/

namespace Day5_Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseMemberMenager memberManager = new BaseMemberMenager(new UserValidationManager());

            Member deneme1 = new Member
            {
                Id = 1,
                DateOfBirth = new DateTime(2001, 04, 25),
                FirstName = "Fatih",
                LastName = "Çil",
                NationalityID = "132123",
                Vallet=20
            };
            Member deneme2 = new Member
            {
                Id = 2,
                DateOfBirth = new DateTime(1111, 11, 11),
                FirstName = "NOTHING",
                Vallet=0
            };
            //1.Aşama
            memberManager.Add(deneme1);
            memberManager.Add(deneme2);

            memberManager.Update(ref deneme1,new Member
            {Id = 1, DateOfBirth = new DateTime(2001, 04, 25), FirstName = "Fatih", LastName = "Çil", NationalityID = "5555", Vallet=50});//referans olarak üyelik bilgilerimizi göndererek bilgilerimizi güncelleyebiliyoruz.
            Console.WriteLine(deneme1.NationalityID);//123123 ten 5555 değerine değiştiğini görüyoruz

            memberManager.Delete(ref deneme2); // burada da null değerine değiştiriyoruz (en iyi şekilde simule etmek istedim).
                                               //Console.WriteLine(deneme2.FirstName);


            Console.WriteLine("Bakiye : " + deneme1.Vallet);

            //2.Aşama
            Game oyun1 = new Game
            {
                Id = 1,
                Name = "Oyun1",
                Price = 10
            };
            BaseGameMenager gameMenager = new BaseGameMenager();
            gameMenager.Buy(oyun1,ref deneme1);

            //3.Aşama
            Campaing campaing1 = new Campaing
            {
                Id = 1,
                DiscountRate = 50,
                Name = "Yılbaşı Kampanyası"
            };
            BaseCampaingMenager baseCampaing = new BaseCampaingMenager();
            baseCampaing.Add(campaing1);
            baseCampaing.Update(ref campaing1,new Campaing{Id=2,DiscountRate = 25,Name = "İlk Bahar Kampanyası"});
            //Console.WriteLine(campaing1.Name);
            //baseCampaing.Delete(ref campaing1);


            //4.Aşama
            gameMenager.Buy(oyun1, ref deneme1,campaing1);

        }

    }
}
