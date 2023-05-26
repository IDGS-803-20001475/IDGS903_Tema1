using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_TEMA1.Models
{
    public class Puntos
    {
        public double x1 { get; set; }
        public double x2 { get; set; }
        public double y1 { get; set; }
        public double y2 { get; set; }
        public double res { get; set; }
    public void Calculos()
    {
        double r = Math.Pow((this.x2 - this.x1), 2) + Math.Pow((this.y2 - this.y1), 2);
            this.res = Math.Sqrt(r);
    }
    }

    
}
