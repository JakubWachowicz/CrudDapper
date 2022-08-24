using System;
using System.Text;
using System.Threading.Tasks;
using CRUD.crudActions;
using CRUD.events;
namespace CRUD
{
    class DataAccess
    {
        public event EventHandler<EmployeeAddedEventArg> OnNewEmployeeAdded;
        public event EventHandler<EmployeeRemovedEventArg> OnEmployeeRemoved;

       
        public  void Insert()
        {
           
           Console.WriteLine("Aby dodać pracownika wciśnij 1 \nAby dodać dodatkowe iforacje o pracowniku naciśnij 2");
            string userCmd = Console.ReadLine();
            if(userCmd == "2")
            {
                InsertAction.InsertEmoloyeeInfo(CreateAction.CreateEmployeeInfo());
               
            }
            else
            {
                InsertAction.InsertEmoloyee(CreateAction.CreateEmployee(),OnNewEmployeeAdded);
                
            }
            
           
        }
        public void ReadAll()
        {
            Console.WriteLine("Aby wyświetlić listę pracowników naciścnij 1 \nAby wyświetlić liste dodatkowych inforamcji o pracownikach naciśnij 2 \nAby wyświetlić pełną listę informacji naciśnij 3");
            string userCmd = Console.ReadLine();

            if(userCmd =="1")
            {
                ReadAction.ReadAllEmployee();
            }
            else if(userCmd =="2")
            {

                ReadAction.ReadAllEmployeeInfo();
            }
            else
            {
                ReadAction.ReadAllEmployeeFullInfo();
            }

         
        }
     
        public void Update()
        {
            Console.WriteLine("Aby edytować pracownika wciśnij 1 \nAby edytować dodatkowe iforacje o pracowniku naciśnij 2");
            string userCmd = Console.ReadLine();
            if (userCmd == "2")
            {
                UpdateAction.UpdateEmployeeInfo();
            }
            else
            {
                UpdateAction.UpdateEmployee();
              

            }
            Console.WriteLine("Edytowano pracownika");
        }

        public void Remove()
        {
            RemoveAction.RemoveEmployee(OnEmployeeRemoved);
            
        }
        public void Filtr()
        {

            Console.WriteLine("Aby wyszukać po frazie naciśnij 1\nAby wyszukać nazwisko po pierszych literach naciśnij 2");
            string userCmd = Console.ReadLine();
            if (userCmd == "2")
            {
                FiltrAction.FiltrBylastName();
            }
            else
            {
                FiltrAction.FiltrBy();
            }
           

        }

       
    }

}

