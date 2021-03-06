﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        //使用 getShape 方法获取形状类型的对象
        public IShape GetShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new Square();
            }

            return null;
        }
    }
}
