using OOP3_Assignment.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_Assignment.Classes
{
    internal class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area{get { return Length * Width; }}

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"rectangle - length: {Length},width: {Width},area: {Area}");
        }
    }
}
