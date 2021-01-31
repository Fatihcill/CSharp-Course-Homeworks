namespace Day5_Homework5
{
    public class UserValidationManager: IUserValidationService
    {
        public bool Validate(Member member)
        {
            if (member.NationalityID != null && member.FirstName != null && member.LastName != null && member.DateOfBirth != null)
            { return true; }
            else
            { return false; }
        }
    }
}