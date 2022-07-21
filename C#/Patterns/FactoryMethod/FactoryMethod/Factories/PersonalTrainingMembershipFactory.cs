using FactoryMethod.Domain;

namespace FactoryMethod.Factories
{
    class PersonalTrainingMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public PersonalTrainingMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            PersonalTrainingMembership membership = new(_price)
            {
                Description = _description
            };
            return membership;
        }
    }
}
