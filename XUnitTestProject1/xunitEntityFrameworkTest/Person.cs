using System;
using System.Collections.Generic;
using System.Text;

namespace xunitEntityFrameworkTest
{
     public class Person
    {
        public int PersonId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public ICollection<EmailAddress> EmailAddresses { get; set; }
    }
}
