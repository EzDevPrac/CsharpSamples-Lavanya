using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] employeesArray = new string[5, 4]
             {
                {"101","Lavanya","SE","10000"},
                {"102","Tereena","SE","20000"},
                {"103","Karan","SSE","30000"},
                {"104","Raju","SE","40000"},
                {"105","Shashank","SSE","50000"}
             };

            ITarget target = new EmployeeAdapter();
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            target.ProcessCompanySalary(employeesArray);
            Console.Read();
        }
    }
}
