﻿namespace SOLID._03_LSP._01_Example.Good
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area() => Width * Height;
    }
}
