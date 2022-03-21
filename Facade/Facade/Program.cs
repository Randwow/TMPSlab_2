using System;

namespace Facade
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Facade
            Mortgage mortgage = new Mortgage();
            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Nichita Macheev");

            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                    " loan has been " + (eligible ? "Approved" : "Rejected"));
        }
    }
}
