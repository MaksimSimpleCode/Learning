using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Domain
{
    internal class GymPlusPoolMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;
        public GymPlusPoolMembership(decimal price)
        {
            _name = "Gym Plus Pool Membership";
            _price = price;
        }

        public string Name => _name;

        public string Description { get; set; }

        public decimal GetPrice() => _price;
    }
}
