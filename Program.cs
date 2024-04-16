using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace вектора
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(0, 0, 0, 0, 0, 0);
            Vector v1 = new Vector(1, 2, 3, 4, 5, 6);
            Vector v2 = new Vector(4, 5, 6, 7, 8, 9);
            Vector sum = new Vector(
            vector.Coordinates.Zip(v1.Coordinates, (v, w) => v + w).ToArray()
            );
            Vector difference = new Vector(
                vector.Coordinates.Zip(v1.Coordinates, (v, w) => v - w).ToArray()
            );
            double dotProduct = vector.Coordinates.Zip(v1.Coordinates, (v, w) => v * w).Sum();

            double magnitude = Math.Sqrt(v1.Coordinates.Select(v => v * v).Sum());

            double cosineSimilarity = vector.Coordinates.Zip(v1.Coordinates, (v, w) => v * w).Sum()
                                     / (Math.Sqrt(vector.Coordinates.Select(v => v * v).Sum())
                                     * Math.Sqrt(v1.Coordinates.Select(w => w * w).Sum()));

            Console.WriteLine("Сумма векторов: ({0}, {1}, {2}, {3}, {4}, {5})", sum.X1, sum.Y1, sum.Z1, sum.X2, sum.Y2, sum.Z2);
            Console.WriteLine("Разность векторов: ({0}, {1}, {2}, {3}, {4}, {5})", difference.X1, difference.Y1, difference.Z1, difference.X2, difference.Y2, difference.Z2);
            Console.WriteLine("Скалярное произведение векторов: {0}", dotProduct);
            Console.WriteLine("Длина вектора v1: {0}", magnitude);
            Console.WriteLine("Косинус угла между векторами: {0}", cosineSimilarity);
            Console.ReadKey();
        }
    }
}
