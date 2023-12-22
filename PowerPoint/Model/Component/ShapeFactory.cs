using System;
using PowerPoint.Enum;

namespace PowerPoint.Model.Component
{
    public static class ShapeFactory
    {
        private static readonly Random _random = new Random();
        
        // Comment
        public static Shape Create(ShapeType shapeType, Tuple<MyPoint, MyPoint> transform)
        {
            switch (shapeType)
            {
                case ShapeType.Line:
                    return new Line(transform);
                case ShapeType.MyRectangle:
                    return new MyRectangle(transform);
                case ShapeType.MyEllipse:
                    return new MyEllipse(transform);
                default:
                    throw new ArgumentException();
            }
        }

        // Comment
        public static Shape CreateRandom(ShapeType shapeType)
        {
            var first = new MyPoint(Tuple.Create(_random.NextDouble(), _random.NextDouble()));
            var second = new MyPoint(Tuple.Create(_random.NextDouble(), _random.NextDouble()));
            return Create(shapeType, Tuple.Create(first, second));
        }
    }
}
