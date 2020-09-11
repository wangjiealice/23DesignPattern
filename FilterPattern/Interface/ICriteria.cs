using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public interface ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons);
    }
}
