using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Meal
    {
        List<IItem> items = new List<IItem>();
        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;
            foreach (var item in items)
            {
                cost += item.Price();
            }
            return cost;
        }

        public void ShowItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine("Item : " + item.Name());
                Console.WriteLine(", Packing : " + item.Packing().Pack());
                Console.WriteLine(", Price : " + item.Price());
            }
        }
    }
}
