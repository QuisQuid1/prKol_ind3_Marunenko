using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вектора
{ 
    class Vector
    {
        public double X1 { get; }
        public double Y1 { get; }
        public double Z1 { get; }
        public double X2 { get; }
        public double Y2 { get; }
        public double Z2 { get; }

        public double[] Coordinates => new[] { X1, Y1, Z1, X2, Y2, Z2 };

        public Vector(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            X1 = x1;
            Y1 = y1;
            Z1 = z1;
            X2 = x2;
            Y2 = y2;
            Z2 = z2;
        }

        public Vector(double[] coordinates)
        {
            X1 = coordinates[0];
            Y1 = coordinates[1];
            Z1 = coordinates[2];
            X2 = coordinates[3];
            Y2 = coordinates[4];
            Z2 = coordinates[5];
        }
    }
}
