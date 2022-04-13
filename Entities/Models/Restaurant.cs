using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Restaurant : IEntity
    {
        public int Id { get ; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
    }
}
