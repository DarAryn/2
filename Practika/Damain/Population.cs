using System.Collections;
using System.Collections.Generic;

namespace Practika.Damain
{
    public class Population
    {
        public IList<Person> Peoples { get; set; }

        public Population()
        {
            Peoples = new List<Person>();
        }
    }
}