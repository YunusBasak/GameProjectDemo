using GameProject.Abstract;
using GameProject.Entities;
using GameProject.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapters
{
    class MernisServiceAdapters : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(user.NationalityId), user.FirstName.ToUpper(),
                user.LastName.ToUpper(), user.DateOfBirth.Year);
        }
    }
}
