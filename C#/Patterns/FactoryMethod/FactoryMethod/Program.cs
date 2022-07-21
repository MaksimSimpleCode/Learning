using System;
using FactoryMethod.Factories;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Console.WriteLine("Введите тип абонимента который хотите создать....");
            Console.WriteLine("1-Базовый\n2-С бассейном\n3-С персональными тренировками");

            string membershipType = Console.ReadLine();

            MembershipFactory factory = GetFactory(membershipType);
            Domain.IMembership membership = factory.GetMembership();

            Console.WriteLine($"\tНазвание:\t\t{membership.Name}\n" +
                $"\tОписание:\t{membership.Description}\n" +
                $"\tЦена:\t\t{membership.GetPrice()}");

            Console.ReadLine();
        }

        private static MembershipFactory GetFactory(string membershipType)
        {
          return  membershipType.ToLower() switch
            {
                "1" => new GymMembershipFactory(100, "Базовый абонемент"),
                "2" => new GymPlusPoolMembershipFactory(200, "Абонемент с бассейном"),
                "3" => new PersonalTrainingMembershipFactory(400, "Абонемент с персональными тренировками"),
                _ => null
            };
        }
        
    }
}
