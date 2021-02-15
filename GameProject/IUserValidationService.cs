using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService
    {
        bool Validate (Gamer gamer);
        //farklı bir versiyonunda siz normal bir personeli de doğrulamak isteyebilirsiniz
        //fakat biz sadece oyuncuyu doğrulayacağımızı varsayıyoruz.

    }
}
