using System;

    class CompanyInfo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter company's name: ");
            string firmName = Console.ReadLine();
            Console.Write("Enter company's address: ");
            string firmAddress = Console.ReadLine();
            Console.Write("Enter company's phone: ");
            string firmPhone = Console.ReadLine();
            Console.Write("Enter company's fax: ");
            string firmFax = Console.ReadLine();
            Console.Write("Enter company's web site: ");
            string firmSite = Console.ReadLine();
            Console.Write("Enter manager's first name: ");
            string managerName = Console.ReadLine();
            Console.Write("Enter manager's last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Enter manager's age: ");
            int managerAge = int.Parse(Console.ReadLine());
            Console.Write("Enter manager's phone number: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("The company {0} is with address {1}, phone number {2} and fax {3}. You can find more information about {0} at web site {4}. The manager {5} {6}, age {7} would be glad to answer all your questions at number {8}.",firmName,firmAddress,firmPhone,firmFax,firmSite,managerName,managerLastName,managerAge,managerPhone);

        }
    }

