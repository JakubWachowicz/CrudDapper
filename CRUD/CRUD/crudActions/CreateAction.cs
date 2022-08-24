using System;
using CRUD.events;
using CRUD.models;


namespace CRUD.crudActions
{
    public class CreateAction
    {
        public static Employee CreateEmployee()
        {
            Console.WriteLine("Podaj imię pracownika");
            string firstName = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko pracownika");
            string lastName = Console.ReadLine();
            Console.WriteLine("Podaj stannowisko pracownika");
            string job = Console.ReadLine();
            Console.WriteLine("Podaj pensję pracownika");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Podaj miejsce zamieszkania pracownika");
            string city = Console.ReadLine();
            Employee employee = new Employee { FirstName = firstName, LastName = lastName, Job = job, Salary = salary, City = city };
            return employee;
        }

        public static EmployeeInfo CreateEmployeeInfo()
        {
            Console.WriteLine("Podaj zawód pracownika");
            string occupation = Console.ReadLine();
            Console.WriteLine("Podaj nr telefonu pracownika");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Podaj datę rozpoczęcia pracy");
            string startedWorking = Console.ReadLine();
            Console.WriteLine("Podaj wysokość premii pracownika");
            decimal bonus = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Podaj dodatkowe inforacje o pracowniku");
            string info = Console.ReadLine();
            EmployeeInfo employeeInfo = new EmployeeInfo { Occupation = occupation, PhoneNr = phoneNumber, StartedWorking = startedWorking, Bonus = bonus, Info = info };
            return employeeInfo;

        }
    }
}
