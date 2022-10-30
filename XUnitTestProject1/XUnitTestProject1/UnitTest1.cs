using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;
using xunitEntityFrameworkTest;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Add_WhenHaveNoEmail()
        {
            IPersonRepository sut = GetInMemoryPersonRepository();
            Person person = new Person()
            {
                PersonId = 1,
                FirstName = "fred",
                Surname = "Blogs"
            };

            Person savedPerson = sut.Add(person);

            Assert.Equal(1, sut.GetAll().Count());
            Assert.Equal("fred", savedPerson.FirstName);
            Assert.Equal("Blogs", savedPerson.Surname);
            Assert.Null(savedPerson.EmailAddresses);
        }

        private IPersonRepository GetInMemoryPersonRepository()
        {
            DbContextOptions<PersonDataContext> options;
            var builder = new DbContextOptionsBuilder<PersonDataContext>();
            builder.UseInMemoryDatabase(databaseName: "xxx");
            options = builder.Options;
            PersonDataContext personDataContext = new PersonDataContext(options);
            personDataContext.Database.EnsureDeleted();
            personDataContext.Database.EnsureCreated();
            return new PersonRepository(personDataContext);
        }
    }
}