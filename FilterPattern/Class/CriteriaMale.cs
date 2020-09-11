using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public class CriteriaMale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.getGender().ToLower().Equals("male"))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}
