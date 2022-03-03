using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        //Overload method 
        public void Resize(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void Resize(double sameSize)
        {
            Width = sameSize;
            Height = sameSize;
        }

        //Overload operator
        public static Rectangle operator + (Rectangle a, Rectangle b)
        {
            return new Rectangle(a.Width + b.Width, a.Height + b.Height);
        }

        public static Rectangle operator - (Rectangle a, Rectangle b)
        {
            return new Rectangle(a.Width - b.Width, a.Height - b.Height);
        }

        //Other method
        public double GetArea()
        {
            return Width * Height;
        } 
    }
}
