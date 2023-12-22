using System;

namespace PowerPoint.Enum
{
    public enum ShapeType
    {
        None,
        Line,
        MyRectangle,
        MyEllipse
    }

    public static class ShapeTypeParser
    {
        // Comment
        public static ShapeType Parse(int index)
        {
            ShapeType[] shapeTypes = { ShapeType.Line, ShapeType.MyRectangle, ShapeType.MyEllipse };
            return shapeTypes[index];
        }
    }
}
