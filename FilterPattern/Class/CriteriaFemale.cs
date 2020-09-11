using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public class CriteriaFemale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.getGender().ToLower().Equals("female"))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}
