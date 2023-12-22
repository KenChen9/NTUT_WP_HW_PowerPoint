using System;

namespace PowerPoint.Model.Component
{
    public class MyRectangle : Shape
    {
        public MyRectangle(Tuple<MyPoint, MyPoint> transform) : base(transform)
        {

        }

        // Comment
        public override Shape Clone()
        {
            return new MyRectangle(_transform);
        }
    }
}
