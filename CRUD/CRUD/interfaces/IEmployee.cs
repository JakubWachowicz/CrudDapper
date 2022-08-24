namespace CRUD.interfaces
{
    internal interface IEmployee:IEmploeeDBElement
    {
        public string id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public decimal Salary { get; set; }
        public string City { get; set; }

        public string ToString()
        {
            return $" {id} {FirstName} {LastName} {Job} {Salary} {City} ";
        }
    }
}
