using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PrototypePattern
{
    public abstract class Shape : ICloneable
    {
        private string id;
        protected string type;

        public abstract void Draw();

        public string GetShapeType()
        {
            return type;
        }

        public string GetId()
        {
            return id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        //Shallow copy
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
