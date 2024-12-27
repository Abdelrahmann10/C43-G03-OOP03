using OOP3_Assignment.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_Assignment.Classes
{
    internal class Circle : ICircle
    {
        public double Redius { get; set; }
        public double Area
        {
            get{return Math.PI * Redius * Redius;}
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"circle - reduis: {Redius}, area: {Area}");
        }
    }
}
