using System;

namespace PowerPoint.Model.Component
{
    public class MyPoint
    {
        private readonly Tuple<double, double> _location = null;
        
        public MyPoint(Tuple<double, double> location)
        {
            _location = location;
        }

        // Comment
        public MyPoint Scale(MyPoint other)
        {
            double first = _location.Item1 * other._location.Item1;
            double second = _location.Item2 * other._location.Item2;
            return new MyPoint(Tuple.Create(first, second));
        }
    }
}
