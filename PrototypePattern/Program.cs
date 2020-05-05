using System;

namespace PrototypePattern
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Lavanya";
            emp1.Department = "IT";
            emp1.EmpAddress = new Address() { address = "Kolar" };

            Employee emp2 = emp1.GetClone();
            emp2.Name = "Treena";
            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Address: " + emp1.EmpAddress.address + ", Dept: " + emp1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Address: " + emp2.EmpAddress.address + ", Dept: " + emp2.Department);
        }
    }
}
