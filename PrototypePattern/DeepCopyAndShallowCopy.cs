using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PrototypePattern
{
    public enum myEnum
    { _1 = 1, _2 = 2, _6 = 6 }

    public struct myStruct
    {
        public int _int;
        public myStruct(int i)
        { _int = i; }
    }

    public class myClass
    {
        public string _string;
        public myClass(string s)
        { _string = s; }
    }

    public class DemoClass : ICloneable
    {
        public int _int = 1;
        public string _string = "1";
        public myEnum _enum = myEnum._1;
        public myStruct _struct = new myStruct(1);
        public myClass _class = new myClass("1");
        public int[] arrInt = new int[] { 1 };
        public string[] arrString = new string[] { "1" };

        public object Clone()
        {
            //MemberwiseClone：shallow copy
            return this.MemberwiseClone();
        }
    }

    public class DeepCopy
    {
        public static T DeepCopyByReflection<T>(T obj)
        {
            if (obj is string || obj.GetType().IsValueType)
                return obj;

            object retval = Activator.CreateInstance(obj.GetType());
            FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            foreach (var field in fields)
            {
                try
                {
                    field.SetValue(retval, DeepCopyByReflection(field.GetValue(obj)));
                }
                catch { }
            }

            return (T)retval;
        }
    }

}
