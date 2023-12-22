using System;

namespace PowerPoint.Model.Component
{
    public abstract class Shape
    {
        protected Tuple<MyPoint, MyPoint> _transform = null;
        
        protected Shape(Tuple<MyPoint, MyPoint> transform)
        {
            _transform = transform;
        }

        // Comment
        public void Resize(MyPoint anchor)
        {
            _transform = Tuple.Create(_transform.Item1, anchor);
        }

        // Comment
        public void Scale(MyPoint scale)
        {
            _transform = Tuple.Create(_transform.Item1.Scale(scale), _transform.Item2.Scale(scale));
        }

        // Comment
        public abstract Shape Clone();
    }
}
