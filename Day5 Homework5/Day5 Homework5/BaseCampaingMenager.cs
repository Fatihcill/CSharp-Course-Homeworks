using System;

namespace Day5_Homework5
{
    public class BaseCampaingMenager:ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine(campaing.Name+ " Kampanyası Kaydedildi");
        }

        public void Delete(ref Campaing campaing)
        {
            Console.WriteLine(campaing.Name + " Kampanyası Silindi");
            campaing = null;
        }

        public void Update(ref Campaing campaing,Campaing uCampaing)
        {
            Console.WriteLine(campaing.Name + " Kampanyası "+uCampaing.Name +" Olarak Güncellendi");
            campaing = uCampaing;
        }
    }
}