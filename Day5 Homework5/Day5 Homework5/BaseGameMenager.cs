using System;

namespace Day5_Homework5
{
    public class BaseGameMenager : IGameService
    {
        public void Buy(Game game,ref Member member,Campaing campaing=null)
        {
            float price=0f;

            if (campaing == null)
            {
                price = game.Price;
            }
            else
            {
                price = game.Price-(game.Price*campaing.DiscountRate)/100f;
                Console.WriteLine(campaing.Name+" Kampanyası Uygulanıyor");
            }
            if (price <= member.Vallet)
            {
                member.Vallet -= price;
                Console.WriteLine(member.FirstName + " Kullanıcısı " + game.Name + " Adlı oyunu, " + price +
                                  " Fiyatına Satın Aldı");
            }
            else
            {
                Console.WriteLine("Cüzdanınızda ki bakiye Yetersiz");
            }
            Console.WriteLine("Kalan Bakiye : "+ member.Vallet);

        }
    }
}
