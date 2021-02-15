using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;
        //constructor Ben GameManager sınıfında IUserValidateService i kullanacağım demek.
        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Olundu");
            }
            else
            {
                Console.WriteLine("Böyle Kayıtlı Bir Oyuncu Zaten Var");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
