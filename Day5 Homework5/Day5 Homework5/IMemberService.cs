namespace Day5_Homework5
{
    public interface IMemberService
    {
        void Add(Member member);
        void Update(ref Member member,Member updateMember);
        void Delete(ref Member member);
    }
}