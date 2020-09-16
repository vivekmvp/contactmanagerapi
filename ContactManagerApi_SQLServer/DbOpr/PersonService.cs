using ContactManagerApi_SQLServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagerApi_SQLServer.DbOpr
{
    public class PersonService : IPerson
    {
        private readonly PersonDbContext _context;
        public PersonService(PersonDbContext _context)
        {
            this._context = _context;
        }

        public List<Person> GetAllPerson()
        {
            return _context.Persons.ToList();
        }

        public Person GetPersons(int Id)
        {
            return _context.Persons.Find(Id);
        }
        
        public bool UpdatePerson(Person person)
        {
            _context.Update(person);
            _context.SaveChanges();
            return true;
        }

        public bool DeletePerson(Person person)
        {
            _context.Remove(person);
            _context.SaveChanges();
            return true;
        }

        public bool InitializeSeedData()
        {
            _context.Database.EnsureCreated();

            // Look for any students.
            if (_context.Persons.Any())
            {
                //Seed data already available
                return false;
            }

            var persons = new Person[]
            {
            new Person{FirstName="Carson",LastName="Alexander",DateOfBirth=DateTime.Parse("2005-09-01")},
            new Person{FirstName="Meredith",LastName="Alonso",DateOfBirth=DateTime.Parse("2002-09-01")},
            new Person{FirstName="Arturo",LastName="Anand",DateOfBirth=DateTime.Parse("2003-09-01")},
            new Person{FirstName="Gytis",LastName="Barzdukas",DateOfBirth=DateTime.Parse("2002-09-01")},
            new Person{FirstName="Yan",LastName="Li",DateOfBirth=DateTime.Parse("2002-09-01")},
            new Person{FirstName="Peggy",LastName="Justice",DateOfBirth=DateTime.Parse("2001-09-01")},
            new Person{FirstName="Laura",LastName="Norman",DateOfBirth=DateTime.Parse("2003-09-01")},
            new Person{FirstName="Nino",LastName="Olivetto",DateOfBirth=DateTime.Parse("2005-09-01")}
            };
            foreach (Person person in persons)
            {
                _context.Persons.Add(person);
            }
            _context.SaveChanges();

            return true;
        }
    }
}
