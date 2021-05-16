using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class UserManager : IUserService
    {
        private IUserCheckService _userCheckService;

        public UserManager(IUserCheckService userCheckService) 
        {
            _userCheckService = userCheckService;
        }  


        public void Add(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                Console.WriteLine("Üyeliğiniz aktif edilmiştir!");
            }
            else
            {
                throw new Exception("Bilgileriniz doğrulanamadı.");
            }
            
        }

        public void delete(User user)
        {
            Console.WriteLine("Üyeliğiniz Silinmiştir!"); 
        }

        public void Update(User user)
        {
            Console.WriteLine("Üyeliğiniz Güncellenmiştir!");
        }
    }
}
