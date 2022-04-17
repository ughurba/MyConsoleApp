using Entities.Interface;

namespace Entities.Models
{
    public class Client : Person, IEntity
    {
        public int MoneyClient { get; set; }
    }
}
