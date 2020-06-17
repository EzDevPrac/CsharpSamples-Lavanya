using System;

namespace Problem8
{
    class TestPoint3D
    {
        static void Main(string[] args)
        {
            
            Point3D[] points = new Point3D[5];
            points[0] = new Point3D(3, 4, 5);
            points[1] = new Point3D(5, 6, 7);
            points[2] = new Point3D(8, 3, 2);
            points[3] = new Point3D(1, 4, 9);
            points[4] = new Point3D(1, 4, -7);
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(points[i].ToString());
                Console.WriteLine(points[i].DistanceTo(points[0]));
            }


        }
    }
}
