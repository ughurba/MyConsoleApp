using Entities.Interface;

namespace Entities.Models
{
    public class Restaurant : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

    }
}
