﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public class AndCriteria : ICriteria
    {
        private ICriteria criteria;
        private ICriteria otherCriteria;

        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaPersons = criteria.MeetCriteria(persons);
            return otherCriteria.MeetCriteria(firstCriteriaPersons);
        }
    }
}
