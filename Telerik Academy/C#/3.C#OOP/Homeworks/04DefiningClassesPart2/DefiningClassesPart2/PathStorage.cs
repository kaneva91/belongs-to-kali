using System;
using System.IO;
using System.Collections.Generic;

namespace DefiningClassesPart2
{
     public static class PathStorage
    {
        public static List<Point3D> ReadFromFile(string path)
        {
            List<Point3D> points = new List<Point3D>();
            string[] pattern = {" ", ",","\r\n"};
            string text = null;
            using (var reader = new StreamReader(path))
            {
                text = reader.ReadToEnd();
            }
            string[] arrOfCourdinates =  text.Split(pattern, StringSplitOptions.RemoveEmptyEntries);
          
            for (int i = 0; i < arrOfCourdinates.Length; i+=3)
            {
                double x = Convert.ToDouble(arrOfCourdinates[i]);
                double y = Convert.ToDouble(arrOfCourdinates[i + 1]);
                double z = Convert.ToDouble(arrOfCourdinates[i + 2]);

                points.Add(new Point3D(x, y, z));
            }
            return points;
        }

        public static void SaveToFile(string path, string sourse)
        {
            using (var writter = new StreamWriter(path))
            {
                writter.AutoFlush = true;
                writter.WriteLine(sourse);
            }
        }
    }

}

