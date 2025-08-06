using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Qestion_02
{
    class Rectangle
    {
        #region Properties
        public int Width { get; set; }
        public int Height { get; set; }
        #endregion


        #region Constructor
        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }
        public Rectangle(int Height, int Width)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public Rectangle(int Val)
        {
            Width = Val;
            Height = Val;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"Height = {Height}  ,  Width = {Width}";
        }
        #endregion
    }
}
