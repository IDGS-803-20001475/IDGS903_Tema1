using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_TEMA1.Models
{
    public class Triangulos
    {
        public double x1 { get; set; }
        public double x2 { get; set; }
        public double x3 { get; set; }
        public double y1 { get; set; }
        public double y2 { get; set; }
        public double y3 { get; set; }
        public double la1 { get; set; }
        public double la2 { get; set; }
        public double la3 { get; set; }
        public double mayor { get; set; }
        public string tt { get; set; }
        public double t { get; set; }
        public double area { get; set; }
        public double b { get; set; }
        public double a { get; set; }

        public void Lados()
        {
            this.la1 = Math.Round(Math.Sqrt(Math.Pow((this.x2 - this.x1), 2) + Math.Pow((this.y2 - this.y1), 2)));
            this.la2 = Math.Round(Math.Sqrt(Math.Pow((this.x3 - this.x2), 2) + Math.Pow((this.y3 - this.y2), 2)));
            this.la3 = Math.Round(Math.Sqrt(Math.Pow((this.x1 - this.x3), 2) + Math.Pow((this.y1 - this.y3), 2)));

        }

        public void GenerarRes()
        {
            this.mayor = 0.0;
            if (this.la1 < (this.la2 + this.la3))
            {
                this.mayor = this.la1;
            }
            else if (this.la2 < (this.la3 + this.la1))
            {
                this.mayor = this.la2;
            }
            else if (this.la3 < (this.la2 + this.la1))
            {
                this.mayor = this.la3;
            }

            this.t = 0;
            this.tt = "No es un triangulo";
            this.area = 0.0;
            if (this.mayor > 0.0)
            {
                this.t = 1;
            }

            if (this.t == 1)
            {

                if (this.la1 == this.la2 && this.la1 == this.la3)
                {
                    this.tt = "Es un Triangulo equilatero";
                    this.b = this.la1;
                    this.a = Math.Sqrt(Math.Pow(this.la2, 2) - Math.Pow(this.b / 2, 2));
                    this.area = (this.b * this.a) / 2;
                }
                else if (this.la1 != this.la2 && this.la1 != this.la3 && this.la2 != this.la3)
                {
                    this.tt = "Triangulo escaleno";


                    double sp = (la1 + la2 + la3) / 2; // 8 
                    this.area = Math.Sqrt(sp * (sp - la1) * (sp - la2)
                                * (sp - la3));

                }
                else// 8 * 4 * 1 * 3 
                {
                    this.tt = "Triangulo Isosceles";
                    this.b = this.la1;
                    this.a = Math.Sqrt(Math.Pow(this.la2, 2) - Math.Pow(this.b / 2, 2));
                    this.area = (this.b * this.a) / 2;
                }


            }

        }
    }
            
        

    }