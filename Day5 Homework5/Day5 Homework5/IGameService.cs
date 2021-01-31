namespace Day5_Homework5
{
    public interface IGameService
    {
        void Buy(Game game ,ref Member member,Campaing campaing=null);
    }
}