using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public class CriteriaSingle : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.getMaritalStatus().ToLower().Equals("single"))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}
