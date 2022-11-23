using System;

namespace Exam_2
{
    class Cylinder : Shape3D
    {
        public Cylinder(double hdiameter, double vdiameter, double heigth) : base(ShapeType.Cylinder, new Ellipse(hdiameter, vdiameter), heigth)
        {
            Length = hdiameter;
            Width = vdiameter;
        }
    }
}