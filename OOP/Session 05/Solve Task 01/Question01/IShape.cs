using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task_01.Question01
{
    interface IShape
    {
        protected double Area { get; set; }

        public void DisplayShapeInfo();
    }
}
