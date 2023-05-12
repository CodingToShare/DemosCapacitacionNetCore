using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DatabaseContext _db;

        public PersonRepository(DatabaseContext db)
        {
            _db = db;
        }

        public async Task AddPerson(Person person)
        {
            await _db.AddAsync(person);
            await _db.SaveChangesAsync();
        }

        public async Task<Person> GetPersonById(PersonId id)
        {
            return await _db.Persons.FindAsync((Guid)id);
        }
    }
}
