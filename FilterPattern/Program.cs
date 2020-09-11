/*
 * 过滤器模式
过滤器模式（Filter Pattern）或标准模式（ICriteria Pattern）是一种设计模式，
这种模式允许开发人员使用不同的标准来过滤一组对象，通过逻辑运算以解耦的方式把它们连接起来。
这种类型的设计模式属于结构型模式，它结合多个标准来获得单一标准。

Example: LINQ
 */

using System;
using System.Collections.Generic;

namespace FilterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("Robert", "Male", "Single"));
            persons.Add(new Person("John", "Male", "Married"));
            persons.Add(new Person("Laura", "Female", "Married"));
            persons.Add(new Person("Diana", "Female", "Single"));
            persons.Add(new Person("Mike", "Male", "Single"));
            persons.Add(new Person("Bobby", "Male", "Single"));

            Console.WriteLine("All persons: ");
            PrintPersons(persons);

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("\nMales: ");
            PrintPersons(male.MeetCriteria(persons));

            Console.WriteLine("\nFemales: ");
            PrintPersons(female.MeetCriteria(persons));

            Console.WriteLine("\nSingle Males: ");
            PrintPersons(singleMale.MeetCriteria(persons));

            Console.WriteLine("\nSingle Or Females: ");
            PrintPersons(singleOrFemale.MeetCriteria(persons));
        }

        private static void PrintPersons(List<Person> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine("Person : [ Name : " + person.getName()
                    + ", Gender : " + person.getGender()
                    + ", Marital Status : " + person.getMaritalStatus()
                    + " ]");
            }
        }
    }
}
