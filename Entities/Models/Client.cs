using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Client:Person ,IEntity
    {
        public int  MoneyClient { get; set; }
    }
}
