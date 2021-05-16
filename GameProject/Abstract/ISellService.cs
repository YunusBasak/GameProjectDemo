using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface ISellService
    {
         void Sell(User user, Game game, Campaign campaign); //public silindi
    }
}
