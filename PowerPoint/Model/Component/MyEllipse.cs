using System;

namespace PowerPoint.Model.Component
{
    public class MyEllipse : Shape
    {
        public MyEllipse(Tuple<MyPoint, MyPoint> transform) : base(transform)
        {

        }

        // Comment
        public override Shape Clone()
        {
            return new MyEllipse(_transform);
        }
    }
}
