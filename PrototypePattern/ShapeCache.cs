using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class ShapeCache
    {
        private static Hashtable shapeMap
      = new Hashtable();

        public static Shape getShape(string shapeId)
        {
            Shape cachedShape = (Shape)shapeMap[shapeId];
            return (Shape)cachedShape.Clone();
        }

        // 对每种形状都运行数据库查询，并创建该形状
        // shapeMap.put(shapeKey, shape);
        // 例如，我们要添加三种形状
        public static void loadCache()
        {
            Circle circle = new Circle();
            circle.SetId("1");
            shapeMap.Add(circle.GetId(), circle);

            Square square = new Square();
            square.SetId("2");
            shapeMap.Add(square.GetId(), square);

            Rectangle rectangle = new Rectangle();
            rectangle.SetId("3");
            shapeMap.Add(rectangle.GetId(), rectangle);
        }
    }
}
