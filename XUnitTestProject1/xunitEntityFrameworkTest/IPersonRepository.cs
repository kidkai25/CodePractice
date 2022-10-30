using System;
using System.Collections.Generic;
using System.Text;

namespace xunitEntityFrameworkTest
{
    public interface IPersonRepository
    {
        ICollection<Person> GetAll();
        Person Add(Person person);
    }
}
