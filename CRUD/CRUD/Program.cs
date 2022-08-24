using System;
using System.Configuration;
using CRUD.events;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess dataAccess = new DataAccess();




            dataAccess.OnEmployeeRemoved += EmployeeRemoved;
            dataAccess.OnNewEmployeeAdded += NewEmployeeAdded;
            bool userDone = false;
            string userCmd = "";
            try
            {

                ShowInstruction();
                do
                {
                    userCmd = Console.ReadLine();
                    switch (userCmd.ToUpper())
                    {
                        case "C":
                            dataAccess.Insert();
                            break;
                        case "R":
                            dataAccess.ReadAll();
                            break;
                        case "U":
                            dataAccess.Update();
                            break;
                        case "D":
                            dataAccess.Remove();
                            break;
                        case "F":
                            dataAccess.Filtr();
                            break;
                        case "S":
                            ShowInstruction();
                            break;
                        case "Q":
                            userDone = true;
                            break;
                    }
                }
                while (!userDone);
            }
            catch
            {
                Console.WriteLine("W aplikacji wystąpił błąd");
            }

        }

      

        private static void ShowInstruction()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("C - Dodaj nowego pracownika");
            Console.WriteLine("R - Pokaż listę pracowników");
            Console.WriteLine("U - Zaktualizuj dane pracownika");
            Console.WriteLine("D - Usuń praacownika z listy");
            Console.WriteLine("F - Szukaj po frazie");
            Console.WriteLine("S - Wyswietl instrukcje");
            Console.WriteLine("Q - Wyjście");
            Console.WriteLine("-------------------");
        }
        private static void NewEmployeeAdded(object sender, EmployeeAddedEventArg e)
        {
            Console.WriteLine($"Pracownik  {e.EmployeeFirstNameName} {e.EmployeeLastName} został dodany");
        }
        private static void EmployeeRemoved(object sender, EmployeeRemovedEventArg e)
        {
            Console.WriteLine($"Pracownik o nr. Id {e.EmployeeId} został usunięty");
        }
    }
    

}
