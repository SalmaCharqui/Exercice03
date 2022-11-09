using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    internal class Program

    {
        public class Point
        {
            private double x, y;
            public Point(double x1,double y1)
            {
                x = x1;
                y = y1;
            }
            public double getX()
            {
                return x;
            }
            public double getY()
            {
                return y;
            }
            public void setX(double p)
            {
                x = p;
            }
            public void setY(double p)
            {
                y = p;
            }
            public double distance(Point p)
            {
                return Math.Sqrt((x-p.x)*(x-p.x)+(y-p.y)*(y-p.y));
            }
            public Boolean egalite(Point a)
            {
                return (this.x==a.x && this.y==a.y);
            }
            public void translate(double d)
            {
                x = x + d;
                y = y + d;
            }
            public Boolean linearite (Point p1,Point p2,Point p3)
            {
                return ((p1.getY()-p2.getY())/(p1.getX()-p2.getX())) == ((p3.getY()-p2.getY())/(p3.getX()-p2.getX()));
            }

        }
        static void Main(string[] args)
        {
            Point p1 = new Point(1,2);
            Point p2 = new Point(1,- 2);
            Console.WriteLine(p1.distance(p2));
            Console.ReadLine();
           


        }
    }
}
