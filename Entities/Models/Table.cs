using Entities.Interface;

namespace Entities.Models
{
    public class Table : IEntity
    {
        public string Reservition { get; set; } = "boshdur";
        public string RestaurantNameTable { get; set; }
        public int MoneyTabel { get; set; }
        public string TableNo { get; set; }
        public int Id { get; set; }
    }
}
