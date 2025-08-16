using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.First_Project
{
    class Point3D:IComparable<Point3D>,ICloneable
    {

        #region Properties
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }
        #endregion

        #region Constructor 
        public Point3D()
        {
            
        }

        public Point3D(Point3D point3D)
        {
            X = point3D.X;
            Y = point3D.Y;
            Z = point3D.Z;
        }
        public Point3D(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"Point Coordinates: ({X},{Y},{Z})";
        }

        public int CompareTo(Point3D? other)
        {
            int res=X.CompareTo(other?.X);
            if (res == 0)
                return Y.CompareTo(other?.Y);

            return res;
        }

        public object Clone()
        {
            return new Point3D(this);
        }
        #endregion
    }
}
