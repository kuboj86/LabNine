using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LabNineAreaOFCircle
{
    class Circle
    {
        private double _radius;

        public double radius
        {
            get { return this._radius; }
            set { this._radius = radius; }
        }

        public Circle(double radius)
        {
            this._radius = radius;
        }
        public double GetCircumference()
        {
             return 2 * Math.PI * _radius;
        }
        public string GetFormattedCircumference()
        {   
            return this.FormatNumber(this.GetCircumference());
        } 
        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
        public string GetFormattedArea()
        {
            return this.FormatNumber(this.GetArea());
        }
        private string FormatNumber(double x)
        { 
            return x.ToString("0.00");
        }
    }
}
