using System;

namespace Day5_Homework5
{
    public class BaseMemberMenager:IMemberService
    {
        UserValidationManager _userValidationService;

        public BaseMemberMenager(UserValidationManager userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Member member)
        {
            if (_userValidationService.Validate(member))
            {
                Console.WriteLine(member.FirstName+" Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");
            }


        }

        public void Delete(ref Member member)
        {
            Console.WriteLine(member.FirstName + " Kayıt silindi :(");
            member = null;

        }

        public void Update(ref Member member,Member updateMember)
        {
            member = updateMember;

            Console.WriteLine(member.FirstName + " Kayıt güncellendi");


        }

    }
}