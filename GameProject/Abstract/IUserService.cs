using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface IUserService
    {
        void Add(User user); //public silindi.
        void Update(User user);
        void delete(User user);
    }
}
