using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IClient
    {

        Client Creat(Client client);
        bool DeleteByName(string name);
        Client UpdateMoney(int id, int money);

        Client Reservition(int id, string tableNo);





    }
}
