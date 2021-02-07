using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{


    public class MyEnumerable : IEnumerable
    {
        static List<Person> persons = new List<Person>()
        {
          new Person("Robert", "Male", "Single"),
          new Person("John", "Male", "Married"),
          new Person("Laura", "Female", "Married"),
          new Person("Diana", "Female", "Single"),
          new Person("Mike", "Male", "Single"),
          new Person("Bobby", "Male", "Single"),
        };

        static List<Person> resultPersons = new List<Person>();

        //public List<T> Find(Predicate<T> match)
        //{
        //    foreach (string str in this)
        //    {
        //        if (match(str))
        //        {
        //            return str;
        //        }
        //    }
        //    return string.Empty;
        //}

        static List<Person> SinglePerson(Predicate<Person> match)
        {
            foreach (var person in persons)
            {
                if (match(person))
                {
                    return person;
                }
            }
            return null;
        }

        static Predicate<Person> SinglePerson()
        {
            return delegate (Person person)
            {
                return person.getMaritalStatus().ToLower().Equals("single");
            };
        }

        static Predicate<Person> FemalePerson()
        {
            return delegate (Person person)
            {
                return person.getGender().ToLower().Equals("female");
            };
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
