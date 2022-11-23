using System;

namespace Exam_2
{
    public abstract class Shape
    {
        public bool is3D
        {
            get 
            {

                if (ShapeType == ShapeType.Cuboid || ShapeType == ShapeType.Cylinder || ShapeType == ShapeType.Sphere)
                {
                    return true;
                }  
                else
                {
                    return false;
                }
            }
        }
        public ShapeType ShapeType 
        {
            get;
            private set; 
        }

        protected Shape(ShapeType shapeType)
        {
            ShapeType = shapeType;
            
        }

         abstract public string ToString(string format);
    }
}