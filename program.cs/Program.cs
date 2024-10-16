
using System;

namespace EmployeeComparison
{
   
    public class Employee
    {
       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        public static bool operator ==(Employee emp1, Employee emp2)
        {
           
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return ReferenceEquals(emp1, emp2);
            } 
            return emp1.Id == emp2.Id;
        }
         public static bool operator !=(Employee emp1, Employee emp2)
        {
            
            return !(emp1 == emp2);
        }
        
          public override bool Equals(object obj)
        {
            if (obj is Employee otherEmployee)
            {
                return this.Id == otherEmployee.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}

using System;

namespace EmployeeComparison
{
    
    class Program
    {
        static void Main(string[] args)
        {
           
            Employee employee1 = new Employee()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

           
            Employee employee2 = new Employee()
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith"
            };

            
            bool areEqual = employee1 == employee2;

           
            Console.WriteLine($"Are the two employees equal? {areEqual}");

           
            employee2.Id = 1;

            
            areEqual = employee1 == employee2;

           
            Console.WriteLine($"Are the two employees equal after updating the Id? {areEqual}");

           
            Console.ReadLine();
        }
    }
}



