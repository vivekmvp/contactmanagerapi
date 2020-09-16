using ContactManagerApi_SQLServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagerApi_SQLServer.DbOpr
{
    public interface IPerson
    {
        List<Person> GetAllPerson();
        Person GetPersons(int Id);
        bool UpdatePerson(Person person);
        bool DeletePerson(Person person);

        bool InitializeSeedData();
    }
}
