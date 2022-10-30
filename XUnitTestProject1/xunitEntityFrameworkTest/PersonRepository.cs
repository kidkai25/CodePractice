using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xunitEntityFrameworkTest
{
    public class PersonRepository : IPersonRepository
    {
        private PersonDataContext PersonDataContext;

        public PersonRepository(PersonDataContext personDataContext)
        {
            this.PersonDataContext = personDataContext;
        }

        public Person Add(Person person)
        {
            PersonDataContext.People.Add(person);
            PersonDataContext.SaveChanges();
            return person;
        }

        public ICollection<Person> GetAll()
        {
            return PersonDataContext.People.ToList();
        }
    }
}
