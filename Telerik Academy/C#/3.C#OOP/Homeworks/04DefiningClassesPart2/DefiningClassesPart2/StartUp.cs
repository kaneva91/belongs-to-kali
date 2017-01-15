using System;
using System.Collections.Generic;

namespace DefiningClassesPart2
{
    class StartUp
    {
        static void Main(string[] args)

        {   //Point3D Tests
            Point3D point1 = new Point3D(2, 5, 6);
            Point3D point2 = new Point3D(4, 6, 67);
            Console.WriteLine("First Point: " + point1.ToString());
            Console.WriteLine("Second Point: " + point2.ToString());
            Console.WriteLine("Distance Between: " + Calculate.DistanceBetween(point1, point2));
            Console.WriteLine();
            //// Text files
            string pathReadFrom = @"../../TextFiles/ReadFrom.txt";
            string pathSaveTo = @"../../TextFiles/SaveTo.txt";
            ////Printing readed points from the file
            Console.WriteLine("Points extracted from file:");
            List<Point3D> points = new List<Point3D>();
            points = PathStorage.ReadFromFile(pathReadFrom);
            for (int i = 0; i < points.Count; i++)
            {
                Console.WriteLine(points[i]);
            }
            PathStorage.SaveToFile(pathSaveTo, "7.5, 8.4, 9.2");

            //GenericList Tests
            Console.WriteLine("\n------------------------------\nGenericList Tests:");
            var nums = new GenericList<int>();
            Console.WriteLine("Count before adding: {0}, Capacity before adding: {1}", nums.Count, nums.Capacity);
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            nums.Add(6);
            nums.ToString();
            Console.WriteLine("Count after adding: {0}, Capacity after adding: {1}", nums.Count, nums.Capacity);
            Console.WriteLine(nums.ToString());
            var element = nums.AccessByIndex(3);
            Console.WriteLine("Selected by index[3]: " + element);
            nums.RemoveByIndex(6);
            Console.WriteLine("Numbers after removal: " + nums.ToString());
            nums.Insert(7, 1);
            Console.WriteLine(nums.ToString());
            Console.WriteLine("Value 3, finded at index: " + nums.FindValue(3)); 
            nums.Clear();

            //Matarix Tests
            Console.WriteLine("\n------------------------------\nMatrix Tests:");

            var matrixOne = new Matrix<int>(3, 4);
            var matrixTwo = new Matrix<int>(3, 4);
            int counter = 1;

            for (int row = 0; row < matrixOne.Row; row++)
            {
                for (int col = 0; col < matrixOne.Col; col++)
                {
                    matrixOne[row, col] = counter;
                    matrixTwo[row, col] = counter * 2;
                    counter++;
                }
            }

            Console.WriteLine("First matrix:");
            Console.WriteLine(matrixOne.ToString());

            Console.WriteLine("Second matrix:");
            Console.WriteLine(matrixTwo.ToString());

            var additionMatrix = matrixOne + matrixTwo;
            Console.WriteLine("After addition:");
            Console.WriteLine(additionMatrix.ToString());

            var substractionMatrix = matrixTwo - matrixOne;
            Console.WriteLine("After substraction:");
            Console.WriteLine(substractionMatrix.ToString());

        }
    }
}
