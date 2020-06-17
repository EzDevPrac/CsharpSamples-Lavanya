using System;

namespace Problem6
{
    class TestTable
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Table[] tables = new Table[10];
            for(int i=0;i<10;i++)
            {
                if(i<5)
                {
                    tables[i] = new Table(random.Next(50, 200), random.Next(50, 200));
                    tables[i].ShowDetails();
                }
                else
                {
                    tables[i] = new CoffeeTable(random.Next(40, 120), random.Next(40, 120));
                    tables[i].ShowDetails();
                }
            }
                
        }
    }
}
