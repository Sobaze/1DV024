using System;

namespace Exam_2
{
    class Cuboid : Shape3D
    {
        public Cuboid(double length, double width, double heigth) : base(ShapeType.Cuboid, new Rectangle(length,width), heigth) 
        {
            Length = length;
            Width = width;
        }
    }
}