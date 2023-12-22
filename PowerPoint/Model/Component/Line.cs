using System;

namespace PowerPoint.Model.Component
{
    public class Line : Shape
    {
        public Line(Tuple<MyPoint, MyPoint> transform) : base(transform)
        {

        }
        
        // Comment
        public override Shape Clone()
        {
            return new Line(_transform);
        }
    }
}
