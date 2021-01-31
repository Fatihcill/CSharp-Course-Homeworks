namespace Day5_Homework5
{
    public interface ICampaingService
    {
        void Add(Campaing campaing);
        void Delete(ref Campaing campaing);
        void Update(ref Campaing campaing,Campaing uCampaing);
    }
}