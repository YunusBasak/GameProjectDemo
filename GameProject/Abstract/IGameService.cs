using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface IGameService
    {
         void Add(Game game);// public Silindi
         void Update(Game game);
         void Delete(Game game);
    }
}
